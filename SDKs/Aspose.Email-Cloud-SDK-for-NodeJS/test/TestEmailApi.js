var fs = require('fs');
var StorageApi = require('asposestoragecloud');
var EmailApi = require('../lib/EmailApi');
var assert = require('assert');

var AppSID = 'XXX'; //sepcify App SID
var AppKey = 'XXX'; //sepcify App Key
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};
var data_path = './data/';

var storageApi = new StorageApi(config); 
var emailApi = new EmailApi(config);
var nodeunit = require('nodeunit');

exports.testGetDocument = function(test){
	
	test.expect(3);
	
	var name =  "email_test.eml";
	var storage = null;
	var folder= null;

	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		
		test.equal(responseMessage.status, 'OK', '');	
		emailApi.GetDocument(name, storage, folder, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			if(config.debug){console.log('body:', responseMessage.body);}
			test.equal(responseMessage.status, 'OK', '');
			test.ok(responseMessage.body !== null && typeof responseMessage.body.DocumentProperties !== 'undefined', "response body assertion should pass");
			test.done();
		});
	});
	
};

exports.testGetDocumentWithFormat = function(test){
	
	test.expect(2);
	
	var name =  "email_test.eml";
	var format = "msg";
	var storage = null;
	var folder= null;

	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		
		test.equal(responseMessage.status, 'OK', '');	
		emailApi.GetDocumentWithFormat(name, format, storage, folder, null, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			test.equal(responseMessage.status, 'OK', '');			
			test.done();
		});
	});
	
};


exports.testGetEmailAttachment = function(test){
	
	test.expect(2);
	
	var name =  "email_test2.eml";
	var attachName = "README.TXT";
	var storage = null;
	var folder= null;

	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		
		test.equal(responseMessage.status, 'OK', '');	
		emailApi.GetEmailAttachment(name, attachName, storage, folder, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}			
			test.equal(responseMessage.status, 'OK', '');			
			test.done();
		});
	});
	
};


exports.testPostAddEmailAttachment = function(test){
	
	test.expect(4);
	
	var name =  "email_test.eml";
	var attachName = "README.TXT";
	var storage = null;
	var folder= null;

	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		test.equal(responseMessage.status, 'OK', '');
		
		storageApi.PutCreate(attachName, null, null, data_path + attachName , function(responseMessage) {
			test.equal(responseMessage.status, 'OK', '');
			
			emailApi.PostAddEmailAttachment(name, attachName, storage, folder, function(responseMessage) {
				if(config.debug){console.log('status:', responseMessage.status);}
				if(config.debug){console.log('body:', responseMessage.body);}
				test.equal(responseMessage.status, 'OK', '');
				test.ok(responseMessage.body !== null && typeof responseMessage.body.Document !== 'undefined', "response body assertion should pass");
				test.done();
			});
		});
	});
	
};


exports.testGetEmailProperty = function(test){
	
	test.expect(3);
	
	var name =  "email_test.eml";
	var storage = null;
	var folder= null;

	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		
		test.equal(responseMessage.status, 'OK', '');	
		emailApi.GetDocument(name, storage, folder, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			if(config.debug){console.log('body:', responseMessage.body);}
			test.equal(responseMessage.status, 'OK', '');
			test.ok(responseMessage.body !== null && typeof responseMessage.body.DocumentProperties !== 'undefined', "response body assertion should pass");
			test.done();
		});
	});
	
};

exports.testPutCreateNewEmail = function(test){
	
	test.expect(3);
	
	var name =  "email_test2.eml";
	
	var body = {
			'DocumentProperties' : {
									'List' : [
			
										{
											'Name' : 'Body',
											'Value' : 'This is a body'
											},
											
											{
												'Name' : 'To',
												'Value' : 'developer@aspose.com'
												},
											
											{
												'Name' : 'From',
												'Value' : 'sales@aspose.com'
												}
			                         ]
									},
									'Format' : 'eml'
								};  
	var storage = null;
	var folder= null;

	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		
		test.equal(responseMessage.status, 'OK', '');	
		emailApi.PutCreateNewEmail(name, storage, folder, body, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			if(config.debug){console.log('body:', responseMessage.body);}
			test.equal(responseMessage.status, 'OK', '');
			test.ok(responseMessage.body !== null && typeof responseMessage.body.Document !== 'undefined', "response body assertion should pass");
			test.done();
		});
	});
};
exports.testPutSetEmailProperty = function(test){
	
	test.expect(3);
	
	var name =  "email_test.eml";
	var propertyName = "Subject";
	var body = {
			'Name' : 'Subject',
			'Value' : 'This is a new subject'
	};  
	var storage = null;
	var folder= null;

	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		
		test.equal(responseMessage.status, 'OK', '');	
		emailApi.PutSetEmailProperty(name, propertyName, storage, folder, body, function(responseMessage) {
			if(config.debug){console.log('status:', responseMessage.status);}
			if(config.debug){console.log('body:', responseMessage.body);}
			test.equal(responseMessage.status, 'OK', '');
			test.ok(responseMessage.body !== null && typeof responseMessage.body.EmailProperty !== 'undefined', "response body assertion should pass");
			test.done();
		});
	});
	
};


