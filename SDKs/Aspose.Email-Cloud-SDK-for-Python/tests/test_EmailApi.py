import unittest
import os.path
import json
import inspect
import requests

import asposeemailcloud
from asposeemailcloud.EmailApi import EmailApi
from asposeemailcloud.EmailApi import ApiException
from asposeemailcloud.models import EmailDocumentResponse
from asposeemailcloud.models import EmailPropertyResponse
from asposeemailcloud.models import EmailDocument
from asposeemailcloud.models import EmailProperty
from asposeemailcloud.models import Link
from asposeemailcloud.models import EmailProperties

import asposestoragecloud 
from asposestoragecloud.StorageApi import StorageApi


import random
import string

class TestAsposeEmailCloud(unittest.TestCase):

    def setUp(self):

        with open('setup.json') as json_file:
            data = json.load(json_file)

        self.storageApiClient = asposestoragecloud.ApiClient.ApiClient(apiKey=str(data['app_key']),appSid=str(data['app_sid']),debug=True,apiServer=str(data['product_uri']))
        self.storageApi = StorageApi(self.storageApiClient)

        self.apiClient = asposeemailcloud.ApiClient.ApiClient(apiKey=str(data['app_key']),appSid=str(data['app_sid']),debug=True,apiServer=str(data['product_uri']))
        self.emailApi = EmailApi(self.apiClient)

        self.output_path = str(data['output_location'])

    def testGetDocument(self):

        try:
            name =  "email_test.eml"
            
            response = self.storageApi.PutCreate(name,'../../../Data/' + name)
            response = self.emailApi.GetDocument(name)            

            self.assertIsInstance(response,EmailDocument.EmailDocument)
            #self.assertEqual(response.Status,'OK')
        
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentWithFormat(self):

        try:
            fileName = "email_test"
            name =  "email_test.eml"
            format = "msg"
            
            response = self.storageApi.PutCreate(name,'../../../Data/' + name)
            response = self.emailApi.GetDocumentWithFormat(name, format)
            
            self.assertEqual(response.Status,'OK')
        
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetEmailAttachment(self):

        try:
            name =  "email_test2.eml"
            attachName = "README.TXT"
            
            response = self.storageApi.PutCreate(name,'../../../Data/' + name)
            response = self.emailApi.GetEmailAttachment(name, attachName)            

            self.assertEqual(response.Status,'OK')
        
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetEmailProperty(self):

        try:
            name =  "email_test.eml"
            propertyName = "Body"
            
            response = self.storageApi.PutCreate(name,'../../../Data/' + name)
            response = self.emailApi.GetEmailProperty(propertyName, name)            

            self.assertIsInstance(response,EmailPropertyResponse.EmailPropertyResponse)
            self.assertEqual(response.Status,'OK')
        
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostAddEmailAttachment(self):

        try:
            name =  "email_test.eml"
            attachName = "README.TXT"
            
            response = self.storageApi.PutCreate(name,'../../../Data/' + name)
            response = self.storageApi.PutCreate(attachName,'../../../Data/' + attachName)
            
            response = self.emailApi.PostAddEmailAttachment(name, attachName)            

            self.assertIsInstance(response,EmailDocumentResponse.EmailDocumentResponse)
            self.assertEqual(response.Status,'OK')
        
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPutCreateNewEmail(self):

        try:
            name =  "email_test2.eml"
            
            body = EmailDocument.EmailDocument()
            
            emailBody = EmailProperty.EmailProperty()
            emailTo = EmailProperty.EmailProperty()
            emailFrom = EmailProperty.EmailProperty()
            
            emailBody.Name = "Body"
            emailBody.Value = "This is body"
            
            emailTo.Name = "To"
            emailTo.Value = "developer@aspose.com"
            
            emailFrom.Name = "From"
            emailFrom.Value = "sales@aspose.com"
            
            emailProps = EmailProperties.EmailProperties()
            emailProps.List = [emailBody, emailTo, emailFrom]
            
            body.DocumentProperties = emailProps
            body.Format = "eml" 
            
            #response = self.storageApi.PutCreate(name,'../../../Data/' + name)
            response = self.emailApi.PutCreateNewEmail(name, body)            

            self.assertIsInstance(response,EmailDocumentResponse.EmailDocumentResponse)
            self.assertEqual(response.Status,'OK')
        
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPutSetEmailProperty(self):

        try:
            name =  "email_test.eml"
            propertyName = "Subject"
            
            body = EmailProperty.EmailProperty()
            body.Name = "Subject"
            body.Value = "This is a new subject"
            
            
            response = self.storageApi.PutCreate(name,'../../../Data/' + name)
            response = self.emailApi.PutSetEmailProperty(name, propertyName, body)            

            self.assertIsInstance(response,EmailPropertyResponse.EmailPropertyResponse)
            self.assertEqual(response.Status,'OK')
        
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex




if __name__ == '__main__':
    unittest.main()
