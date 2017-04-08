package com.aspose.email.cloud.examples.working.attachments;

import java.io.File;
import android.content.Context;
import android.provider.MediaStore;

import java.util.ArrayList;

import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.R;
import com.aspose.email.cloud.Utils;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.model.EmailDocument;
import com.aspose.email.model.EmailDocumentResponse;
import com.aspose.email.model.EmailProperties;
import com.aspose.email.model.EmailProperty;
import com.aspose.email.model.Link;
import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.ResponseMessage;


public class AddNewAttachment {

	public static void execute(Context context) {
		//ExStart: AddNewAttachment

		String name = "email_test";
		String fileName = name + ".eml";
		String storage = "";
		String folder = "";

		EmailDocument body = new EmailDocument();

		EmailProperties emailProperties = new EmailProperties();

		ArrayList<Link> links = new ArrayList<Link>();
		ArrayList<EmailProperty> empProps = new ArrayList<EmailProperty>();


		Link link = new Link();
		link.setHref ( "http://api.aspose.com/v1.1/pdf/");
		link.setRel ("self");
		link.setTitle ( "NewField");
		link.setType ( "link");
		links.add(link);


		EmailProperty emailBody = new EmailProperty();
		EmailProperty emailTo = new EmailProperty();
		EmailProperty emailFrom = new EmailProperty();

		emailBody.setName("Body");
		emailBody.setValue ("This is the Body");
		emailBody.setLink ( link);
		empProps.add(emailBody);

		emailTo.setName ( "To");
		emailTo.setValue ( "u@u.com");
		emailTo.setLink (link);
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
		        ResponseMessage storageRes = storageApi.GetDownload(fileName, null, null);
				File outputFile = Utils.stream2file("sample2","xlsx", context.getResources().openRawResource(R.raw.emailtest));
				Utils.copyInputStreamToFile(storageRes.getInputStream(),outputFile);


		    	System.out.println("Add New Email, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();
		}

		//ExEnd: AddNewAttachment
	}

}
