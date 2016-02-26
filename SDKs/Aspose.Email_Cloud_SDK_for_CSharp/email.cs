using System;
using System.Collections.Generic;
using System.Text;
using Com.Aspose.Email.Api;
using Com.Aspose.Storage.Api;
using Com.Aspose.Email.Model;
namespace AsposeEmail
{
    class email
    {
        public static void Main(String[] args)
        {

string APIKEY = "xxxxxx";
string APPSID = "xxxxxx";
string BASEPATH = "http://api.aspose.com/v1.1";


///*
//*  Working with Email    
//*  Convert Emails to Other Formats 
//*/

//EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "email_test";
//String fileName = name + ".eml";
//String format = "msg";
//String storage = "";
//String folder = "";
//String outPath = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + fileName));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    ResponseMessage apiResponse = emailApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);

//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        System.IO.File.WriteAllBytes("\\temp\\new_" + fileName, apiResponse.ResponseStream);
//        Console.WriteLine("Convert Emails to Other Formats, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}




///*
//*  Working with Email    
//*  Add New Email 
//*/

//EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String name = "email_test";
//String fileName = name + ".eml";
//String storage = "";
//String folder = "";

//EmailDocument body = new EmailDocument();

//EmailProperties emailProperties = new EmailProperties();

//System.Collections.Generic.List<Link> links = new System.Collections.Generic.List<Link> { };
//System.Collections.Generic.List<EmailProperty> empProps = new System.Collections.Generic.List<EmailProperty> { };


//Link link = new Link();
//link.Href = "http://api.aspose.com/v1.1/pdf/";
//link.Rel = "self";
//link.Title = "NewField";
//link.Type = "link";
//links.Add(link);


//EmailProperty emailBody = new EmailProperty();
//EmailProperty emailTo = new EmailProperty();
//EmailProperty emailFrom = new EmailProperty();

//emailBody.Name = "Body";
//emailBody.Value = "This is the Body";
//emailBody.Link = link;
//empProps.Add(emailBody);

//emailTo.Name = "To";
//emailTo.Value = "u@u.com";
//emailTo.Link = link;
//empProps.Add(emailTo);

//emailFrom.Name = "From";
//emailFrom.Value = "i@i.com";
//emailFrom.Link = link;
//empProps.Add(emailFrom);


//emailProperties.List = empProps;
//emailProperties.Link = link;

//body.DocumentProperties = emailProperties;
//body.Links = links;

//try
//{
//    //invoke Aspose.PDF Cloud SDK API to append word document
//    EmailDocumentResponse apiResponse = emailApi.PutCreateNewEmail(fileName, storage, folder, body);

//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(fileName, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + fileName, storageRes.ResponseStream);
//        Console.WriteLine("Add New Email, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}



///*
//*  Working with Attachments     
//*  Download Attachment from Email
//*/

//EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String fileName = "email_test2.eml";
//String attachName = "README.TXT";
//String storage = "";
//String folder = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + fileName));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    ResponseMessage apiResponse = emailApi.GetEmailAttachment(fileName, attachName, storage, folder);

//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        System.IO.File.WriteAllBytes("\\temp\\new_" + attachName, apiResponse.ResponseStream);
//        Console.WriteLine("Download Attachment from Email, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}




///*
//*  Working with Attachments     
//*  Add email attachment
//*/

//EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String fileName = "email_test.eml";
//String attachName = "README.TXT";
//String storage = "";
//String folder = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + fileName));
//    storageApi.PutCreate(attachName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + attachName));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    EmailDocumentResponse apiResponse = emailApi.PostAddEmailAttachment(fileName, attachName, storage, folder);


//    if (apiResponse != null)
//    {
//        //download appended document from storage server
//        Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(fileName, null, null);
//        System.IO.File.WriteAllBytes("\\temp\\new_" + fileName, storageRes.ResponseStream);
//        Console.WriteLine("Add email attachment, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}



///*
//*  Working with Email Properties     
//*  Retrieve Message Properties 
//*/

//EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String fileName = "email_test.eml";
//String storage = "";
//String folder = "";

//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + fileName));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    EmailDocument apiResponse = emailApi.GetDocument(fileName, storage, folder);

//    if (apiResponse != null)
//    {
//     foreach(EmailProperty emailProperty in apiResponse.DocumentProperties.List){

//        Console.WriteLine("Property Name :: " + emailProperty.Name);
//        Console.WriteLine("Property Value :: " + emailProperty.Value);
//     }
//        Console.WriteLine("Retrieve Message Properties, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}



///*
//*  Working with Email Properties     
//*  Set Message Property
//*/

//EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
//StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

//String fileName = "email_test.eml";
//String propertyName = "Subject";
//String storage = "";
//String folder = "";

//EmailProperty emailSubject = new EmailProperty();
//emailSubject.Name = "Subject";
//emailSubject.Value = "This is a new subject";



//try
//{
//    //upload source file to aspose cloud storage
//    storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + fileName));

//    //invoke Aspose.PDF Cloud SDK API to append word document
//    EmailPropertyResponse apiResponse = emailApi.PutSetEmailProperty(fileName, propertyName, storage, folder, emailSubject);

//    if (apiResponse != null)
//    {
//        Console.WriteLine("Property Name :: " + apiResponse.EmailProperty.Name);
//        Console.WriteLine("Property Value :: " + apiResponse.EmailProperty.Value);
//        Console.WriteLine("Set Message Property, Done!");
//        Console.ReadKey();
//    }
//}
//catch (Exception ex)
//{
//    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

//}



/*
*  Working with Email Properties     
*  Get message property by name
*/

EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

String fileName = "email_test.eml";
String propertyName = "Body";
String storage = "";
String folder = "";

try
{
    //upload source file to aspose cloud storage
    storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + fileName));

    //invoke Aspose.PDF Cloud SDK API to append word document
    EmailPropertyResponse apiResponse = emailApi.GetEmailProperty(propertyName, fileName, storage, folder);

    if (apiResponse != null)
    {
        Console.WriteLine("Property Name :: " + apiResponse.EmailProperty.Name);
        Console.WriteLine("Property Value :: " + apiResponse.EmailProperty.Value);
        Console.WriteLine("Get message property by name, Done!");
        Console.ReadKey();
    }
}
catch (Exception ex)
{
    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

}



            ///*
            //*  Working with Email    
            //*  Convert Emails to Other Formats 
            //*/

            //EmailApi emailApi = new EmailApi(APIKEY, APPSID, BASEPATH);
            //StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            //String name = "email_test";
            //String fileName = name + ".eml";
            //String format = "msg";
            //String storage = "";
            //String folder = "";
            //String outPath = "";

            //try
            //{
            //    //upload source file to aspose cloud storage
            //    storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes("\\temp\\email\\resources\\" + fileName));

            //    //invoke Aspose.PDF Cloud SDK API to append word document
            //    ResponseMessage apiResponse = emailApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);

            //    if (apiResponse != null)
            //    {
            //        //download appended document from storage server
            //        System.IO.File.WriteAllBytes("\\temp\\new_" + fileName, apiResponse.ResponseStream);
            //        Console.WriteLine("Convert Emails to Other Formats, Done!");
            //        Console.ReadKey();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

            //}
//
//end...
//

        }
    }
}
