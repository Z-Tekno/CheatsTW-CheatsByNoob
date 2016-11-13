<?php
If(isset($_GET['key'])) {

$key = $_GET['key'];

$servername = 'localhost';
$username = 'user_name';
$password = 'pass_word123';
$dbname = 'user_name';

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT user FROM cheatstw WHERE cd_key='".$key."'";
$query = mysqli_query($conn, $sql);
$row = mysqli_fetch_array($query);

if($key == null or preg_match("/'/",$key) or preg_match('/"/',$key) or strlen($key) > 16 or strlen($key) < 0 or ctype_space($key)) {
	echo 'API_CALL_FAILED';
	
	} elseif((mysqli_num_rows($query) > 0)) {
		echo $row['user'];
	} else {
		echo 'API_CALL_FAILED';
	}
	
	$conn->close();
}
?>