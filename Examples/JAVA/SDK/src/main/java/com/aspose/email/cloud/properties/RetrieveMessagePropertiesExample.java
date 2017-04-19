package com.aspose.email.cloud.properties;

import java.nio.file.Path;

import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.cloud.examples.Utils;
import com.aspose.email.cloud.examples.working.ConvertEmailOtherFormats;
import com.aspose.email.model.EmailDocument;
import com.aspose.email.model.EmailProperty;
import com.aspose.storage.api.StorageApi;

public class RetrieveMessagePropertiesExample {

	public static void main(String[] args) {
		//ExStart: RetrieveMessagePropertiesExample
		String fileName = "email_test.eml";
		String storage = "";
		String folder = "";
		Path inputFile = Utils.getPath(ConvertEmailOtherFormats.class, fileName);

		try
		{
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "",inputFile.toFile());

		    // Invoke Aspose.Email Cloud SDK API to get message properties
		    EmailDocument apiResponse = emailApi.GetDocument(fileName, storage, folder);

		    if (apiResponse != null)
		    {
		        for (EmailProperty emailProperty : apiResponse.getDocumentProperties().getList())
		        {

		        	System.out.println("Property Name :: " + emailProperty.getName());
		        	System.out.println("Property Value :: " + emailProperty.getValue());
		        }
		        System.out.println("Retrieve Message Properties, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();

		}
		//ExEnd: RetrieveMessagePropertiesExample
	}

}
