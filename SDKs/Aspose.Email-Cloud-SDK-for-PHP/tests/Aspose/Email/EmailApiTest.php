<?php

require_once realpath(__DIR__) . '/Utils.php';

use Aspose\Email\EmailApi;
use Aspose\Email\AsposeApp;

class EmailApiTest extends PHPUnit_Framework_TestCase {

    protected $email;

    protected function setUp() {
    	AsposeApp::$appSID = Utils::appSID;
        AsposeApp::$apiKey = Utils::apiKey;
		$this->email = new EmailApi();
    }

    public function testGetDocument() {
    	// Upload file to Aspose Cloud Storage
		$name = 'email_test.eml';
		Utils::uploadFile($name);

		$result = $this->email->GetDocument($name);
		$this->assertInternalType('string', $result);
    }


    public function testGetDocumentWithFormat() {
    	// Upload file to Aspose Cloud Storage
		$name = 'email_test.eml';
		Utils::uploadFile($name);

		$result = $this->email->GetDocumentWithFormat($name, "msg");
		$this->assertInternalType('string', $result);
    }

    public function testPutCreateNewEmail() {
		$name = 'email_test.eml';
		$body = array("DocumentProperties" => array("List" => array(array("Name" => "Body", "Value" => "demo"),array("Name" => "To", "Value" => "imranwar@gmail.com"),array("Name" => "From", 'Value' => "imranwar@gmail.com"))));
		//$body = '{"DocumentProperties": {"List": [{"Name": "Body","Value": "not empty"},{"Name": "To","Value": "imranwar@gmail.com"},{"Name": "From","Value": "imranwar@gmail.com"}]},"Format": "eml"}';
		Utils::uploadFile($name);
		
		$result = $this->email->PutCreateNewEmail($name, $storage = "", $folder = "", $body);
		$this->assertInstanceOf('\Aspose\Email\Models\EmailDocumentResponse', $result);
		$this->assertEquals(200, $result->Code);
    }


    public function testGetEmailProperty() {
    	// Upload file to Aspose Cloud Storage
		$name = 'email_test.eml';
		Utils::uploadFile($name);
		
		$result = $this->email->GetEmailProperty($propertyName = "Subject", $name);
		$this->assertInternalType('string', $result);
    }

    public function testGetEmailAttachment() {
		$name = 'email_test2.eml';
		$attachName = "README.TXT";
		Utils::uploadFile($name);

		$result = $this->email->GetEmailAttachment($name, $attachName);
		$this->assertInternalType('string', $result);
    }

    public function testPostAddEmailAttachment() {
		$name = 'email_test.eml';
		$attachName = "README.TXT";
		Utils::uploadFile($name);
		Utils::uploadFile($attachName);
		
		$result = $this->email->PostAddEmailAttachment($name, $attachName, $storage = "", $folder = "");
		$this->assertInstanceOf('\Aspose\Email\Models\EmailDocumentResponse', $result);
		$this->assertEquals(200, $result->Code);
    }

    public function testPutSetEmailProperty() {
		$body = '{
	                 "Name": "CC",
	                 "Value": {"info@example.com"}
	            }';
	            
		$name = 'email_test.eml';
		Utils::uploadFile($name);
		
		$result = $this->email->PutSetEmailProperty($name, $propertyName = "CC", $storage = "", $folder = "", $body);
		$this->assertInstanceOf('\Aspose\Email\Models\EmailPropertyResponse', $result);
		$this->assertEquals(200, $result->Code);
    }

}
