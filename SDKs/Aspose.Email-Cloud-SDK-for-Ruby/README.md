# Aspose.Email Cloud SDK For Ruby
This SDK lets you use [Aspose Cloud Email APIs](http://www.aspose.com/cloud/email-api.aspx) in your Ruby web apps.

##How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project or use Maven. For more details, please visit our [documentation website](http://www.aspose.com/docs/display/emailcloud/Available+SDKs).

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
Aspose Email SDK includes a suite of unit tests within the [test](https://github.com/asposeemail/Aspose_Email_Cloud/blob/master/SDKs/Aspose.Email_Cloud_SDK_for_Ruby/test/email_tests.rb) subdirectory. These Unit Tests also serves as examples of how to use the Aspose Email SDK.

##Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://www.aspose.com/community/forums/).
