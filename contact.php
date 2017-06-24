<?php 
session_start();
if ($_POST["name"] <> '' AND $_POST["phone"] <> '' AND $_POST["message"] <> '' AND $_POST["email"] <> '' AND $_SESSION["vercode"] <> '' AND $_POST["vercode"] == $_SESSION["vercode"]) { 
    
	  $MESSAGE_BODY = "Name: ".$_POST["name"]."\r\n"."<br/>Email: ".$_POST["email"]."\r\n"."<br/>Phone: ".$_POST["phone"]."\r\n"."<br/>Comment: ".nl2br($_POST["message"])."";
    $MESSAGE_BODY_PLAIN = "Name: ".$_POST["name"]."\r\n"."Email: ".$_POST["email"]."\r\n"."Phone: ".$_POST["phone"]."\r\n"."Comment: ".nl2br($_POST["message"])."";
	  //$MESSAGE_BODY .= "Email: ".$_POST["email"]."\r\n"; 
	  //$MESSAGE_BODY .= "Comment: ".nl2br($_POST["comment"]).""; 

	  include("class.phpmailer.php");
	  $mail = new PHPMailer(); 
	  $mail->SMTPSecure = "ssl";                 // sets the prefix to the servier
	  $mail->Host       = "smtp.mail.yahoo.com";      // sets GMAIL as the SMTP server
	  $mail->Port       = 465;                   // set the SMTP port for the GMAIL server
	  $mail->IsSMTP(); // send via SMTP

	  //IsSMTP(); // send via SMTP
	  $mail->SMTPAuth = true; // turn on SMTP authentication
	  $mail->Username = "manavaikhanasam"; // SMTP username
	  $mail->Password = "kumar1987"; // SMTP password
	  $webmaster_email = "manavaikhanasam@yahoo.com"; //Reply to this email ID
	  $email="seshu.manavaikhanasam@gmail.com"; // Recipients email ID
	  $name="Seshu"; // Recipient's name
	  $mail->From = $webmaster_email;
	  $mail->FromName = "ManaVaikhanasam";
	  $mail->AddAddress($email,$name);
	  $mail->AddReplyTo($webmaster_email,"ManaVaikhanasam");
	  $mail->WordWrap = 50; // set word wrap
	  $mail->IsHTML(true); // send as HTML
	  $mail->Subject = "Web Site - ManaVaikhanasam";
	  $mail->Body = $MESSAGE_BODY; //HTML Body
	  $mail->AltBody = $MESSAGE_BODY_PLAIN; //Text Body
	  if(!$mail->Send())
	  {
	  	echo "Mailer Error: " . $mail->ErrorInfo;
	  }
	  else
	  {
	  	echo "Success"; 
	  }	
	?>
<?php 
}else{
	if($_POST["name"] == ''){
		echo "Please Provide Your Name";
	}else if($_POST["phone"] == ''){
		echo "Please Provide Your Phone Number";
	}else if($_POST["email"] == ''){
		echo "Please Provide Your Email Address";
	}else if($_POST["message"] == ''){
		echo "Please Provide Your Message";
	}else if($_POST["vercode"] == ''){
		echo "Please Enter Captcha Code";
	}else if($_POST["vercode"] == $_SESSION["vercode"]){
		echo "Entered Captcha Is Incorrect";
	}else{
		echo "";
	}
} 
?>

