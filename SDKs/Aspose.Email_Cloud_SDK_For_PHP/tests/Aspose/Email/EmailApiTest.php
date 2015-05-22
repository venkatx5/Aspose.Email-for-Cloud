<?php

use Aspose\Email\EmailApi;

class EmailApiTest extends PHPUnit_Framework_TestCase {
    
    protected $email;

    protected function setUp()
    {        
        $this->email = new EmailApi();
    }
    
    public function testGetDocument()
    {
        $result = $this->email->GetDocument($name="email_test.eml");
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetEmailProperty()
    {
        $result = $this->email->GetEmailProperty($propertyName="Subject", $name="email_test.eml");
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetEmailAttachment()
    {
        $result = $this->email->GetEmailAttachment($name="email_test.eml", $attachName="attachment.txt");
        $this->assertInternalType('string', $result);
    }
    
    public function testPostAddEmailAttachment()
    {
        $result = $this->email->PostAddEmailAttachment($name="email_test.eml", $attachName="watermark.png", $storage="", $folder="");
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutSetEmailProperty()
    {
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
        $result = $this->email->PutSetEmailProperty($name="email_test.eml", $propertyName="CC", $storage="", $folder="", $body);
        $this->assertEquals(200, $result->Code);
    }
                     
}    