﻿using Realtair.Framework.Core.Data;
using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.Interfaces;
using Realtair.Framework.Core.Utilities;
using Realtair.Framework.Core.Web.Utilities;
using Realtair.Framework.Enquiries.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace ASP
{
    public static class MvcExtensions
    {
        public static User LoggedInUser(this HtmlHelper helper)
        {
            var session = (LoginSession)helper.ViewBag.LoginSession;
            if (session == null)
                return LoginSession.LoggedOutSession.User;
            else
                return session.User;

            //return null;
        }

        public static DbContext DbContext(this ViewContext helper)
        {
            return (helper.Controller as Realtair.Framework.Core.Web.Controllers.BaseController).DbContext;
        }

        public static bool ViewExists(this HtmlHelper helper, string path)
        {
            return ViewEngines.Engines.FindView(helper.ViewContext.Controller.ControllerContext, path, null).View != null;
        }

        public static MvcHtmlString IconForDescribable(this HtmlHelper helper, IDescribable describable)
        {
            return new MvcHtmlString("");
        }

        public static MvcHtmlString IconForDescribableType(this HtmlHelper helper, Type describable)
        {
            return MvcHtmlString.Create("icon-Info");
        }

        public class MenuItem
        {
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Url { get; set; }
            public bool UseHttpPost { get; set; } = false;
        }

        public static IEnumerable<MenuItem> ConciergeActions(this User user)
        {
            yield break;
        }

        public static bool ShouldShowMenu(this HtmlHelper helper, HttpRequestBase request)
        {
            return false;
        }

        public static MvcHtmlString ToRelativeDate(this HtmlHelper helper, DateTime dateTime)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = new TimeSpan(DateTime.Now.Ticks - dateTime.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
            {
                return MvcHtmlString.Create(ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago");
            }
            if (delta < 2 * MINUTE)
            {
                return MvcHtmlString.Create("a minute ago");
            }
            if (delta < 45 * MINUTE)
            {
                return MvcHtmlString.Create(ts.Minutes + " minutes ago");
            }
            if (delta < 90 * MINUTE)
            {
                return MvcHtmlString.Create("an hour ago");
            }
            if (delta < 24 * HOUR)
            {
                return MvcHtmlString.Create(ts.Hours + " hours ago");
            }
            if (delta < 48 * HOUR)
            {
                return MvcHtmlString.Create("yesterday");
            }
            if (delta < 30 * DAY)
            {
                return MvcHtmlString.Create(ts.Days + " days ago");
            }
            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return MvcHtmlString.Create(months <= 1 ? "one month ago" : months + " months ago");
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return MvcHtmlString.Create(years <= 1 ? "one year ago" : years + " years ago");
            }
        }

        public static IHtmlString TextToHtml(this HtmlHelper helper, string text)
        {
            if (text != null)
            {
                text = HttpUtility.HtmlEncode(text);
                text = text.Linkify();
                text = text.Replace("\r\n", "\r");
                text = text.Replace("\n", "\r");
                text = text.Replace("\r", "<br>\r\n");
                text = text.Replace("  ", " &nbsp;");
                return new HtmlString(text);
            }
            else
            {
                return new HtmlString("");
            };

        }

        public static MvcHtmlString Initials(this HtmlHelper helper, Person person)
        {
            return MvcHtmlString.Create($"{person.FirstName.ElementAt(0)}{person.LastName.ElementAt(0)}".ToUpper());
        }

        public static DateTime UTCToLocal(this DateTime datetime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(datetime, TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time"));
        }

        public static string Description(this Enum withDesc)
        {
            return Realtair.Framework.Core.Entities.Display.DisplayableExtensions.Description(withDesc);
        }

        public static MvcHtmlString Render(this HtmlHelper html, UrlHelper url, object describable)
        {
            if (describable == null)
            {
                return new MvcHtmlString("N/A");
            }
            else if (describable is string && ((describable as string).ToLower().StartsWith("https://") || (describable as string).ToLower().StartsWith("http://")))
            {
                return new MvcHtmlString($"<a href=\"{describable as string}\">view here</a>");
            }
            else if (describable is string)
            {
                return new MvcHtmlString(describable as string);
            }
            else if (describable is decimal || describable is double || describable is int)
            {
                return new MvcHtmlString(describable.ToString());
            }
            else if (describable is DateTime)
            {
                return new MvcHtmlString(((DateTime)describable).ToString("d MMM yyyy"));
            }
            else if (describable is Attachment)
            {
                var attachment = (describable as Attachment);
                return new MvcHtmlString($"<a href=\"{attachment.Url(0)}\" target=\"_blank\">{attachment.OriginalFileName}</a>");
            }
            else if (describable is IEnumerable<IDisplayable> || describable is IEnumerable<IHasDisplayable>)
            {
                string s = "";
                var d = describable as IEnumerable<IDescribable>;
                for (int i = 0; i < d.Count(); i++)
                {
                    s += $"<a href=\"{d.ElementAt(i).GetUrl(html.LoggedInUser(), url)}\">{d.ElementAt(i).Description(html.LoggedInUser())}</a>";
                    if (i < d.Count() - 1)
                    {
                        s += " & ";
                    }
                }

                return new MvcHtmlString(s);
            }
            else if (describable is IDisplayable || describable is IHasDisplayable || describable is Enquiry || describable is IExtendedEnquiry)
            {
                return new MvcHtmlString($"<a href=\"{(describable as IDescribable).GetUrl(html.LoggedInUser(), url)}\">{(describable as IDescribable).Description(html.LoggedInUser())}</a>");
            }
            else if (describable is IEnumerable<IDescribable>)
            {
                string s = "";
                var d = describable as IEnumerable<IDescribable>;
                for (int i = 0; i < d.Count(); i++)
                {
                    s += d.ElementAt(i).Description(html.LoggedInUser());
                    if (i < d.Count() - 1)
                    {
                        s += " & ";
                    }
                }

                return new MvcHtmlString(s);
            }
            else if (describable is IDescribable)
            {
                return new MvcHtmlString((describable as IDescribable).Description(html.LoggedInUser()));
            }
            else if (describable is Enum)
            {
                return new MvcHtmlString((describable as Enum).Description());
            }

            return new MvcHtmlString("N/A");
        }
    }
}