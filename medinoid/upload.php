<?php
	// $resultArray = json_encode($_FILES);
	// echo $resultArray;

	// $fileExt = getExt($_FILES['file']['name']); // 파일 확장자
	// $fileName = $_FILES['file'];
	// 저장할 이미지 파일경로를 슈퍼도메인 아래 다음경로로 설정합니다.
	$target_path = $_SERVER['DOCUMENT_ROOT']."/medinoid/";
	$fileName = $_FILES['file']['name'];

	$target_path = $target_path.$fileName;
	// 아래는 기존파일 삭제
	unlink($target_path);

	if(move_uploaded_file($_FILES['file']['tmp_name'], $target_path)){
		// 서버측 주소로 이미지 파일업로드 경로
		$imgUrl = "http://any78382.cafe24.com/medinoid/".$fileName;
		$percent = 10;
		$result = array(
			'imgUrl'=>$imgUrl,
			'percent'=>$percent,
		);
		$returnValue = array(
			"result"=>1, 
			"msg"=>"upload success", 
			"data"=>$result
		);
	}else{
		$returnValue = array(
			"result"=>0, 
			"msg"=>"upload error", 
			"data"=>''
		);
	}

	$resultArray = json_encode($returnValue);
	echo $resultArray;
?>