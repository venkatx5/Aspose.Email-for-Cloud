using System;
using Com.Aspose.Email.Api;
using Com.Aspose.Email.Model;
using Com.Aspose.Storage.Api;

namespace Email_Properties
{
    class SetMessageProperty
    {
        public static void Run()
        {
            // ExStart:1
            EmailApi emailApi = new EmailApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "email_test.eml";
            String propertyName = "Subject";
            String storage = "";
            String folder = "";

            EmailProperty emailSubject = new EmailProperty();
            emailSubject.Name = "Subject";
            emailSubject.Value = "This is a new subject";

            try
            {
                // Upload source file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Email Cloud SDK API to set message property
                EmailPropertyResponse apiResponse = emailApi.PutSetEmailProperty(fileName, propertyName, storage, folder, emailSubject);

                if (apiResponse != null)
                {
                    Console.WriteLine("Property Name :: " + apiResponse.EmailProperty.Name);
                    Console.WriteLine("Property Value :: " + apiResponse.EmailProperty.Value);
                    Console.WriteLine("Set Message Property, Done!");
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
