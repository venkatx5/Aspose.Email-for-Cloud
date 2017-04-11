#ExStart:
require 'aspose_email_cloud'

class Attachment

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

  # Get email attachment by name.
  def get_email_attachment_by_name
    file_name = "email_test2.eml"
    upload_file(file_name)
    attach_name = "README.TXT"

    response = @email_api.get_email_attachment(file_name, attach_name)
  end

end

attachment = Attachment.new()
puts attachment.get_email_attachment
#ExEnd: