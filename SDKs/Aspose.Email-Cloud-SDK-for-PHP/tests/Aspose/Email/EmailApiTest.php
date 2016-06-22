<?php

use Aspose\Email\EmailApi;
use Aspose\Storage\StorageApi;

class EmailApiTest extends PHPUnit_Framework_TestCase {

    protected $email;
    protected $storageApi;

    protected function setUp() {
	$this->email = new EmailApi();
	$this->storageApi = new StorageApi();
    }

    public function testGetDocument() {
	$name = 'email_test.eml';
	$result = $this->storageApi->PutCreate($name, "", $storage = "", getcwd() . '\\Data\\Input\\' . $name);
	$result = $this->email->GetDocument($name);
	$this->assertInternalType('string', $result);
    }


    public function testGetDocumentWithFormat() {
	$name = 'email_test.eml';
	$result = $this->storageApi->PutCreate($name, "", $storage = "", getcwd() . '\\Data\\Input\\' . $name);
	$result = $this->email->GetDocumentWithFormat($name, "msg");
	$this->assertInternalType('string', $result);
	
    }

    public function testPutCreateNewEmail() {
	$name = 'email_test.eml';
	$body = array("DocumentProperties" => array("List" => array(array("Name" => "Body", "Value" => "demo"),array("Name" => "To", "Value" => "imranwar@gmail.com"),array("Name" => "From", 'Value' => "imranwar@gmail.com"))));
	//$body = '{"DocumentProperties": {"List": [{"Name": "Body","Value": "not empty"},{"Name": "To","Value": "imranwar@gmail.com"},{"Name": "From","Value": "imranwar@gmail.com"}]},"Format": "eml"}';
	$result = $this->storageApi->PutCreate($name, "", $storage = "", getcwd() . '\\Data\\Input\\' . $name);
	$result = $this->email->PutCreateNewEmail($name,$storage = "", $folder = "",$body);
	$this->assertInstanceOf('\Aspose\Email\Models\EmailDocumentResponse', $result);
	$this->assertEquals(200, $result->Code);
    }


    public function testGetEmailProperty() {
	$name = 'email_test.eml';
	$result = $this->storageApi->PutCreate($name, "", $storage = "", getcwd() . '\\Data\\Input\\' . $name);
	$result = $this->email->GetEmailProperty($propertyName = "Subject", $name);
	$this->assertInternalType('string', $result);
    }

    public function testGetEmailAttachment() {
	$name = 'email_test2.eml';
	$attachName = "README.TXT";
	$result = $this->storageApi->PutCreate($name, "", $storage = "", getcwd() . '\\Data\\Input\\' . $name);

	$result = $this->email->GetEmailAttachment($name, $attachName);
	$this->assertInternalType('string', $result);
    }

    public function testPostAddEmailAttachment() {
	$name = 'email_test.eml';
	$attachName = "README.TXT";
	$result = $this->storageApi->PutCreate($name, "", $storage = "", getcwd() . '\\Data\\Input\\' . $name);
	$result = $this->storageApi->PutCreate($attachName, "", $storage = "", getcwd() . '\\Data\\Input\\' . $attachName);
	
	$result = $this->email->PostAddEmailAttachment($name, $attachName, $storage = "", $folder = "");
	$this->assertInstanceOf('\Aspose\Email\Models\EmailDocumentResponse', $result);
	$this->assertEquals(200, $result->Code);
    }

    public function testPutSetEmailProperty() {
	$body = '{
                    "Link": {
                      "Href": "",
                      "Rel": "",
                      "Type": "",
                      "Title": ""
                    },
                    "Name": "CC",
                    "Value": {"info@example.com"}
                  }';
	$name = 'email_test.eml';
	$result = $this->storageApi->PutCreate($name, "", $storage = "", getcwd() . '\\Data\\Input\\' . $name);
	$result = $this->email->PutSetEmailProperty($name, $propertyName = "CC", $storage = "", $folder = "", $body);
	$this->assertInstanceOf('\Aspose\Email\Models\EmailPropertyResponse', $result);
	$this->assertEquals(200, $result->Code);
    }

}
