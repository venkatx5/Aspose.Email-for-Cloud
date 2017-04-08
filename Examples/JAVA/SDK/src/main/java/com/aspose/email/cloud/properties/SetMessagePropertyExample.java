package com.aspose.email.cloud.properties;

import java.nio.file.Path;

import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.cloud.examples.Utils;
import com.aspose.email.cloud.examples.working.ConvertEmailOtherFormats;
import com.aspose.email.model.EmailProperty;
import com.aspose.email.model.EmailPropertyResponse;
import com.aspose.storage.api.StorageApi;

public class SetMessagePropertyExample {

	public static void main(String[] args) {
		//ExStart: SetMessagePropertyExample
		String fileName = "email_test.eml";
		String propertyName = "Subject";
		String storage = "";
		String folder = "";

		EmailProperty emailSubject = new EmailProperty();
		emailSubject.setName ( "Subject");
		emailSubject.setValue ( "This is a new subject");
		Path inputFile = Utils.getPath(ConvertEmailOtherFormats.class, fileName);

		try
		{
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "",inputFile.toFile());

		    // Invoke Aspose.Email Cloud SDK API to set message property
		    EmailPropertyResponse apiResponse = emailApi.PutSetEmailProperty(fileName, propertyName, storage, folder, emailSubject);

		    if (apiResponse != null)
		    {
		    	System.out.println("Property Name :: " + apiResponse.getEmailProperty().getName());
		        System.out.println("Property Value :: " + apiResponse.getEmailProperty().getValue());
		        System.out.println("Set Message Property, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();
		}
		//ExEnd: SetMessagePropertyExample
	}

}
