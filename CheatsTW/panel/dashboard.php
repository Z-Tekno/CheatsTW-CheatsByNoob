<?php
// SESSION LOGIN MADE BY XPEEDO FOR CHEATSTW.COM
session_start();

//SQL
if(isset($_SESSION['cheatskey'])) {
$servernamea = 'sub.domain.com';
$usernamea = 'user_name';
$passworda = 'pass_word123';
$dbnamea = 'user_name';

// Create connection
$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
// Check connection
if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$query = "SELECT cd_key FROM cheatstw WHERE cd_key='".$_SESSION['cheatskey']."'";
$result = mysqli_query($conna, $query);
$row = $result->fetch_assoc();
}
//SQL

if(isset($_SESSION['cheatskey']) && $_SESSION['cheatskey'] == $row['cd_key'] && isset($_SESSION['submitkey']) && $_SESSION['submitkey'] == 'Insert') {
	$conna->close();
	header('Location: /panel/user.php');
	die();
} elseif(empty($_POST['cheats']) && empty($_POST['tw']) or $_POST['cheats'] !== 'Administrator' && $_POST['tw'] !== 'pa$$worD' or $_POST['cheats'] !== 'Administrator' or $_POST['tw'] !== 'pa$$worD') {
	if(!empty($_SESSION['cheats']) && !empty($_SESSION['tw'])){
	// PUT YOUR HTML CODE BELOW
	} else {
	session_unset();
	Header('Location: /panel');
	die();
	}
} elseif(isset($_POST['cheats']) && isset($_POST['tw'])) {
	$_SESSION['cheats'] = 'Administrator';
	$_SESSION['tw'] = 'pa$$worD';
	$user = $_POST['cheats'];
	$pass = $_POST['tw'];
	$suser = $_SESSION['cheats'];
	$spass = $_SESSION['tw'];
		if($user === $suser && $pass === $spass) {
			Header('Location: /panel');
			die();
		} else {
			Header('Location: /panel');
			die();
		}
} else {
	Header('Location: /panel');
	die();
}
?>

<html>
<head>
<link rel="icon" type="image/png" href="favicon.png" sizes="128x128">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
<meta charset="UTF-8">
<title>CheatsTW*</title>
</head>
<body style="text-align: center;">
<div>
<p>Salut slabanule, daca nu stii ce sa faci da click mai jos:</p>
<form action="/panel/dashboard.php" method="POST">
<input type="submit" name="logout" value="Logout">
</form>
</div>
<br>
<h1>Adauga cheie</h1>
<form method="POST" action="/panel/dashboard.php">
<input placeholder="user" maxlength="20" size="20" name="user" type="text">
<input placeholder="email" size="20" name="email" type="text">
<input hidden id="randomkey" placeholder="key" maxlength="16"size="16" name="key" type="text">
<input type="submit" value="Adauga">
</form>

<h1>Sterge cheie</h1>
<form method="POST" action="/panel/dashboard.php">
<input placeholder="user" maxlength="20" size="20" name="userdel" type="text">
<input type="submit" value="Sterge">
</form>

<h1>Baneaza / Debaneaza cheie</h1>
<form method="POST" action="/panel/dashboard.php">
<input placeholder="user" maxlength="20" size="20" name="bankey" type="text">
<select name="switch">
    <option value="1">Baneaza</option>
    <option value="0">Debaneaza</option>
</select>
<input type="submit" value="Accept">
</form>

<form method="POST" action="/panel/dashboard.php">
<input type="submit" name="unbanall" value="Debaneaza toate key-urile">
</form>

<h1>Deblocheaza key cu status = 1</h1>
<form method="POST" action="/panel/dashboard.php">
<input placeholder="user" maxlength="20" size="20" name="status" type="text">
<input type="submit" value="Set status to 0">
</form>

<form method="POST" action="/panel/dashboard.php">
<input type="submit" name="allto0" value="Set status to all to 0">
</form>

<h1>Scoate restrictia la download</h1>
<form method="POST" action="/panel/dashboard.php">
<input placeholder="user" maxlength="20" size="20" name="download" type="text">
<input type="submit" value="Accept">
</form>

<form method="POST" action="/panel/dashboard.php">
<input type="submit" name="downloadall" value="Set download to all to 0">
</form>

<form method="POST" action="/panel/dashboard.php">
<input type="submit" name="blockdownloadall" value="Block all downloads">
</form>

<h1>Change Key</h1>
<form method="POST" action="/panel/dashboard.php">
<input placeholder="user" maxlength="20" size="20" name="userkeychange" type="text">
<input hidden id="changekey" placeholder="key" maxlength="16"size="16" name="keychange" type="text">
<input type="submit" value="Change It">
</form>

