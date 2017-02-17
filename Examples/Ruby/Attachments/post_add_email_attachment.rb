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
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  def post_add_email_attachment
    file_name = "email_test.eml"
    upload_file(file_name)
    attach_name = "README.TXT"
    upload_file(attach_name)

    response = @email_api.post_add_email_attachment(file_name, attach_name)
  end

end

attachment = Attachment.new()
puts attachment.post_add_email_attachment