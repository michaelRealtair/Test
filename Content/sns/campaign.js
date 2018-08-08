var querystring = require('querystring');
var request = require('request');
require('https').globalAgent.options.ca = require('ssl-root-cas/latest').create();

//Test Webhook Url
//https://webhook.site/733e8dee-7992-4687-b54b-e42096322dc9

/* Create Campaign */
module.exports.CreateCampaignAssist = (event, context, callback) => {  
    console.log(event.Records[0].Sns.Message);
    request.post({
        url: 'https://assist.realtair.com/api/central/create-campaign',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })   
    console.log('Assist Campaign Notified'); 
};

module.exports.CreateCampaignSign = (event, context, callback) => {  
    console.log(event.Records[0].Sns.Message);
    request.post({
        url: 'https://sign.realtair.com/api/central/create-campaign',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })    
    console.log('Sign Campaign Notified'); 
};

module.exports.CreateCampaignPitch = (event, context, callback) => {  
    request.post({
        url: 'https://pitch.realtair.com/api/central/create-campaign',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })    
    console.log('Pitch Campaign Notified'); 
};

/* Update Campaign */
module.exports.UpdateCampaignAssist = (event, context, callback) => {  
    request.post({
        url: 'https://assist.realtair.com/api/central/update-campaign',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })    
    console.log('Assist Campaign Updated'); 
};

module.exports.UpdateCampaignSign = (event, context, callback) => {  
    request.post({
        url: 'https://sign.realtair.com/api/central/update-campaign',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })    
    console.log('Sign Campaign Updated'); 
};

module.exports.UpdateCampaignPitch = (event, context, callback) => {  
    request.post({
        url: 'https://pitch.realtair.com/api/central/update-campaign',
        headers: {'Content-Type': 'application/json'},
        body: event.Records[0].Sns.Message,
        "rejectUnauthorized": false
    })    
    console.log('Pitch Campaign Updated'); 
};