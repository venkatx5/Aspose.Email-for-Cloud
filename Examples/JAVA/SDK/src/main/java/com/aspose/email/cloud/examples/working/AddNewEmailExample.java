package com.aspose.email.cloud.examples.working;

import java.util.ArrayList;

import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.model.EmailDocument;
import com.aspose.email.model.EmailDocumentResponse;
import com.aspose.email.model.EmailProperties;
import com.aspose.email.model.EmailProperty;
import com.aspose.email.model.Link;
import com.aspose.storage.api.StorageApi;

public class AddNewEmailExample {

	public static void main(String[] args) {
		//ExStart: AddNewEmailExample
		String name = "email_test";
		String fileName = name + ".eml";
		String storage = "";
		String folder = "";

		EmailDocument body = new EmailDocument();

		EmailProperties emailProperties = new EmailProperties();

		ArrayList<Link> links = new ArrayList<Link>();
		ArrayList<EmailProperty> empProps = new ArrayList<EmailProperty>();


		Link link = new Link();
		link.setHref ("http://api.aspose.com/v1.1/pdf/");
		link.setRel ( "self");
		link.setTitle ( "NewField");
		link.setType ("link");
		links.add(link);


		EmailProperty emailBody = new EmailProperty();
		EmailProperty emailTo = new EmailProperty();
		EmailProperty emailFrom = new EmailProperty();

		emailBody.setName ("Body");
		emailBody.setValue ( "This is the Body");
		emailBody.setLink ( link);
		empProps.add(emailBody);

		emailTo.setName ( "To");
		emailTo.setValue ( "u@u.com");
		emailTo.setLink ( link);
		empProps.add(emailTo);

		emailFrom.setName ( "From");
		emailFrom.setValue ( "i@i.com");
		emailFrom.setLink ( link);
		empProps.add(emailFrom);


		emailProperties.setList ( empProps);
		emailProperties.setLink ( link);

		body.setDocumentProperties ( emailProperties);
		body.setLinks ( links);

		try
		{
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Invoke Aspose.Email Cloud SDK API to add new email
		    EmailDocumentResponse apiResponse = emailApi.PutCreateNewEmail(fileName, storage, folder, body);

		    if (apiResponse != null)
		    {                    
		        System.out.println("Add New Email, Done!");
		    }
		}
		catch (Exception ex)
		{
		  ex.printStackTrace();
		}
		//ExEnd: AddNewEmailExample
	}
}
