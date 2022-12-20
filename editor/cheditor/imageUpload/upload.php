<?php
require_once("config.php");

//----------------------------------------------------------------------------
//
//
$tempfile = $_FILES['file']['tmp_name'];
$filename = $_FILES['file']['name'];
$filename_len = strrpos($filename, ".");
$type = substr($filename, $filename_len + 1);
$found = false;

switch ($type) {
	case "jpg":
	case "jpeg":
	case "gif":
	case "png":
		$found = true;
        break;
    default: 
        $found = false;
}

if ($found != true || $filename_len != 23) {
    $rdata = ['result' => -1, 'error' => '파일 오류'];
} else {
    // 원본 파일 이름: $_POST["origname"]
    $savefile = SAVE_DIR . '/' . $filename;

    move_uploaded_file($tempfile, $savefile);
    $imgsize = getimagesize($savefile);
    $filesize = filesize($savefile);

    if (!$imgsize) {
        $filesize = 0;
        unlink($savefile);
        $rdata = ['result' => -1, 'error' => '파일 오류'];
    } else {
        $rdata = [
            'fileUrl'  => sprintf("%s/%s", SAVE_URL, $filename),
            'filePath' => $savefile,
            'fileName' => $filename,
            'fileSize' => $filesize ];
    }
}

header('Content-type: application/json');
echo json_encode($rdata);

?>
