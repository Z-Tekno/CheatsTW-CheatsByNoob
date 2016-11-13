<?php
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
$conna->close();
}
//SQL

if(isset($_SESSION['cheats']) && $_SESSION['cheats'] == "Administrator" && isset($_SESSION['tw']) && $_SESSION['tw'] == 'pa$$worD') {
	header('Location: /panel/dashboard.php');
	die();
} elseif(isset($_SESSION['cheatskey']) && $_SESSION['cheatskey'] == $row['cd_key'] && isset($_SESSION['submitkey']) && $_SESSION['submitkey'] == 'Insert') {
	header('Location: /panel/user.php');
	die();
} else {
	//NIMIC;
}
?>

<!DOCTYPE html>
<html>
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
<link href='https://fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'>
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
<title>CheatsTW.com - Cheat Panel</title>
</head>

<body style="font-size: 16px; text-align: center; font-family: 'Montserrat', sans-serif; cursor: default; -moz-user-select: none; -webkit-user-select: none; -ms-user-select:none; user-select:none;-o-user-select:none; color: chartreuse; background: url(
<?php
$rand = rand(0,6);
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
} elseif($rand == 5) {
	echo "https://i.imgur.com/P21KnkT.jpg";
} elseif($rand == 6) {
	echo "https://i.imgur.com/NdBlw4j.jpg";
} else {
	// NIMIC
}
?>) no-repeat center center fixed; -webkit-background-size: cover; -moz-background-size: cover; -o-background-size: cover; background-size: cover;">

<script>
$(document).ready(function(){
<?php
if (stripos($_SERVER['HTTP_USER_AGENT'], "firefox")>0) {
echo "$('#fade1').fadeIn('slow');";
echo "$('#fade2').fadeIn(6000);";
echo "$('#fade3').fadeIn(4000);";
} else {
echo "$('#fade1').show('slow');";
echo "$('#fade2').show(6000);";
echo "$('#fade3').show(4000);";
}
?>
$('[data-toggle="tooltip"]').tooltip();
});
</script>

<script>
$(document).ready(
function() {
$("html").niceScroll();
}
);
</script>

<div id="fade1" style="display:none; position: fixed; top: 0px; width: 100%; height: 100%; background-color: black; filter: alpha(opacity=60); opacity: 0.6;">
</div>

<div id="fade3" style="display:none; position: relative;">
<h1><i data-toggle="tooltip" data-placement="bottom" title="Ai garantia ca pe CheatsTW.com nu o sa ai probleme cu key-ul in caz ca ti-a fost blocat." style="color:mediumseagreen;" class="glyphicon glyphicon-dashboard"></i> CheatsTW Panel</h1>
</div>

<div id="fade2" style="bottom: 0; left: 0; right: 0; margin: auto; width: 100%; height: 75%; display:none; position: absolute;">
<div class="container">
<h2><i data-toggle="tooltip" data-placement="bottom" title="Aici se intra doar pe pile." style="color:mediumseagreen;" class="glyphicon glyphicon-user"></i><span style="color:crimson;"> Admin</span> Panel</h2>
<form id="authkey" method="POST" autocomplete="off" action="/panel/dashboard.php">
<div align="center" class="form-group">
<input style="width: 25%;text-align: center;" class="form-control input-sm" id="key" type="text" name="cheats" placeholder="Username"><br>
<input style="width: 25%;text-align: center;" class="form-control input-sm" id="key" type="password" name="tw" placeholder="Password"><br>
<input style="width: 5%;text-align: center;" class="btn btn-success btn-sm input-sm" id="key" type="submit" value="Login">
</div>
</form><br>

<h2><i data-toggle="tooltip" data-placement="bottom" title="In caz ca ai key-ul blocat, il poti debloca de aici foarte usor! Pe langa asta, CheatsTW ofera mai multe functii. Foloseste key-ul ca sa vezi celelalte functii." style="color:mediumseagreen;" class="fa fa-key"></i><span style="color:crimson;"> Member</span> Panel</h2>
<form id="authkey" method="POST" autocomplete="off" action="/panel/user.php">
<div align="center" class="form-group">
<input style="width: 25%;text-align: center;" class="form-control input-sm" id="key" type="password" name="cheatskey" placeholder="Key" maxlength="16"><br>
<input style="width: 5%;text-align: center;" class="btn btn-danger btn-sm input-sm" id="key" type="submit" name="submitkey" value="Insert">
</div>
</form>
</div>
</div>
</body>
</html>

<style>
a.nolink, a.nolink:hover, a.nolink:focus {
outline: none;
text-decoration: none;
color: crimson;
}
</style>