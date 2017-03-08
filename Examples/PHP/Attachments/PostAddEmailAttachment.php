<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Email\EmailApi;
use Aspose\Email\AsposeApp;

class Attachment {

	public $email;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->email = new EmailApi();
	}

	public function postAddEmailAttachment() {
		// Upload file to Aspose Cloud Storage
		$name = 'email_test.eml';
		$attachName = "README.TXT";
		Utils::uploadFile($name);
		Utils::uploadFile($attachName);
	
		$result = $this->email->PostAddEmailAttachment($name, $attachName, $storage = "", $folder = "");
		print_r($result);
	}
}

$attachment = new Attachment();
$attachment->postAddEmailAttachment();

?>