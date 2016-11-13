<?php
// SESSION LOGIN MADE BY XPEEDO FOR CHEATSTW.COM
session_start();

//SQL
if(isset($_POST['cheatskey'])) {
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
$keie = mysqli_real_escape_string($conna, $_POST['cheatskey']);

$query = "SELECT cd_key FROM cheatstw WHERE cd_key='".$keie."'";
$result = mysqli_query($conna, $query);
$row = $result->fetch_assoc();
$conna->close();
}
//SQL

if(isset($_SESSION['cheats']) && $_SESSION['cheats'] == 'Administrator' && isset($_SESSION['tw']) && $_SESSION['tw'] == 'pa$$worD') {
	header('Location: /panel/dashboard.php');
	die();
} if(empty($_POST['cheatskey']) && empty($_POST['submitkey']) or $_POST['cheatskey'] !== $row['cd_key'] && $_POST['submitkey'] !== 'Insert' or $_POST['cheatskey'] !== $row['cd_key'] or $_POST['submitkey'] !== 'Insert') {
	if(!empty($_SESSION['cheatskey']) && !empty($_SESSION['submitkey'])){
	
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
	$query = "SELECT * FROM cheatstw WHERE cd_key='".$_SESSION['cheatskey']."'";
	$result = mysqli_query($conna, $query);
	$row = $result->fetch_assoc();
	echo '<title>'.$row['user']."'".'s Profile - CheatsTW.com</title>';
	echo '<audio autoplay loop preload="auto" src="/panel/codat_logat.mp3"></audio>';
	$conna->close();
	
	} else {
	session_unset();
	Header('Location: /panel');
	die();
	}
} elseif(isset($_POST['cheatskey']) && isset($_POST['submitkey'])) {
	$_SESSION['cheatskey'] = $row['cd_key'];
	$_SESSION['submitkey'] = 'Insert';
	$user = $_POST['cheatskey'];
	$pass = $_POST['submitkey'];
	$suser = $_SESSION['cheatskey'];
	$spass = $_SESSION['submitkey'];
		if($user === $suser) {
			Header('Location: /panel');
			die();
			} else {
				session_unset();
				Header('Location: /panel');
				die();
				}
}
?>

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
	$query = "UPDATE cheatstw SET use_key = 0 WHERE cd_key='".$_SESSION['cheatskey']."'";
	$sqla = "SELECT * FROM cheatstw";
	$result = mysqli_query($conna, $query);
	$rezult = mysqli_query($conna, $sqla);
	$raw = $rezult->fetch_assoc();
	
	$myip = $_SERVER['REMOTE_ADDR'];

if(isset($_POST['logout'])) {
	session_unset();
	Header('Location: /panel');
	die();
} elseif(isset($_POST['deblock'])) {
	if($raw['blocked'] == 1) {
		session_unset();
		Header('Location: /panel');
		die();		
	}elseif($myip !== $raw['ip']) {
		session_unset();
		Header('Location: /panel');
		die();
	} else {
		if($raw['use_key'] == 0) {
			//NIMIC
		} else {
			if($conna->query($query) === TRUE) {
				session_unset();
				Header('Location: /panel');
				die();
			}
		}
	}
$conna->close();
}
?>

<head>
<link rel="icon" type="image/png" href="favicon.png" sizes="128x128">
<style>
a, a:active, a:focus{
outline: none; 
}
.btn:focus,.btn:active {
outline: none !important;
}
</style>
<script src="https://raw.githubusercontent.com/HubSpot/pace/v1.0.0/pace.min.js"></script>
<link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
<link href="https://fonts.googleapis.com/css?family=Amatic+SC:400,700" rel="stylesheet">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.3/css/font-awesome.min.css">
 <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">

<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
<script src="/scroll.js"></script>

<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</head>
<body style="font-size: 16px; text-align: center; font-family: 'Montserrat', sans-serif; cursor: default; -moz-user-select: none; -webkit-user-select: none; -ms-user-select:none; user-select:none;-o-user-select:none; color: chartreuse; background: url(
<?php
$rand = rand(0,4);
if($rand == 0) {
	echo "https://i.imgur.com/5MxhxOO.jpg";
} elseif($rand == 1) {
	echo "https://i.imgur.com/bU3qJ90.jpg";
} elseif($rand == 2) {
	echo "https://i.imgur.com/RHKLGx6.jpg";
} elseif($rand == 3) {
	echo "https://i.imgur.com/2hiubG6.jpg";
} elseif($rand == 4) {
	echo "https://i.imgur.com/FQzueb8.jpg";
} else {
	// NIMIC
}
?>) no-repeat center center fixed; -webkit-background-size: cover; -moz-background-size: cover; -o-background-size: cover; background-size: cover;">
<script>
$(document).ready(function(){
<?php
if (stripos($_SERVER['HTTP_USER_AGENT'], "firefox")>0) {
echo '$("#fade1").fadeIn("slow");';
echo '$("#fade2").fadeIn(4000);';
} else {
echo '$("#fade1").show("slow");';
echo '$("#fade2").show(4000);';
}
?>
$("[data-toggle='tooltip']").tooltip();
});
</script>
<div id="fade1" style="display:none; position: fixed; top: 0px; width: 100%; height: 100%; background-color: black; filter: alpha(opacity=60); opacity: 0.6;">
</div>
<div id="fade2" style="bottom: 0; left: 0; right: 0; margin: auto; width: 100%; height: 75%; display:none; position: absolute;">
<div class="container">

