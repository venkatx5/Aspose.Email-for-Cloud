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

	public function getDocumentWithFormat() {
		// Upload file to Aspose Cloud Storage
		$fileName = "email_test.eml";
		Utils::uploadFile($fileName);	

		$result = $this->email->GetDocumentWithFormat($fileName, "msg");
		print_r($result);
	}
}

$emailObj = new Email();
$emailObj->getDocumentWithFormat();

?>