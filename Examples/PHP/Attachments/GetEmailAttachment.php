//ExStart:
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

	public function getEmailAttachment() {
		// Upload file to Aspose Cloud Storage
		$fileName = "email_test2.eml";
		Utils::uploadFile($fileName);

		$attachName = "README.TXT";
		$result = $this->email->GetEmailAttachment($fileName, $attachName);
		print_r($result);
	}
}

$attachment = new Attachment();
$attachment->getEmailAttachment();

?>
//ExEnd:
