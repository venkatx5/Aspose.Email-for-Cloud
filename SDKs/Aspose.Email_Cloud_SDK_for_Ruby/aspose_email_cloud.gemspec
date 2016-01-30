# -*- encoding: utf-8 -*-
$:.push File.expand_path("../lib", __FILE__)
require "aspose_email_cloud/version"

Gem::Specification.new do |s|
  s.name        = "aspose_email_cloud"
  s.version     = AsposeEmailCloud::VERSION
  s.platform    = Gem::Platform::RUBY
  s.authors     = ["M. Sohail Ismail"]
  s.email       = ["muhammad.sohail@aspose.com"]
  s.homepage    = "http://www.aspose.com/cloud/email-api.aspx"
  s.summary     = %q{Aspose.Email for Cloud}
  s.description = %q{Aspose.Email for Cloud is a REST API for creating email archiving applications that work with common email file formats. It lets developers manipulate message formats such as MSG, EML, and MHT files. The API supports many common tasks, for example accessing messages, reading message properties such as sender, receiver, message sent date, and message details. It also supports converting messages back and forth between EML, MSG and MHT formats. With Aspose.Email for Cloud, it is further possible to access messages and retrieve attachments that can then be saved to a local disc. The robust API saves developers time and effort when programming with emails in the cloud.}
  s.license     = "MIT"

  s.add_runtime_dependency 'typhoeus', '~> 0.8'
  s.add_runtime_dependency 'json', '~> 1.7'
  s.add_runtime_dependency 'aspose_storage_cloud', '~> 1.0', '>= 1.0.0'

  s.add_development_dependency 'minitest', '~> 5.8'

  s.files         = `git ls-files`.split("\n")
  s.test_files    = `git ls-files -- test/*`.split("\n")
  s.executables   = []
  s.require_paths = ["lib"]
end
