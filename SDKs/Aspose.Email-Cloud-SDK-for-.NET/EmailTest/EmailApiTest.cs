using Com.Aspose.Email.Api;
using Com.Aspose.Email.Model;
using Com.Aspose.Storage.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmailTest
{
    
    
    /// <summary>
    ///This is a test class for TestEmailApi and is intended
    ///to contain all TestEmailApi Unit Tests
    ///</summary>
    [TestClass()]
    public class TestEmailApi
    {

        protected string BASEPATH = "http://api.aspose.cloud/v1.1";
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AppendMessage
        ///</summary>
        //[TestMethod()]
        //public void TestAppendMessage()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string folder = null;
        //    string mailPath = null;
        //    bool? markAsSent = null;

        //    SaaSposeResponse actual;
        //    actual = target.AppendMessage(storage, accountName1, accountName2, folder, mailPath, markAsSent);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for AppendMimeMessage
        ///</summary>
        //[TestMethod()]
        //public void TestAppendMimeMessage()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
            
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string folder = null;
        //    bool? markAsSent = null;
        //    string body = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.AppendMimeMessage(storage, accountName1, accountName2, folder, markAsSent, body);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for CreateFolder
        ///</summary>
        //[TestMethod()]
        //public void TestCreateFolder()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
            
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string parentFolder = null;
        //    string name = null;
        //    storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.CreateFolder(storage, accountName1, accountName2, parentFolder, name);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for DeleteFolder
        ///</summary>
        //[TestMethod()]
        //public void TestDeleteFolder()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
            
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string folder = null;
        //    bool? deletePermanently = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.DeleteFolder(storage, accountName1, accountName2, folder, deletePermanently);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for DeleteMessage
        ///</summary>
        //[TestMethod()]
        //public void TestDeleteMessage()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string messageId = null;
        //    bool? deletePermanently = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.DeleteMessage(storage, accountName1, accountName2, messageId, deletePermanently);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for FetchMessage
        ///</summary>
        //[TestMethod()]
        //public void TestFetchMessage()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string messageId = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    MimeResponse actual;
        //    actual = target.FetchMessage(storage, accountName1, accountName2, messageId);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new MimeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for GetDocument
        ///</summary>
        [TestMethod()]
        public void TestGetDocument()
        {
            EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
            string name = "email_test.eml";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            EmailDocument actual;
            actual = target.GetDocument(name, storage, folder);
            
            Assert.AreNotEqual(null, actual);
            Assert.IsInstanceOfType(new EmailDocument(), actual.GetType()); 
        }

        /// <summary>
        ///A test for GetDocumentWithFormat
        ///</summary>
        [TestMethod()]
        public void TestGetDocumentWithFormat()
        {
            EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string name = "email_test.eml";
            string format = "msg";
            string storage = null;
            string folder = null;
            string outPath = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
            
            ResponseMessage actual;
            actual = target.GetDocumentWithFormat(name, format, storage, folder, outPath);
            
            Assert.AreEqual(200, actual.Code);
            Assert.IsInstanceOfType(new ResponseMessage(), actual.GetType()); 
        }

        /// <summary>
        ///A test for GetEmailAttachment
        ///</summary>
        [TestMethod()]
        public void TestGetEmailAttachment()
        {
            EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
            string name = "email_test2.eml";
            string attachName = "README.TXT";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
            
            ResponseMessage actual;
            actual = target.GetEmailAttachment(name, attachName, storage, folder);
            
            Assert.AreEqual(200, actual.Code);
            Assert.IsInstanceOfType(new ResponseMessage(), actual.GetType()); 
        }

        /// <summary>
        ///A test for GetEmailProperty
        ///</summary>
        [TestMethod()]
        public void TestGetEmailProperty()
        {
            EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string propertyName = "Body";
            string name = "email_test.eml";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            EmailPropertyResponse actual;
            actual = target.GetEmailProperty(propertyName, name, storage, folder);
            
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new EmailPropertyResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for ListFolders
        ///</summary>
        //[TestMethod()]
        //public void TestListFolders()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string parentFolder = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    ListFoldersResponse actual;
        //    actual = target.ListFolders(storage, accountName1, accountName2, parentFolder);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new ListFoldersResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for ListMessages
        ///</summary>
        //[TestMethod()]
        //public void TestListMessages()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string folder = null;
        //    bool? recursive = null;
        //    string queryString = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    ListResponse actual;
        //    actual = target.ListMessages(storage, accountName1, accountName2, folder, recursive, queryString);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new ListResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for PostAddEmailAttachment
        ///</summary>
        [TestMethod()]
        public void TestPostAddEmailAttachment()
        {
            EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string name = "email_test.eml";
            string attachName = "email_test.eml";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
            
            EmailDocumentResponse actual;
            actual = target.PostAddEmailAttachment(name, attachName, storage, folder);
            
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new EmailDocumentResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for PutCreateNewEmail
        ///</summary>
        [TestMethod()]
        public void TestPutCreateNewEmail()
        {
            EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string name = "email_test.eml";
            string storage = null;
            string folder = null;
            
            EmailDocument body = new EmailDocument();

            EmailProperties emailProperties = new EmailProperties();

            System.Collections.Generic.List<Link> links = new System.Collections.Generic.List<Link> { };
            System.Collections.Generic.List<EmailProperty> empProps = new System.Collections.Generic.List<EmailProperty> { };


            Link link = new Link();
            link.Href = "http://api.aspose.cloud/v1.1/pdf/";
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
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
            
            EmailDocumentResponse actual;
            actual = target.PutCreateNewEmail(name, storage, folder, body);
            
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new EmailDocumentResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for PutSetEmailProperty
        ///</summary>
        [TestMethod()]
        public void TestPutSetEmailProperty()
        {
            EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
            StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);

            string name = "email_test.eml";
            string propertyName = "Body";
            string storage = null;
            string folder = null;
            EmailProperty body = new EmailProperty();
            body.Name = "Subject";
            body.Value = "This is the subject";
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
            
            EmailPropertyResponse actual;
            actual = target.PutSetEmailProperty(name, propertyName, storage, folder, body);
            
            Assert.AreEqual("200", actual.Code);
            Assert.IsInstanceOfType(new EmailPropertyResponse(), actual.GetType()); 
        }

        /// <summary>
        ///A test for SaveMailAccount
        ///</summary>
        //[TestMethod()]
        //public void TestSaveMailAccount()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    string storage = null;
        //    string accountName = null;
        //    string host = null;
        //    System.Nullable<int> port = new System.Nullable<int>();
        //    string login = null;
        //    string password = null;
        //    string securityOptions = null;
        //    string protocolType = null;
        //    string description = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.SaveMailAccount(storage, accountName, host, port, login, password, securityOptions, protocolType, description);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for SaveMailOAuthAccount
        ///</summary>
        //[TestMethod()]
        //public void TestSaveMailOAuthAccount()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    string storage = null;
        //    string accountName = null;
        //    string host = null;
        //    System.Nullable<int> port = new System.Nullable<int>();
        //    string login = null;
        //    string clientId = null;
        //    string clientSecret = null;
        //    string refreshToken = null;
        //    string securityOptions = null;
        //    string protocolType = null;
        //    string description = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.SaveMailOAuthAccount(storage, accountName, host, port, login, clientId, clientSecret, refreshToken, securityOptions, protocolType, description);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for Send
        ///</summary>
        //[TestMethod()]
        //public void TestSend()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string mailPath = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.Send(storage, accountName1, accountName2, mailPath);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for SendMime
        ///</summary>
        //[TestMethod()]
        //public void TestSendMime()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string body = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.SendMime(storage, accountName1, accountName2, body);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}

        /// <summary>
        ///A test for SetReadFlag
        ///</summary>
        //[TestMethod()]
        //public void TestSetReadFlag()
        //{
        //    EmailApi target = new EmailApi(APIKEY, APPSID, BASEPATH);
        //    StorageApi storageApi = new StorageApi(APIKEY, APPSID, BASEPATH);
            
        //   // storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    string storage = null;
        //    string accountName1 = null;
        //    string accountName2 = null;
        //    string messageId = null;
        //    bool? isRead = null;
        //    //storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name)); 
        //    SaaSposeResponse actual;
        //    actual = target.SetReadFlag(storage, accountName1, accountName2, messageId, isRead);
        //    Assert.AreEqual("200", actual.Code);
        //    Assert.IsInstanceOfType(new SaaSposeResponse(), actual.GetType()); 
        //}


    }
}
