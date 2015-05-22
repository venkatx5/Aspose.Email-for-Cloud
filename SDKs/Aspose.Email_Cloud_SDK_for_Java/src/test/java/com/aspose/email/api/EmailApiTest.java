package com.aspose.email.api;

import static org.junit.Assert.assertNull;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

import com.aspose.email.client.ApiException;
import com.aspose.email.model.EmailDocument;
import com.aspose.email.model.EmailDocumentResponse;
import com.aspose.email.model.EmailProperties;
import com.aspose.email.model.EmailProperty;
import com.aspose.email.model.EmailPropertyResponse;
import com.aspose.email.model.Link;
import com.aspose.email.model.ResponseMessage;
import com.aspose.storage.api.StorageApi;

/**
 *
 * @author Imran Anwar
 * @author Farooq Sheikh
 */
public class EmailApiTest {

	EmailApi emailApi;
	StorageApi storageApi;
	String appSID = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
	String apiKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

	public EmailApiTest() {
	}

	@BeforeClass
	public static void setUpClass() {
	}

	@AfterClass
	public static void tearDownClass() {
	}

	@Before
	public void setUp() {
		
	        emailApi = new EmailApi("http://api.aspose.com/v1.1",apiKey,appSID);
		storageApi = new StorageApi("http://api.aspose.com/v1.1",apiKey,appSID);
		
		try {
			System.out.println(getClass().getResource("/email_test.eml").toURI());
			storageApi.PutCreate("email_test.eml", "", "", new File(getClass().getResource("/email_test.eml").toURI()));
	                storageApi.PutCreate("email_test_attach.eml", "", "", new File(getClass().getResource("/email_test_attach.eml").toURI()));
		} catch (java.net.URISyntaxException uriExp) {
			System.out.println("uriExp:" + uriExp);
		}

	}

	@After
	public void tearDown() {
	}

	/**
	 * Test of GetDocument method, of class EmailApi.
	 */
	@Test
	public void testGetDocument() {
		System.out.println("GetDocument");
		String name = "email_test.eml";
		String storage = "";
		String folder = "";

		try {
			ResponseMessage result = emailApi.GetDocument(name, storage, folder);


		} catch (ApiException apiExp) {
			System.out.println("exp:" + apiExp.getMessage());
			assertNull(apiExp);
		}
	}

	/**
	 * Test of GetDocumentWithFormat method, of class EmailApi.
	 */
	@Test
	public void testGetDocumentWithFormat() {
		System.out.println("GetDocumentWithFormat");
		String name = "email_test.eml";
		String format = "msg";
		String storage = "";
		String folder = "";
		String outPath = "";

		try {
			ResponseMessage result = emailApi.GetDocumentWithFormat(name, format, storage, folder, outPath);


		} catch (ApiException apiExp) {
			System.out.println("exp:" + apiExp.getMessage());
			assertNull(apiExp);
		}
	}

	/**
	 * Test of GetEmailAttachment method, of class EmailApi.
	 */
	@Test
	public void testGetEmailAttachment() {
		System.out.println("GetEmailAttachment");
		String name = "email_test_attach.eml";
		String attachName = "readme.txt";
		String storage = "";
		String folder = "";

		try {
			ResponseMessage result = emailApi.GetEmailAttachment(name, attachName, storage, folder);


		} catch (ApiException apiExp) {
			System.out.println("exp:" + apiExp.getMessage());
			assertNull(apiExp);
		}
	}

	/**
	 * Test of GetEmailProperty method, of class EmailApi.
	 */
	@Test
	public void testGetEmailProperty() {
		System.out.println("GetEmailProperty");
		String propertyName = "Body";
		String name = "email_test.eml";
		String storage = "";
		String folder = "";

		try {
			ResponseMessage result = emailApi.GetEmailProperty(propertyName, name, storage, folder);


		} catch (ApiException apiExp) {
			System.out.println("exp:" + apiExp.getMessage());
			assertNull(apiExp);
		}
	}

	/**
	 * Test of PostAddEmailAttachment method, of class EmailApi.
	 */
	@Test
	public void testPostAddEmailAttachment() {
		System.out.println("PostAddEmailAttachment");
		String name = "email_test.eml";
		String attachName = "email_test.eml";
		String storage = "";
		String folder = "";

		try {
			EmailDocumentResponse result = emailApi.PostAddEmailAttachment(name, attachName, storage, folder);


		} catch (ApiException apiExp) {
			System.out.println("exp:" + apiExp.getMessage());
			assertNull(apiExp);
		}
	}

	/**
	 * Test of PutCreateNewEmail method, of class EmailApi.
	 */
	@Test
	public void testPutCreateNewEmail() {
		System.out.println("PutCreateNewEmail");
		String name = "email_test.eml";
		String storage = "";
		String folder = "";
		EmailDocument body = new EmailDocument();

		EmailProperties emailProperties = new EmailProperties();
		
		List<Link> links = new ArrayList();		
		List<EmailProperty> empProps = new ArrayList();		
		
		
		Link link = new Link();
		link.setHref("http://api.aspose.com/v1.1/pdf/");
		link.setRel("self");
		link.setTitle("NewField");
		link.setType("link");
		links.add(link);
		
				
		EmailProperty emailBody = new EmailProperty();
		EmailProperty emailTo = new EmailProperty();
		EmailProperty emailFrom = new EmailProperty();
		
		emailBody.setName("Body");
		emailBody.setValue("This is the Body");
		emailBody.setLink(link);
		empProps.add(emailBody);

		emailTo.setName("To");
		emailTo.setValue("u@u.com");
		emailTo.setLink(link);
		empProps.add(emailTo);

		emailFrom.setName("From");
		emailFrom.setValue("i@i.com");
		emailFrom.setLink(link);
		empProps.add(emailFrom);

		
		emailProperties.setList(empProps);
		emailProperties.setLink(link);
		
		body.setFormat("eml");
		body.setDocumentProperties(emailProperties);
		body.setLinks(links);

		try {
			EmailDocumentResponse result = emailApi.PutCreateNewEmail(name, storage, folder, body);


		} catch (ApiException apiExp) {
			System.out.println("exp:" + apiExp.getMessage());
			assertNull(apiExp);
		}
	}

	/**
	 * Test of PutSetEmailProperty method, of class EmailApi.
	 */
	@Test
	public void testPutSetEmailProperty() {
		System.out.println("PutSetEmailProperty");
		String name = "email_test.eml";
		String propertyName = "Body";
		String storage = "";
		String folder = "";
		
		EmailProperty emailSubject = new EmailProperty();
		
		emailSubject.setName("Subject");
		emailSubject.setValue("This is the subject");
		
		try {
			EmailPropertyResponse result = emailApi.PutSetEmailProperty(name, propertyName, storage, folder, emailSubject);


		} catch (ApiException apiExp) {
			System.out.println("exp:" + apiExp.getMessage());
			assertNull(apiExp);
		}
	}
}
