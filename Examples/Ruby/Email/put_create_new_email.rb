require 'aspose_email_cloud'

class Email

  include AsposeEmailCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("da77c9f5da014d91faf2961ecec2de66", "B01A15E5-1B83-4B9A-8EB3-0F2BFA6AC766")
    @email_api = EmailApi.new
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new 
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  def put_create_new_email
    file_name = "email_test2.eml"
    upload_file(file_name)

    email_document = EmailDocument.new

    email_body = EmailProperty.new
    email_to = EmailProperty.new
    email_from = EmailProperty.new

    email_body.name = "Body"
    email_body.value = "This is body"

    email_to.name = "To"
    email_to.value = "developer@aspose.com"

    email_from.name = "From"
    email_from.value = "sales@aspose.com"

    email_properties = EmailProperties.new
    email_properties.list = [email_body, email_to, email_from]

    email_document.document_properties = email_properties
    email_document.format = "eml"

    response = @email_api.put_create_new_email(file_name, email_document)
  end

end

email = Email.new()
puts email.put_create_new_email