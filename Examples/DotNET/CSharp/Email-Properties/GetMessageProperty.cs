using System;
using Com.Aspose.Email.Api;
using Com.Aspose.Email.Model;
using Com.Aspose.Storage.Api;

namespace Email_Properties
{
    class GetMessageProperty
    {
        public static void Run()
        {
            // ExStart:1
            EmailApi emailApi = new EmailApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "email_test.eml";
            String propertyName = "Body";
            String storage = "";
            String folder = "";

            try
            {
                // Upload source file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Email Cloud SDK API to get message property
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
            // ExEnd:1
        }
    }
}