<script>
window.onload = makeid()
window.onload = changekey()
function makeid()
{
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for( var i=0; i < 16; i++ )
        text += possible.charAt(Math.floor(Math.random() * possible.length));
document.getElementById("randomkey").value = text;
}
function changekey()
{
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for( var i=0; i < 16; i++ )
        text += possible.charAt(Math.floor(Math.random() * possible.length));
document.getElementById("changekey").value = text;
}
</script>

<?php
If(isset($_POST['user']) && isset($_POST['email']) && isset($_POST['key'])) {
$user = $_POST['user'];
$email = $_POST['email'];
$key = $_POST['key'];

$servername = 'sub.domain.com';
$username = 'user_name';
$password = 'pass_word123';
$dbname = 'user_name';

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

    $sql = "INSERT INTO cheatstw (user, cd_key, email)
    VALUES ('$user', '$key', '$email')";

If($user == null or preg_match("/'/",$user) or preg_match('/"/',$user) or strlen($user) > 20 or strlen($user) < 4 or ctype_space($user)) {
    echo "Nu am putut adauga key-ul respectiv!";
    header("Location: /panel");
    die();
} elseif($key == null or preg_match("/'/",$key) or preg_match('/"/',$key) or strlen($key) > 20 or strlen($key) < 0 or ctype_space($key)) {
    echo "Nu am putut adauga key-ul respectiv!";
    header("Location: /panel");
    die();
} elseif($email == null or preg_match("/'/",$email) or preg_match('/"/',$email) or strlen($email) < 0 or ctype_space($email)) {
    echo "Nu am putut adauga key-ul respectiv!";
    header("Location: /panel");
    die();
} elseif($conn->query($sql) === TRUE) {
    echo "Key adaugat cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}
$conn->close();
} elseif(isset($_POST['userdel'])) {
$user = $_POST['userdel'];

$servernamea = 'sub.domain.com';
$usernamea = 'user_name';
$passworda = 'pass_word123';
$dbnamea = 'user_name';

// Create connection
$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
// Check connection
if ($conna->connect_error) {
    die("Connection failed: " . $conna->connect_error);
}

$sqla = "DELETE FROM cheatstw WHERE user = '".$user."'";

if($user == null or preg_match("/'/",$user) or preg_match('/"/',$user) or strlen($user) > 20 or strlen($user) < 4 or ctype_space($user)) {
    echo "Nu am putut sterge user-ul respectiv!";
    header("Location: /panel");
    die();
} elseif ($conna->query($sqla) === TRUE) {
    echo "User-ul a fost sters cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
$conna->close();
} elseif (isset($_POST['bankey']) && isset($_POST['switch'])) {

$user = $_POST['bankey'];
$switch = $_POST['switch'];

$servernamea = 'sub.domain.com';
$usernamea = 'user_name';
$passworda = 'pass_word123';
$dbnamea = 'user_name';

// Create connection
$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
// Check connection
if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sqla = "UPDATE cheatstw SET blocked = '".$switch."',ip=NULL,hash=NULL,use_key=0,userpc=NULL WHERE user = '".$user."'";

if($user == null or preg_match("/'/",$user) or preg_match('/"/',$user) or strlen($user) > 20 or strlen($user) < 4 or ctype_space($user)) {
    echo "Nu am putut sterge user-ul respectiv!";
    header("Location: /panel");
    die();
} elseif ($conna->query($sqla) === TRUE) {
    echo "User-ul a fost sters cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
$conna->close();

} elseif(isset($_POST['unbanall'])) {
	
	$all = $_POST['unbanall'];
	
	$servernamea = 'sub.domain.com';
	$usernamea = 'user_name';
	$passworda = 'pass_word123';
	$dbnamea = 'user_name';

	// Create connection
	$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
	// Check connection
	if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
	}
	
	$sqla = "UPDATE cheatstw SET blocked=0 WHERE blocked=1";
	
	if ($conna->query($sqla) === TRUE) {
    echo "Toate key-urile au fost debanate cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
	
	$conna->close();
} elseif(isset($_POST['status'])) {
	
	$status = $_POST['status'];
	
	$servernamea = 'sub.domain.com';
	$usernamea = 'user_name';
	$passworda = 'pass_word123';
	$dbnamea = 'user_name';

// Create connection
$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
// Check connection
if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
	
	$sqla = "UPDATE cheatstw SET use_key=0 WHERE user='".$status."'";
	
	if($status == null or preg_match("/'/",$status) or preg_match('/"/',$status) or strlen($status) > 20 or strlen($status) < 4 or ctype_space($status)) {
    echo "Nu am putut sterge user-ul respectiv!";
    header("Location: /panel");
    die();
} elseif ($conna->query($sqla) === TRUE) {
    echo "User-ul are keyu setat pe 0 acum!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
	
$conna->close();	
} elseif(isset($_POST['allto0'])) {
	
	$all = $_POST['allto0'];
	
	$servernamea = 'sub.domain.com';
	$usernamea = 'user_name';
	$passworda = 'pass_word123';
	$dbnamea = 'user_name';

	// Create connection
	$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
	// Check connection
	if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
	}
	
	$sqla = "UPDATE cheatstw SET use_key=0 WHERE use_key=1";
	
	if ($conna->query($sqla) === TRUE) {
    echo "Toate key-urile au fost debanate cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
	
	$conna->close();
} elseif(isset($_POST['download'])) {
	
	$download = $_POST['download'];
	
	$servernamea = 'sub.domain.com';
	$usernamea = 'user_name';
	$passworda = 'pass_word123';
	$dbnamea = 'user_name';

// Create connection
$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
// Check connection
if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

	$sqla = "UPDATE cheatstw SET download=0 WHERE user='".$download."'";
	
	if($download == null or preg_match("/'/",$download) or preg_match('/"/',$download) or strlen($download) > 20 or strlen($download) < 4 or ctype_space($download)) {
    echo "Eroare!";
    header("Location: /panel");
    die();
} elseif ($conna->query($sqla) === TRUE) {
    echo "User-ul poate descarca codul iar!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
	
$conna->close();	
} elseif(isset($_POST['downloadall'])) {
	
	$all = $_POST['downloadall'];
	
	$servernamea = 'sub.domain.com';
	$usernamea = 'user_name';
	$passworda = 'pass_word123';
	$dbnamea = 'user_name';

	// Create connection
	$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
	// Check connection
	if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
	}
	
	$sqla = "UPDATE cheatstw SET download=0 WHERE download=1";
	
	if ($conna->query($sqla) === TRUE) {
    echo "Toate downloadurile au fost resetate cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
	
	$conna->close();
	
} elseif(isset($_POST['blockdownloadall'])) {
	
	$all = $_POST['blockdownloadall'];
	
	$servernamea = 'sub.domain.com';
	$usernamea = 'user_name';
	$passworda = 'pass_word123';
	$dbnamea = 'user_name';

	// Create connection
	$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
	// Check connection
	if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
	}
	
	$sqla = "UPDATE cheatstw SET download=1 WHERE download=0";
	
	if ($conna->query($sqla) === TRUE) {
    echo "Toate downloadurile au fost blocate cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}
	
	$conna->close();
} elseif(isset($_POST['userkeychange']) && isset($_POST['keychange']) ) {
	$userkeychange = $_POST['userkeychange'];
	$keychange = $_POST['keychange'];
	
	$servernamea = 'sub.domain.com';
	$usernamea = 'user_name';
	$passworda = 'pass_word123';
	$dbnamea = 'user_name';
	
	// Create connection
	$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
	// Check connection
	if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
	}
	
	$sqla = "UPDATE cheatstw SET cd_key='$keychange' WHERE user='$userkeychange'";
	
	if($userkeychange == null && $keychange == null or preg_match("/'/",$userkeychange) && preg_match("/'/",$keychange) or preg_match('/"/',$userkeychange) && preg_match('/"/',$keychange) or strlen($userkeychange) > 20 && strlen($keychange) > 16 or strlen($userkeychange) < 4 && strlen($keychange) < 16 or ctype_space($userkeychange) && ctype_space($keychange)) {
	echo "Eroare!";
    header("Location: /panel");
    die();
	} elseif ($conna->query($sqla) === TRUE) {
    echo "Ai schimbat key-ul utilizatorului cu succes!";
    header("Location: /panel");
    die();
} else {
    echo "Error: " . $sqla . "<br>" . $conn->error;
    header("Location: /panel");
    die();
}

$conna->close();

} if(isset($_POST['logout'])) {
	session_unset();
	Header('Location: /panel');
	die();
}
?>

<h2 style="text-align: center;">Cumparatori:</h2>
<?php

$servernamea = 'sub.domain.com';
$usernamea = 'user_name';
$passworda = 'pass_word123';
$dbnamea = 'user_name';

// Create connection
$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
// Check connection
if ($conna->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT * FROM cheatstw";
$result = mysqli_query($conna, $sql);

if ($result->num_rows > 0) {

echo '<style>
table, th, td {
	cursor: default;
    border: 1px solid black;
    table-layout: fixed
}
th, td {
    padding: 5px;
    text-align: center;    
}
th {
background: black;
color: white;
}
</style>';

echo '<table id="table1" style="width:100%">';
echo '<tr><th>User</th><th>User PC</th><th>Versiune</th><th>Key</th><th>Status</th><th>Email</th><th>Hash</th><th>Key Blocat</th><th>Last IP</th><th>Logs</th><th>Download</th></tr>';    
// output data of each row
while($row = $result->fetch_assoc()) {
echo '<tr><td>'.$row["user"].'</td><td>'; if($row['userpc'] == NULL) { echo 'NO PC DETECTED'; } else { echo $row['userpc']; } echo '</td><td>'; if($row['version'] == NULL) { echo 'NOT INSTALLED';} else { echo 'v'.$row['version']; } echo '</td><td><button class="key'.$row['cd_key'].'">Afiseaza Key</button><span hidden class="showkey'.$row['cd_key'].'">'.$row["cd_key"].'</span></td><td>'; if($row["use_key"] == 0) { echo '<span style="color:red;">Dezactivat</span>'; } else { echo '<span style="color:green;">Activat</span>'; } echo '</td><td><button class="email'.$row['cd_key'].'">Afiseaza Email</button><span hidden class="showemail'.$row['cd_key'].'">'.$row["email"].'</span></td><td>'; if($row["hash"] == NULL) { echo '<span style="font-size:12px;">NO HASH</span>'; } else { echo '<button class="hash'.$row['cd_key'].'">Afiseaza Hash</button><span hidden class="showhash'.$row['cd_key'].'" style="font-size:5px;">'.$row["hash"].'</span>'; } echo '</td><td>'; if($row["blocked"] == 0) { echo '<span style="color:green;">Key Activ</span>'; } else { echo '<span style="color:red;">Key Banat</span>'; } echo '</td><td>'; if($row["ip"] !== NULL) { echo '<button class="ip'.$row['cd_key'].'">Afiseaza IP</button><span class="showip'.$row['cd_key'].'" hidden style="font-size:12px;"><a href="http://'.$row["ip"].'.ipaddress.com" target="_blank">'.$row["ip"].'</a></span>'; } else { echo '<span>NO IP</span>'; } echo '</td><td><a href="http://api.xpeedo.net/'.$row["user"].'_loguri_ip_api.txt" target="_blank">Click aici</a></td><td>'; if($row["download"] == 1) { echo '<span style="color:red;">Indisponibil</span>'; } else { echo '<span style="color:green;">Disponibil</span>'; } echo '</td></tr>';
echo '
<script>
$( ".key'.$row['cd_key'].'" ).click(function() {
$( ".showkey'.$row['cd_key'].'" ).show()
$(this).hide()
});
</script>

<script>
$( ".email'.$row['cd_key'].'" ).click(function() {
$( ".showemail'.$row['cd_key'].'" ).show()
$(this).hide()
});
</script>

<script>
$( ".hash'.$row['cd_key'].'" ).click(function() {
$( ".showhash'.$row['cd_key'].'" ).show()
$(this).hide()
});
</script>

<script>
$( ".ip'.$row['cd_key'].'" ).click(function() {
$( ".showip'.$row['cd_key'].'" ).show()
$(this).hide()
});
</script>';
}
echo '</table>';
echo '<br>';
echo "Total cumparatori: <span id='tableget'>0</span>";
$conna->close();
}
?>
 <script type="text/javascript">
    window.onload = CountRows()
function CountRows() {
        var totalRowCount = 0;
        var rowCount = 0;
        var table = document.getElementById("table1");
        var rows = table.getElementsByTagName("tr")
        for (var i = 0; i < rows.length; i++) {
            totalRowCount++;
            if (rows[i].getElementsByTagName("td").length > 0) {
                rowCount++;
            }
        }
document.getElementById("tableget").innerHTML = rowCount;
    }
</script>
<br></br>
<h3>Utile:</h3>
<p><a href="http://api.xpeedo.net/fail_login_api.txt" target="_blank">Log-uri key-uri gresite</a></p>
<p><a href="http://api.xpeedo.net/stiri" target="_blank">Adauga / Modifica / Sterge Stiri</a></p>
<br>
<p>Status protectie contra admini: <?php /*readfile("http://128.199.125.61/ddos/?ip=PROTECTIE_STABILA!")*/echo 'NEPROTEJAT CONTRA ADMINILOR'; ?></p>
<h3>Stiri</h3>
<textarea rows="20" readonly style="resize: none; width: 100%; text-align: center; cursor: default;">
<?php
readfile('http://sub.domain.com/stire.txt');
?>
</textarea>
<h3>Log-uri admini</h3>
<textarea rows="10" readonly style="resize: none; width: 100%; text-align: center; cursor: default;">
<?php
readfile('https://cheatstw.com/bruteforcedownloadbyadminsamoarabibi.txt')
?>
</textarea>
</body>
</html>