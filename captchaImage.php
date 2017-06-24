<?php 
session_start(); 
// $t1 = chr(rand(65,90));
// $t2 = rand(10,99);
// $t3 = rand(10,99);
// $t4 = chr(rand(97,122));
$t1 = rand(10,99);
$t2 = rand(10,99);
$t3 = rand(10,99);
//$t4 = rand(0,9);
$text = "$t1"."$t2"."$t3";//."$t4";//rand(10000, 99999);
$_SESSION["vercode"] = $text; 
$height = 22; 
$width = 65; 
  
$image_p = imagecreate($width, $height); 
$black = imagecolorallocate($image_p, 0, 0, 0); 
$white = imagecolorallocate($image_p, 255, 255, 255); 
$font_size = 14; 
  
imagestring($image_p, $font_size, 5, 3, $text, $white); 
imagejpeg($image_p, null, 80); 
?>