<?php
$servernamea = 'sub.domain.com';
$usernamea = 'user_name';
$passworda = 'pass_word123';
$dbnamea = 'user_name';
// Create connection
$conna = new mysqli($servernamea, $usernamea, $passworda, $dbnamea);
// Check connection
if ($conna->connect_error) {
//die("Connection failed: " . $conn->connect_error);
die('<h2><i data-toggle="tooltip" data-placement="bottom" title="Error" style="color: yellow;" class="glyphicon glyphicon-alert"></i> Ceva nu miroase a bine, si ala nu e key-ul tau</h2>');
}
$query = "SELECT * FROM cheatstw WHERE cd_key='".$_SESSION['cheatskey']."'";
$result = mysqli_query($conna, $query);
$row = $result->fetch_assoc();

echo '<h1 style="color:chartreuse;"><i data-toggle="tooltip" data-placement="bottom" title="Numele codatului" style="color:mediumseagreen;" class="glyphicon glyphicon-user"></i> '.$row['user'].'</h1>

<h2>';
	if($row['user'] == NULL) {
	session_unset();
	Header('Location: /panel');
	die();
	} elseif($row['user'] == 'Xpeedo') {
		echo '<i data-toggle="tooltip" data-placement="bottom" title="Functia codatului" style="color:orange;" class="glyphicon glyphicon-fire"></i> Creator Cod & Fondator';
	} elseif($row['user'] == 'GooD') {
		echo '<i data-toggle="tooltip" data-placement="bottom" title="Functia codatului" style="color:LightSeaGreen;" class="glyphicon glyphicon-tasks"></i> Creator Metoda & Fondator';
	} elseif($row['user'] == 'Lacatus Mecanic') {
		echo '<i data-toggle="tooltip" data-placement="bottom" title="Functia codatului" style="color:#1C90C9;" class="glyphicon glyphicon-wrench"></i> L&#259;c&#259;tu&#351; Mecanic';
	} elseif($row['user'] == 'MrReacher') {
		echo '<i data-toggle="tooltip" data-placement="bottom" title="Functia codatului" style="color:mediumseagreen;" class="glyphicon glyphicon-tasks"></i> Administrator & Key Manager';
	} elseif($row['user'] == 'qAnti') {
		echo '<i data-toggle="tooltip" data-placement="bottom" title="Functia codatului" style="color:purple;" class="glyphicon glyphicon-sunglasses"></i> Moderator';
	} else {
		echo '<i data-toggle="tooltip" data-placement="bottom" title="Functia codatului" style="color:yellow;" class="glyphicon glyphicon-star"></i> Membru';
	}
echo '</h2>
<h2><i data-toggle="tooltip" data-placement="bottom" title="Status Download" style="color:chartreuse;" class="glyphicon glyphicon-download-alt"></i> ';
	if($row['download'] == 1) {
		echo '<spin style="color: crimson;">Nu sunt versiuni noi</spin>';
	} else {
		echo 'Versiune noua disponibila';
	}
echo '</h2>
<h2 style="color:crimson;"><i data-toggle="tooltip" data-placement="bottom" title="Versiune instalata" style="color: chartreuse;" class="glyphicon glyphicon-signal"></i> ';
	if($row['version'] == NULL) {
		echo 'Nu are codul instalat';
	} else {
		echo 'v'.$row['version'];
	}
echo '</h2>
<h2 style="color:chartreuse;"><i data-toggle="tooltip" data-placement="bottom" title="Status Banned" style="color: crimson;" class="glyphicon glyphicon-ban-circle"></i> ';
	if($row['blocked'] == 0) {
		echo 'Nu';
	} else {
		echo '<spin style="color: crimson;">Da</spin>';
	}
	echo '</h2>
<h2 style="color:chartreuse;"><i data-toggle="tooltip" data-placement="bottom" title="Last Known Location" style="color: #1C90C9;" class="glyphicon glyphicon-globe"></i> ';
if($row['ip'] == NULL) {
		echo '<spin style="color: crimson;">Unknown Location</spin>';
	} else {
		$ip = $row['ip'];
		$query = json_decode(file_get_contents('http://freegeoip.net/json/'.$ip));
		if($query->country_code !== '') {
		$tara = $query->country_name;
		$oras = $query->city;
		$judet = $query->region_name;
		$taranew = utf8_decode($tara);
		$orasnew = utf8_decode($oras);
		$judetnew = utf8_decode($judet);
		
		if($taranew == NULL) { echo 'Unknown Country'; } else { echo $taranew; } echo ", "; if($orasnew == NULL) { echo 'Unknown City'; } else { echo $orasnew; } echo ", "; if($judetnew == NULL) { echo 'Unknown Region'; } else { echo $judetnew; }
		} else {
			echo '<spin style="color: crimson;">Failed to fetch information.</spin>';
		}
	}
$conna->close();
?>

</h2><br>
<form id="authkey" autocomplete="off" action="/panel/user.php" method="POST">
<div align="center" class="form-group">
<input style="width: 25%;text-align: center;" class="btn btn-success btn-sm input-sm" id="key" type="submit" name="deblock" value="Deblocheaza key"><br></br>
<input style="width: 25%;text-align: center;" class="btn btn-success btn-sm input-sm" id="key" type="submit" name="logout" value="Logout">
</div>
</form>

</div>
</div>

<style>
a.nolink, a.nolink:hover, a.nolink:focus {
outline: none;
text-decoration: none;
color: crimson;
}
</style>

</body>