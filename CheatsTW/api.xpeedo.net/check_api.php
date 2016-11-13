<?php
If(isset($_GET['key']) && isset($_GET['set']) && isset($_GET['hash']) && isset($_GET['userpc']) && isset($_GET['version'])) {
$key = $_GET['key'];
$set = $_GET['set'];
$hash = $_GET['hash'];
$ip = $_SERVER["REMOTE_ADDR"];

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

$something = "SELECT cd_key FROM cheatstw WHERE cd_key='".$key."'";
$query = mysqli_query($conn, $something);
$jmek = "SELECT user,use_key,ip,hash FROM cheatstw WHERE cd_key='".$key."'";
$result = mysqli_query($conn, $jmek);
$row = mysqli_fetch_array($result);

$ban = "SELECT blocked,ip FROM cheatstw WHERE cd_key='".$key."'";
$somer = mysqli_query($conn, $ban);
$raw = mysqli_fetch_array($somer);

if($key == null && $set == null && $hash == null && $userpc == null && $version == null or preg_match("/'/",$key) && preg_match("/'/",$set) && preg_match("/'/",$hash) && preg_match("/'/",$userpc) && preg_match("/'/",$version) or preg_match('/"/',$key) && preg_match('/"/',$set) && preg_match('/"/',$hash) && preg_match('/"/',$userpc) && preg_match('/"/',$version) or strlen($key) > 16 && strlen($set) > 1 && strlen($hash) > 64 && strlen($userpc) > 1000 && strlen($version) > 4 or strlen($key) < 0 && strlen($set) < 0 && strlen($hash) < 64 && strlen($userpc) < 0 && strlen($version) < 4 or ctype_space($key) && ctype_space($set) && ctype_space($hash) && ctype_space($userpc) && ctype_space($version)) {
    echo 0;
} elseif((mysqli_num_rows($query) > 0) && $set == 0) {

$iuz = "UPDATE cheatstw SET use_key='1',ip='$ip',hash='$hash',userpc='$userpc',version='$version' WHERE cd_key='".$key."'";
$iuzz = "UPDATE cheatstw SET blocked='1' WHERE cd_key='".$key."'";

if(!empty($row['hash']) && $row['hash'] !== $hash && $conn->query($iuzz) === TRUE) {
echo "Key banat";
} elseif($raw['blocked'] == 1) {
echo "Key banat";
} elseif ($row['use_key'] == 1) {
    echo "Cheia este deja folosita de cineva";
} elseif($conn->query($iuz) === TRUE) {
    echo "Cheia a fost folosita cu succes";
} else {
    echo "Error updating record: " . $conn->error;
}

} elseif((mysqli_num_rows($query) > 0) && $set == 1) {

$iut = "UPDATE cheatstw SET use_key='0',ip='$ip',hash='$hash',userpc='$userpc',version='$version' WHERE cd_key='".$key."'";
$iutt = "UPDATE cheatstw SET blocked='1' WHERE cd_key='".$key."'";

if(!empty($row['hash']) && $row['hash'] !== $hash && $conn->query($iutt) === TRUE) {
echo "Key banat";
} elseif($raw['blocked'] == 1) {
echo "Key banat";
} elseif ($row['use_key'] == 0) {
    echo "Aceasta cheie este libera";
} elseif($conn->query($iut) === TRUE) {
    echo "Acum nu mai folosesti aceasta cheie";
} else {
    echo "Error updating record: " . $conn->error;
}

} else {
    echo 0;
}

$conn->close();
}
?>