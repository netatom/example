var myeditor = new cheditor();
myeditor.config.editorHeight = '200px';             // 에디터 세로폭입니다.
myeditor.config.editorWidth = '98%';                // 에디터 가로폭입니다.
myeditor.inputForm = 'fm_post';

function getImages ()
{
  var img = myeditor.getImages();

  if (img) {
    var txt = '';
    for (var i=0; i < img.length; i++) {
        txt += '사진 URL: '    + img[i]['fileUrl'] + '\n' +
               '저장 파일: ' + img[i]['fileName'] + '\n' +
               '저장 경로: ' + '노출 제한\n' +
               '원본 파일: ' + img[i]['origName'] + '\n' +
               '사진 크기: ' + img[i]['width'] + ' X ' + img[i]['height'] + '\n' +
               '파일 크기: '   + img[i]['fileSize'] + '\n'
    }

    alert(txt);
  }
  else {
     alert('첨부한 사진이 없습니다.');
  }

  myeditor.returnFalse();
}
function getHtmlContent ()
{
    alert(myeditor.outputHTML());
    myeditor.returnFalse();
}

function getBodyContent ()
{
    alert(myeditor.outputBodyHTML());
    myeditor.returnFalse();
}

function getTextContent ()
{
    alert(myeditor.outputBodyText());
    myeditor.returnFalse();
}

function getContentLength ()
{
    alert(myeditor.inputLength());
}

<!-- 전체 문서 길이입니다. -->
function getDocumentLength ()
{
    alert(myeditor.contentsLengthAll());
}