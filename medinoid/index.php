<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8" />
    <title>drop file on orange</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" type="text/css">
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <style>
    	.row{
			margin-left:unset;
			margin-right:unset;
		}
		.title{
			float: left;
		    margin-top: 17px;
		    margin-left: 20px;
		    font-size: 20pt;
		}
		.section1{
			border:1px solid #dddddd; 
			border-left:none; 
			border-right:none;
		}
		.section1_desc{
			font-size:40px;
			font-weight:bold;
			text-align:center;
			margin-top:60px;
			margin-bottom:60px;
		}

		div#text {
			text-align: center;
		    border: 1px dotted #dddddd;
		    height: 100%;
		    min-height: 300px;
		    line-height:300px;
		}
        #dropFiles, #result_eye_example_img{
        	border: 1px dotted rgba(0, 0, 0, 0.3);
        	width:100%;
        	height:100%;
        	min-height:300px;
        	line-height:300px;
            text-align:center;
        }
        .default_desc{
        	font-size:17px;
    	}
    </style>
</head>
<body>
	<div class="container">
		<div class="row" style="height:50px;">
		  <span class="title">MEDINOID: First project</span>
		</div>
		<br />
		<div class="row section1">
			<div class="col-lg-5 col-sm-12">
				<img src="./eyes.jpg" style="max-width:100%" />
			</div>
			<div class="col-lg-7 col-sm-12 section1_desc">
				Computer-Aided<br />
				Glaucoma Diagnosis<br /> 
			</div>
		</div>
		<br />
		<div class="row" >
			<div class="col-lg-9 col-sm-12" id="default_desc">
				We are researching on deep learning techniques in medical or healthcare domain to help diagnose or enhance your well-being lives. This web page is publicly accessible, we do not charge you to use this web application. <br />
				<br />
				This tool is only for the non-commercial use. Blah blah~<br />
				<br />
				For the research collaboration or any questions please contact me to mijung.kim{at}ugent.be.<br />
				<br />
				<br />
				To see the result whether there is glaucomatous symptom in a fundus image, place the image file on the right side. <br />
				<br />
				It will take about 1~3 minutes to present the result on the screen depending on the connection.<br />
				<br />
				** Note: this is a glaucoma diagnosis simulation tool based on the deep learning techniques. Therefore, it is not proper to diagnosis the disease solely upon the result.<br />
				<br />
			</div>

			<div class="col-lg-6 col-sm-12" id="result_desc" style="display:none;">
			</div>

			<div class="col-lg-3 com-sm-12" style="display:none;" id="result_eye_example_img_parent">
				<div id="result_eye_example_img"></div>
			</div>

			<div class="col-lg-3 col-sm-12">
				<div id="dropFiles">Drag a file here or click to upload</div>
			</div>

		</div>
		<br />
	</div>
</body>
<script>
	var resunt = null;

	var requestComplete = function(){
    	if(result.result==1){
    		// display none
    		$('#default_desc').css('display', 'none');

    		// result display write
    		var result_desc  = 'The fundus image is suspected to be glaucomatous.<br />';
    			result_desc += 'With confidence of :<b> '+result.data.percent+' %</b><br /><br />';
    			result_desc += 'Please refer to the region highlighted for the suspected glaucomatous area.';
    			result_desc += 'There is no glaucomatous symptom based on the tool, however it is not reliable to diagnose medically.';
    		$('#result_desc').html(result_desc);
    		$('#result_desc').css('display', 'inline-block');

    		var result_img = '<img src="'+result.data.imgUrl+'" style="width:100%;height:100%;" >';
    		$('#dropFiles').html(result_img);
    		var result_eye_example_img = '<img src="./eyes_result.jpg" style="width:100%;height:100%" >';
    		$('#result_eye_example_img').html(result_eye_example_img);
    		$('#result_eye_example_img_parent').css('display', 'inline-block');
    	}else{
    		var result_desc  = '에러 발생 다시 시도해 주십시오.';
    		$('#result_desc').html(result_desc);
    	}
    }

    $(function(){
        $("#dropFiles").on("drop",drop);
        $("#dropFiles").on("dragover", dragover);
        function dragover(e) {
            e.originalEvent.dataTransfer.dropEffect = 'copy'
            e.preventDefault()
            return false
        }

        function drop(e) {
            e.preventDefault()
            var dataTransfer = e.originalEvent.dataTransfer,
                fd = new FormData()
            if (dataTransfer.files && dataTransfer.files.length){
                $.each(dataTransfer.files,function(i,v) {
                    fd.append("file",v,v.name)
                })
                fd.append("url","drop")
                upload(fd);
            }
        }

        function upload(fd){
        	console.log(fd);
            return $.ajax({
				// 아래 url은 업로프 파일 경로
                url:"./upload.php",
                type:"POST",
                processData:false,
                contentType: false,
                data:fd,
                success:function(data){ 
                	result = JSON.parse(data);
                	console.log("Uploaded.",data);  
                	requestComplete();
                },
                error:function(){ 
                	console.log("Error Uploading.",arguments); 
            	},
            })
        }

    });

</script>
</html>