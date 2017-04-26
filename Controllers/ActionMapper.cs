using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using Action = Realtair.Framework.Core.Actions.Action;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections;
using Realtair.Framework.Core.Interfaces;
using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.Actions.FieldAttributes;
using Realtair.Framework.Core.Actions;
using Realtair.Framework.Core.Data;
using System.Data.Entity;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class ActionMapper
    {
        DbContext Db;

        public ActionMapper(DbContext db)
        {
            Db = db;
        }

        public object Map(Action action, Field field, Type type, object value)
        {
            if (value == null || value.ToString() == "")
                return null;
            if (type == typeof(string))
                return MapString(value);
            else if (type == typeof(int))
                return MapInt(value);
            else if (type == typeof(decimal))
                return MapDecimal(value);
            else if (field.FieldAttribute is CheckboxFieldAttribute)
                return MapCheckbox(value);
            else if (type == typeof(bool))
                return MapBool(value);
            else if (type == typeof(DateTime))
                return MapDateTime(value);
            else if (type.IsEnum)
                return MapEnum(type, value);
            else if (type == typeof(Attachment) && field.FieldAttribute is FileUploadFieldAttribute)
                if (value.ToString().Length < 100)
                    return MapUploadedFile(value, field);
                else
                    return MapFileAsset(value);
            else if (field.FieldAttribute is BulkFileUploadFieldAttribute)
                return MapUnusedExistingFileAsset(value);
            else if (field.FieldAttribute.Provider != null)
                return MapProvided(action, field, type, value);
            else if (type == typeof(PhoneNumber.PhoneNumberViewModel))
                return MapPhoneNumberViewModel(value);
            else if (typeof(Entity).IsAssignableFrom(type))
                return MapEntity(type, value);
            else if (type == typeof(HttpPostedFileWrapper))
                return value;
            else if (typeof(ICustomViewModel).IsAssignableFrom(type))
                return MapCustomViewModel(type, value);
            else
                throw new NotImplementedException($"Can't map {type.FullName}, you need to add a custom mapping.");
        }
        
        object MapProvided(Action action, Field field, Type type, object value)
        {
            return field.FieldAttribute.GetProvider().Single(action, action.User, value.ToString());
        }

        DateTime MapDateTime(object value)
        {
            return DateTime.Parse(value.ToString());
        }

        string MapString(object value)
        {
            return Convert.ToString(value);
        }

        int MapInt(object value)
        {
            return Convert.ToInt32(value);
        }

        decimal MapDecimal(object value)
        {
            return Convert.ToDecimal(value);
        }

        bool MapBool(object value)
        {
            return Convert.ToBoolean(value);
        }

        object MapEnum(Type type, object value)
        {
            if (value != null)
                return Enum.Parse(type, value.ToString());
            else
                return null;
        }
        
        object MapPhoneNumberViewModel(object value)
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<PhoneNumber.PhoneNumberViewModel>(value.ToString());
            }
            catch
            {
                return new PhoneNumber.PhoneNumberViewModel { Number = value.ToString() };
            }
        }

        object MapCustomViewModel(Type modelType, object value)
        {
            var a = Activator.CreateInstance(modelType) as ICustomViewModel;
            return a.Deserialize(value as string);
        }
        
        IEnumerable<int> MapMultiSelectList(object value)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<int[]>(value.ToString());
        }

        IEnumerable<Attachment> MapExistingFileAsset(object value)
        {
            var strings = (string[])value;
            var ids = Newtonsoft.Json.JsonConvert.DeserializeObject<int[]>(strings.ElementAt(0));
            if (ids == null) return new Attachment[] {};
            var attachments = new List<Attachment>();
            foreach (var id in ids)
            {
                var a = new Attachment(Db.Set<Attachment>().Single(f => f.Id == id));
                Db.Set<Attachment>().Add(a);
                Db.SaveChanges();
                attachments.Add(a);
            }

            return attachments;
        }


        IEnumerable<Attachment> MapUnusedExistingFileAsset(object value)
        {
            var strings = (string[])value;
            var ids = Newtonsoft.Json.JsonConvert.DeserializeObject<int[]>(strings.ElementAt(0));
            if (ids == null) return new Attachment[] { };
            var attachments = new List<Attachment>();
            foreach (var id in ids)
            {
                attachments.Add(Db.Set<Attachment>().Find(id));
            }

            return attachments;
        }


        IEnumerable<Attachment> MapUploadOrExistingFileAsset(object value)
        {
            var strings = (IEnumerable<string>)value;

            if (string.IsNullOrEmpty(strings.First()) && strings.Count() > 1)
                strings = strings.Skip(1);

            var attachments = strings.Take(strings.Count() - 1).Select(MapFileAsset).ToList();
            attachments.AddRange(MapExistingFileAsset(new[] { strings.Last() }));

            return attachments;
        }

        Entity MapEntity(Type type, object value)
        {
            return Db.Set(type).Find(new object[] { Convert.ToInt32(value) }) as Entity;
        }

        public Attachment MapUploadedFile(object value, Field field)
        {
            var f = (field.Value as IList<Attachment>);
            var t = JsonConvert.DeserializeObject<int[]>(value as string);
            field.Value = new List<Attachment>(t.Select(ti => Db.Set<Attachment>().Find(ti)));
            return null;
        }

        public Attachment MapFileAsset(object value)
        {
            var matcher = new Regex(@"data:(?<mime>[\w/\-\.]+);(?<encoding>\w+),(?<data>.*)", RegexOptions.Compiled);

            var name = value.ToString().Split('|').ElementAtOrDefault(0);
            if (name == null) name = "";

            var data = value.ToString().Split('|').ElementAtOrDefault(1);
            if (data == null) data = "";

            var captures = matcher.Match(data);
            if (captures.Success)
            {
                var base64 = captures.Groups["data"].Value;
                var mimeType = captures.Groups["mime"].Value;
                var bytes = Convert.FromBase64String(base64);
                var file = new Attachment(name.Replace(",", ""), mimeType, new MemoryStream(bytes));
                Db.Set<Attachment>().Add(file);
                Db.SaveChanges();
                return file;
            }
            else
            {
                return null; // due to IE work-around in the file picker, there will always be one empty image
            }
        }

        bool MapCheckbox(object value) => value != null;
    }
}