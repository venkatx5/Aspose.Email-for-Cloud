<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Email\EmailApi;
use Aspose\Email\AsposeApp;

class Email {

	public $email;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->email = new EmailApi();
	}

	public function putCreateNewEmail() {
		// Upload file to Aspose Cloud Storage
		$fileName = "email_test2.eml";
		Utils::uploadFile($fileName);

		//$body = array("DocumentProperties" => array("List" => array(array("Name" => "Body", "Value" => "demo"),array("Name" => "To", "Value" => "developer@aspose.com"),array("Name" => "From", 'Value' => "sales@aspose.com"))));
		$body = '{"DocumentProperties": {"List": [{"Name": "Body", "Value": "This is body"}, {"Name": "To", "Value": "developer@aspose.com"}, {"Name": "From", "Value": "sales@aspose.com"}]}, "Format": "eml"}';
		$result = $this->email->PutCreateNewEmail($fileName, $storage = "", $folder = "", $body);
		print_r($result);
	}
}

$emailObj = new Email();
$emailObj->putCreateNewEmail();

?>