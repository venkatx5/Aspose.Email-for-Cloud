# Aspose.Email Cloud SDK For Ruby
This SDK lets you use [Aspose Cloud Email APIs](http://www.aspose.com/cloud/email-api.aspx) in your Ruby web apps.

## Installing
You can simply install Aspose Email Cloud SDK with gem:

`gem install aspose_email_cloud`

## Usage
APIs of this SDK can be called as follows:

```ruby
require 'aspose_email_cloud'

class EmailUsage
  
  include AsposeEmailCloud
  include AsposeStorageCloud
	
  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
    @email_api = EmailApi.new  
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new
    response = @storage_api.put_create(file_name, File.open("data/" << file_name,"r") { |io| io.read } )
  end
  
  def get_document_with_format
    #Get mail in specified format
    file_name = "email_test.eml"
    upload_file(file_name)
    
    response = @email_api.get_document_with_format(file_name, "msg")
  end
  
end
```
## Unit Tests
Aspose Email SDK includes a suite of unit tests within the [test]() subdirectory. These Unit Tests also serves as examples of how to use the Aspose OCR SDK.

## Contact
Your feedback is very important to us. Please email us all your queries and feedback at marketplace@aspose.com.

## License
Aspose Email SDK is available under the MIT license. See the [LICENSE]() file for more info.
