<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Email\EmailApi;
use Aspose\Email\AsposeApp;

class EmailProperty {

	public $email;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->email = new EmailApi();
	}

	public function getDocument() {
		// Upload file to Aspose Cloud Storage
		$name = 'email_test.eml';
		Utils::uploadFile($name);
		
		$result = $this->email->GetDocument($name);
		print_r($result);
	}
}

$emailProperty = new EmailProperty();
$emailProperty->getDocument();

?>