#ExStart:
require 'aspose_email_cloud'

class Email

  include AsposeEmailCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("", "")
    @email_api = EmailApi.new
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new 
    response = @storage_api.put_create(file_name, File.open("../../../data/" << file_name,"r") { |io| io.read } )
  end

  # Get email in specified format
  def get_email_in_specified_format
    file_name = "email_test.eml"
    upload_file(file_name)

    response = @email_api.get_document_with_format(file_name, "msg")
  end

end

email = Email.new()
puts email.get_email_in_specified_format
#ExEnd: