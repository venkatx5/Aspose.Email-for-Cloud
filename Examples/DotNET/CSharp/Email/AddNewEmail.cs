using System;
using Com.Aspose.Email.Api;
using Com.Aspose.Email.Model;
using Com.Aspose.Storage.Api;

namespace Email
{
    class AddNewEmail
    {
        public static void Run()
        {
            // ExStart:1
            EmailApi emailApi = new EmailApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String name = "email_test";
            String fileName = name + ".eml";
            String storage = "";
            String folder = "";

            EmailDocument body = new EmailDocument();

            EmailProperties emailProperties = new EmailProperties();

            System.Collections.Generic.List<Link> links = new System.Collections.Generic.List<Link> { };
            System.Collections.Generic.List<EmailProperty> empProps = new System.Collections.Generic.List<EmailProperty> { };


            Link link = new Link();
            link.Href = "http://api.aspose.com/v1.1/pdf/";
            link.Rel = "self";
            link.Title = "NewField";
            link.Type = "link";
            links.Add(link);


            EmailProperty emailBody = new EmailProperty();
            EmailProperty emailTo = new EmailProperty();
            EmailProperty emailFrom = new EmailProperty();

            emailBody.Name = "Body";
            emailBody.Value = "This is the Body";
            emailBody.Link = link;
            empProps.Add(emailBody);

            emailTo.Name = "To";
            emailTo.Value = "u@u.com";
            emailTo.Link = link;
            empProps.Add(emailTo);

            emailFrom.Name = "From";
            emailFrom.Value = "i@i.com";
            emailFrom.Link = link;
            empProps.Add(emailFrom);


            emailProperties.List = empProps;
            emailProperties.Link = link;

            body.DocumentProperties = emailProperties;
            body.Links = links;

            try
            {
                // Invoke Aspose.Email Cloud SDK API to add new email
                EmailDocumentResponse apiResponse = emailApi.PutCreateNewEmail(fileName, storage, folder, body);

                if (apiResponse != null)
                {                    
                    Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(fileName, null, null);
                    System.IO.File.WriteAllBytes(Common.GetDataDir() + fileName, storageRes.ResponseStream);
                    Console.WriteLine("Add New Email, Done!");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

            }
            // ExEnd:1
        }
    }
}
