  using System;
  using System.Collections.Generic;
  using System.Text.RegularExpressions;
  using Com.Aspose.Email;
  using Com.Aspose.Email.Model;
  namespace Com.Aspose.Email.Api {
    public class EmailApi {
      string basePath;
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public EmailApi(String apiKey, String appSid, String basePath = "http://api.aspose.com/v1.1")
      {
	apiInvoker.apiKey = apiKey;
        apiInvoker.appSid = appSid;
        this.basePath = basePath;
      }

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }

      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }

      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      /// Get mail common info. Get mail common info.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public EmailDocument GetDocument(string name, string storage, string folder)
      {
        // create path and map variables
        var ResourcePath = "/email/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
            if (typeof(EmailDocument) == typeof(ResponseMessage))
            {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (EmailDocument)ApiInvoker.deserialize(response, typeof(EmailDocument));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
                return (EmailDocument)ApiInvoker.deserialize(response, typeof(EmailDocument));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Convert mail message to target format. Convert mail message to target format.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="format"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="outPath"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentWithFormat (string name, string format, string storage, string folder, string outPath) {
        // create path and map variables
        var ResourcePath = "/email/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || format == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (outPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])outPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "outPath" + "}", apiInvoker.ToPathValue(outPath)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Get email attachment by name. Get email attachment by name.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="attachName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetEmailAttachment (string name, string attachName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/email/{name}/attachments/{attachName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || attachName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (attachName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])attachName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "attachName" + "}", apiInvoker.ToPathValue(attachName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Read document property by name. Read document property by name.
      /// </summary>
      /// <param name="propertyName"></param>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public EmailPropertyResponse GetEmailProperty(string propertyName, string name, string storage, string folder)
      {
        // create path and map variables
        var ResourcePath = "/email/{name}/properties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (propertyName == null || name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
            if (typeof(EmailPropertyResponse) == typeof(ResponseMessage))
            {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (EmailPropertyResponse)ApiInvoker.deserialize(response, typeof(EmailPropertyResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
                return (EmailPropertyResponse)ApiInvoker.deserialize(response, typeof(EmailPropertyResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Add email attachment. Add email attachment.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="attachName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public EmailDocumentResponse PostAddEmailAttachment (string name, string attachName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/email/{name}/attachments/{attachName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || attachName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (attachName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])attachName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "attachName" + "}", apiInvoker.ToPathValue(attachName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(EmailDocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (EmailDocumentResponse) ApiInvoker.deserialize(response, typeof(EmailDocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (EmailDocumentResponse) ApiInvoker.deserialize(response, typeof(EmailDocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Add new email. Add new email.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public EmailDocumentResponse PutCreateNewEmail (string name, string storage, string folder, EmailDocument body) {
        // create path and map variables
        var ResourcePath = "/email/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(EmailDocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (EmailDocumentResponse) ApiInvoker.deserialize(response, typeof(EmailDocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (EmailDocumentResponse) ApiInvoker.deserialize(response, typeof(EmailDocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Set document property. Set document property.
      /// </summary>
      /// <param name="name"></param>
      /// <param name="propertyName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public EmailPropertyResponse PutSetEmailProperty (string name, string propertyName, string storage, string folder, EmailProperty body) {
        // create path and map variables
        var ResourcePath = "/email/{name}/properties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || propertyName == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(EmailPropertyResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (EmailPropertyResponse) ApiInvoker.deserialize(response, typeof(EmailPropertyResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (EmailPropertyResponse) ApiInvoker.deserialize(response, typeof(EmailPropertyResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Append message from a storage Append message from a storage
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="folder"></param>
      /// <param name="mailPath"></param>
      /// <param name="markAsSent"></param>
      /// <returns></returns>
      public SaaSposeResponse AppendMessage (string storage, string accountName1, string accountName2, string folder, string mailPath, bool? markAsSent) {
        // create path and map variables
        var ResourcePath = "/email/client/Append/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;mailPath={mailPath}&amp;markAsSent={markAsSent}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (mailPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])mailPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "mailPath" + "}", apiInvoker.ToPathValue(mailPath)); 
		}
        if (markAsSent == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])markAsSent=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "markAsSent" + "}", apiInvoker.ToPathValue(markAsSent)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Append mime message Append mime message
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="folder"></param>
      /// <param name="markAsSent"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaaSposeResponse AppendMimeMessage (string storage, string accountName1, string accountName2, string folder, bool? markAsSent, string body) {
        // create path and map variables
        var ResourcePath = "/email/client/AppendMime/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;markAsSent={markAsSent}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (markAsSent == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])markAsSent=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "markAsSent" + "}", apiInvoker.ToPathValue(markAsSent)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Creates the new folder Creates the new folder
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="parentFolder"></param>
      /// <param name="name"></param>
      /// <returns></returns>
      public SaaSposeResponse CreateFolder (string storage, string accountName1, string accountName2, string parentFolder, string name) {
        // create path and map variables
        var ResourcePath = "/email/client/CreateFolder/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;parentFolder={parentFolder}&amp;name={name}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (parentFolder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])parentFolder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "parentFolder" + "}", apiInvoker.ToPathValue(parentFolder)); 
		}
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Deletes the folder Deletes the folder
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="folder"></param>
      /// <param name="deletePermanently"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteFolder (string storage, string accountName1, string accountName2, string folder, bool? deletePermanently) {
        // create path and map variables
        var ResourcePath = "/email/client/DeleteFolder/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;deletePermanently={deletePermanently}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (deletePermanently == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])deletePermanently=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "deletePermanently" + "}", apiInvoker.ToPathValue(deletePermanently)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Deletes the mail message Deletes the mail message
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="messageId"></param>
      /// <param name="deletePermanently"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteMessage (string storage, string accountName1, string accountName2, string messageId, bool? deletePermanently) {
        // create path and map variables
        var ResourcePath = "/email/client/DeleteMessage/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;messageId={messageId}&amp;deletePermanently={deletePermanently}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (messageId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])messageId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "messageId" + "}", apiInvoker.ToPathValue(messageId)); 
		}
        if (deletePermanently == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])deletePermanently=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "deletePermanently" + "}", apiInvoker.ToPathValue(deletePermanently)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Fetches the message from server Fetches the message from server
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="messageId"></param>
      /// <returns></returns>
      public MimeResponse FetchMessage (string storage, string accountName1, string accountName2, string messageId) {
        // create path and map variables
        var ResourcePath = "/email/client/Fetch/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;messageId={messageId}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (messageId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])messageId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "messageId" + "}", apiInvoker.ToPathValue(messageId)); 
		}
        try {
          if (typeof(MimeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (MimeResponse) ApiInvoker.deserialize(response, typeof(MimeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (MimeResponse) ApiInvoker.deserialize(response, typeof(MimeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Gets collection of child folders from parent Gets collection of child folders from parent
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="parentFolder"></param>
      /// <returns></returns>
      public ListFoldersResponse ListFolders (string storage, string accountName1, string accountName2, string parentFolder) {
        // create path and map variables
        var ResourcePath = "/email/client/ListFolders/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;parentFolder={parentFolder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (parentFolder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])parentFolder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "parentFolder" + "}", apiInvoker.ToPathValue(parentFolder)); 
		}
        try {
          if (typeof(ListFoldersResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ListFoldersResponse) ApiInvoker.deserialize(response, typeof(ListFoldersResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ListFoldersResponse) ApiInvoker.deserialize(response, typeof(ListFoldersResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// List the messages in the specified folder. List the messages in the specified folder.
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="folder"></param>
      /// <param name="recursive"></param>
      /// <param name="queryString"></param>
      /// <returns></returns>
      public ListResponse ListMessages (string storage, string accountName1, string accountName2, string folder, bool? recursive, string queryString) {
        // create path and map variables
        var ResourcePath = "/email/client/ListMessages/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;recursive={recursive}&amp;queryString={queryString}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (recursive == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])recursive=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "recursive" + "}", apiInvoker.ToPathValue(recursive)); 
		}
        if (queryString == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])queryString=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "queryString" + "}", apiInvoker.ToPathValue(queryString)); 
		}
        try {
          if (typeof(ListResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ListResponse) ApiInvoker.deserialize(response, typeof(ListResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ListResponse) ApiInvoker.deserialize(response, typeof(ListResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Get mail common info. Get mail common info.
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName"></param>
      /// <param name="host"></param>
      /// <param name="port"></param>
      /// <param name="login"></param>
      /// <param name="password"></param>
      /// <param name="securityOptions"></param>
      /// <param name="protocolType"></param>
      /// <param name="description"></param>
      /// <returns></returns>
      public SaaSposeResponse SaveMailAccount (string storage, string accountName, string host, int? port, string login, string password, string securityOptions, string protocolType, string description) {
        // create path and map variables
        var ResourcePath = "/email/client/SaveMailAccount/?appSid={appSid}&amp;storage={storage}&amp;accountName={accountName}&amp;host={host}&amp;port={port}&amp;login={login}&amp;password={password}&amp;securityOptions={securityOptions}&amp;protocolType={protocolType}&amp;description={description}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (storage == null || accountName == null || host == null || port == null || login == null || password == null || securityOptions == null || protocolType == null || description == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName" + "}", apiInvoker.ToPathValue(accountName)); 
		}
        if (host == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])host=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "host" + "}", apiInvoker.ToPathValue(host)); 
		}
        if (port == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])port=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "port" + "}", apiInvoker.ToPathValue(port)); 
		}
        if (login == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])login=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "login" + "}", apiInvoker.ToPathValue(login)); 
		}
        if (password == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "password" + "}", apiInvoker.ToPathValue(password)); 
		}
        if (securityOptions == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])securityOptions=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "securityOptions" + "}", apiInvoker.ToPathValue(securityOptions)); 
		}
        if (protocolType == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])protocolType=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "protocolType" + "}", apiInvoker.ToPathValue(protocolType)); 
		}
        if (description == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])description=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "description" + "}", apiInvoker.ToPathValue(description)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Get mail common info. Get mail common info.
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName"></param>
      /// <param name="host"></param>
      /// <param name="port"></param>
      /// <param name="login"></param>
      /// <param name="clientId"></param>
      /// <param name="clientSecret"></param>
      /// <param name="refreshToken"></param>
      /// <param name="securityOptions"></param>
      /// <param name="protocolType"></param>
      /// <param name="description"></param>
      /// <returns></returns>
      public SaaSposeResponse SaveMailOAuthAccount (string storage, string accountName, string host, int? port, string login, string clientId, string clientSecret, string refreshToken, string securityOptions, string protocolType, string description) {
        // create path and map variables
        var ResourcePath = "/email/client/SaveMailOAuthAccount/?appSid={appSid}&amp;storage={storage}&amp;accountName={accountName}&amp;host={host}&amp;port={port}&amp;login={login}&amp;clientId={clientId}&amp;clientSecret={clientSecret}&amp;refreshToken={refreshToken}&amp;securityOptions={securityOptions}&amp;protocolType={protocolType}&amp;description={description}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (storage == null || accountName == null || host == null || port == null || login == null || clientId == null || clientSecret == null || refreshToken == null || securityOptions == null || protocolType == null || description == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName" + "}", apiInvoker.ToPathValue(accountName)); 
		}
        if (host == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])host=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "host" + "}", apiInvoker.ToPathValue(host)); 
		}
        if (port == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])port=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "port" + "}", apiInvoker.ToPathValue(port)); 
		}
        if (login == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])login=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "login" + "}", apiInvoker.ToPathValue(login)); 
		}
        if (clientId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])clientId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "clientId" + "}", apiInvoker.ToPathValue(clientId)); 
		}
        if (clientSecret == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])clientSecret=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "clientSecret" + "}", apiInvoker.ToPathValue(clientSecret)); 
		}
        if (refreshToken == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])refreshToken=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "refreshToken" + "}", apiInvoker.ToPathValue(refreshToken)); 
		}
        if (securityOptions == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])securityOptions=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "securityOptions" + "}", apiInvoker.ToPathValue(securityOptions)); 
		}
        if (protocolType == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])protocolType=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "protocolType" + "}", apiInvoker.ToPathValue(protocolType)); 
		}
        if (description == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])description=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "description" + "}", apiInvoker.ToPathValue(description)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Send mail message from a storage Send mail message from a storage
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="mailPath"></param>
      /// <returns></returns>
      public SaaSposeResponse Send (string storage, string accountName1, string accountName2, string mailPath) {
        // create path and map variables
        var ResourcePath = "/email/client/Send/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;mailPath={mailPath}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (mailPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])mailPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "mailPath" + "}", apiInvoker.ToPathValue(mailPath)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Send mail message Send mail message
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaaSposeResponse SendMime (string storage, string accountName1, string accountName2, string body) {
        // create path and map variables
        var ResourcePath = "/email/client/SendMime/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Marks the specifeid message as read. Marks the specifeid message as read.
      /// </summary>
      /// <param name="storage"></param>
      /// <param name="accountName1"></param>
      /// <param name="accountName2"></param>
      /// <param name="messageId"></param>
      /// <param name="isRead"></param>
      /// <returns></returns>
      public SaaSposeResponse SetReadFlag (string storage, string accountName1, string accountName2, string messageId, bool? isRead) {
        // create path and map variables
        var ResourcePath = "/email/client/SetReadFlag/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;messageId={messageId}&amp;isRead={isRead}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (accountName1 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName1=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName1" + "}", apiInvoker.ToPathValue(accountName1)); 
		}
        if (accountName2 == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])accountName2=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "accountName2" + "}", apiInvoker.ToPathValue(accountName2)); 
		}
        if (messageId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])messageId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "messageId" + "}", apiInvoker.ToPathValue(messageId)); 
		}
        if (isRead == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])isRead=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "isRead" + "}", apiInvoker.ToPathValue(isRead)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
