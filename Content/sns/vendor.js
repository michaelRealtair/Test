var querystring = require('querystring');
var request = require('request');
require('https').globalAgent.options.ca = require('ssl-root-cas/latest').create();

//Test Webhook Url
//https://webhook.site/733e8dee-7992-4687-b54b-e42096322dc9

/* Create Vendor */
module.exports.CreateVendorAssist = (event, context, callback) => {  
    console.log(event.Records[0].Sns.Message);
    request.post({
        url: 'https://assist.realtair.com/api/central/create-vendor',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })   
    console.log('Assist Vendor Created'); 
};

module.exports.CreateVendorSign = (event, context, callback) => {  
    console.log(event.Records[0].Sns.Message);
    request.post({
        url: 'https://sign.realtair.com/api/central/create-vendor',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })    
    console.log('Sign Vendor Created'); 
};

module.exports.CreateVendorPitch = (event, context, callback) => {  
    request.post({
        url: 'https://pitch.realtair.com/api/central/create-vendor',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })    
    console.log('Sign Vendor Created'); 
};

/* Update Vendor */
module.exports.UpdateVendorAssist = (event, context, callback) => {  
    console.log(event.Records[0].Sns.Message);
    request.post({
        url: 'https://assist.realtair.com/api/central/update-vendor',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })        
    console.log('Assist Vendor Updated'); 
};

module.exports.UpdateVendorSign = (event, context, callback) => {   
    console.log(event.Records[0].Sns.Message);
    request.post({
        url: 'https://sign.realtair.com/api/central/update-vendor',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })        
    console.log('Sign Vendor Updated'); 
};

module.exports.UpdateVendorPitch = (event, context, callback) => {  
    console.log(event.Records[0].Sns.Message); 
    request.post({
        url: 'https://pitch.realtair.com/api/central/update-vendor',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })        
    console.log('Pitch Vendor Updated'); 
};