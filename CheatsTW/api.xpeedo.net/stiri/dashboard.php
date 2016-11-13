<!DOCTYPE html>
<head><title>Dashboard</title></head>
<?php
session_start();
$container = '<html>

<head>
<title>Dashboard Stiri</title>
</head>

<body style="text-align:center;" align="center">
<h1>Stiri</h1>
<p>Aici poti Adauga / Modifica / Sterge Stiri pentru clienti</p>
<form method="post" action="/stiri/dashboard.php">
<textarea name="stire" rows="10" style="width:25%;text-align:center;resize:none;" placeholder="Aici poti adauga doar o stire..."></textarea><p></p>
<select name="autori">
<option value="Unknown - Creatorul Codului">Unknown - Creatorul Codului</option>
<option value="GooD - Creator Metoda">GooD - Creator Metoda</option>
<option value="MrReacher - Certified Support">MrReacher - Certified Support</option>
<option value="qAnti - Moderator">qAnti - Moderator</option>
</select>
<input type="submit" name="adauga" value="Adauga"><br>
<p>Alte optiuni:</p>
<input type="submit" name="sterge" value="Sterge">
<br></br>
<input type="submit" name="logout" value="Logout">
</form>
<p>Acest serviciu este gazduit de api.xpeedo.net</p>
</body>

</html>';

if(empty($_POST['username']) && empty($_POST['password']) or $_POST['username'] !== 'Administrator' && $_POST['password'] !== 'pa$$worD' or $_POST['username'] !== 'Administrator' or $_POST['password'] !== 'pa$$worD') {
	if(!empty($_SESSION['username']) && !empty($_SESSION['password'])){
	echo $container;
	} else {
	session_unset();
	Header('Location: /stiri');
	die();
	}
} elseif(isset($_POST['username']) && isset($_POST['password'])) {
	$_SESSION['username'] = 'Administrator';
	$_SESSION['password'] = 'pa$$worD';
	$user = $_POST['username'];
	$pass = $_POST['password'];
	$suser = $_SESSION['username'];
	$spass = $_SESSION['password'];
		if($user === $suser && $pass === $spass) {
			Header('Location: /stiri');
			die();
		} else {
			Header('Location: /stiri');
			die();
		}
} else {
	Header('Location: /stiri');
	die();
}
?>

<?php
if(isset($_POST['stire']) && isset($_POST['autori']) && isset($_POST['adauga'])) {
$stire = $_POST['stire'];
$autor = $_POST['autori'];
$adauga = $_POST['adauga'];

date_default_timezone_set("Europe/Bucharest"); // ROMANIA GMT
$file = '../stire.txt';
$oldContents = file_get_contents($file);
$fr = fopen($file, 'w');
fwrite($fr, "Data: ".date("d.m.Y H:i:s")."\n".$stire."\nAutor: ".$autor."\n\n");
fwrite($fr, $oldContents);
fclose($fr);

echo '<p>Stirea ta: '.$stire.'</p>';
echo '<p>Autor: '.$autor.'</p>';
Header('Location: /stiri/dashboard.php');
} elseif(isset($_POST['sterge'])) {
file_put_contents("../stire.txt", "");
echo "Stirile au fost sterse!";
Header('Location: /stiri/dashboard.php');
} elseif(isset($_POST['logout'])) {
	session_unset();
	Header('Location: /stiri');
	die();
}
?>