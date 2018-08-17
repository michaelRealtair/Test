'use strict';
var AWS = require("aws-sdk");
var querystring = require('querystring');
var request = require('request');

var sns = new AWS.SNS({
  endpoint: "http://127.0.0.1:4002",
  region: "us-east-1",
});

/* Campaign */
module.exports.CreateCampaign = (event, context, callback) => {
  sns.publish({
    Message: event.body,
    MessageStructure: "json",
    TopicArn: "arn:aws:sns:us-east-1:123456789012:CreateCampaign",
  }, () => {    
    const response = {
      statusCode: 200,
      body: JSON.stringify({message: 'Create campaign notification sent!'}),
    };
    callback(null, response);
  });
};

module.exports.UpdateCampaign = (event, context, callback) => {
  sns.publish({
    Message: event.body,
    MessageStructure: "json",
    TopicArn: "arn:aws:sns:us-east-1:123456789012:UpdateCampaign",
  }, () => {    
    const response = {
      statusCode: 200,
      body: JSON.stringify({message: 'Update campaign notification sent!'}),
    };
    callback(null, response);
  });
};

/* Vendor */
module.exports.UpdateVendor = (event, context, callback) => {
  sns.publish({
    Message: event.body,
    MessageStructure: "json",
    TopicArn: "arn:aws:sns:us-east-1:123456789012:UpdateVendor",
  }, () => {    
    const response = {
      statusCode: 200,
      body: JSON.stringify({message: 'Update vendor notification sent!'}),
    };
    callback(null, response);
  });
};