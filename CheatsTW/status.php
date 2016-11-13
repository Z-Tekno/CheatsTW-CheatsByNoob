<?php
//SQL

$servername = 'sub.domain.com';
$username = 'user_name';
$password = 'pass_word123';
$dbname = 'user_name';

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    //die("Connection failed: " . $conn->connect_error);
	die("Statisticile Live sunt momentan indisponibile...");
}

$something = "select count(user) FROM cheatstw";
$query = mysqli_query($conn, $something);
$row = mysqli_fetch_array($query);

$live = "select count(use_key) FROM cheatstw WHERE use_key=1";
$sway = mysqli_query($conn, $live);
$raw = mysqli_fetch_array($sway);

$ban = "select count(blocked) FROM cheatstw WHERE blocked=1";
$banned = mysqli_query($conn, $ban);
$ras = mysqli_fetch_array($banned);

//ECHO
echo '<div>';
echo '<p style="font-size: 12px; color:crimson;">Live Statistics</p>';
echo '<div class="row">';
echo '<span style="border-radius: 15px 0px 0px 10px; background-color: black; filter: alpha(opacity=50); opacity: 0.5; border: black solid 1px; text-align: center;" class="showww aa col-sm-2 well well-sm"><h1 class="glyphicon glyphicon-shopping-cart"></h1><h1>'.$row[0].'</h1><p class="text">Key-uri vandute</p></span>';
echo '<span style="border-radius: 0px; background-color: black; filter: alpha(opacity=50); opacity: 0.5; border: black solid 1px; text-align: center;" class="showww bb col-sm-2 well well-sm"><h1 class="glyphicon glyphicon-user"></h1><h1>'.$raw[0].'</h1><p class="text">Folosiri in prezent</p></span>';
echo '<span style="border-radius: 0px; background-color: black; filter: alpha(opacity=50); opacity: 0.5; border: black solid 1px; text-align: center;" class="showww cc col-sm-2 well well-sm"><h1 class="glyphicon glyphicon-ban-circle"></h1><h1>'.$ras[0].'</h1><p class="text">Key-uri banate</p></span>';
echo '<span style="border-radius: 0px; background-color: black; filter: alpha(opacity=50); opacity: 0.5; border: black solid 1px; text-align: center;" class="showww dd col-sm-2 well well-sm"><h1 class="glyphicon glyphicon-euro"></h1><h1>5&euro;</h1><p class="text">Pretul unui key</p></span>';
echo '<span style="border-radius: 0px; background-color: black; filter: alpha(opacity=50); opacity: 0.5; border: black solid 1px; text-align: center;" class="showww ee col-sm-2 well well-sm"><h1 class="glyphicon glyphicon-signal"></h1><h1>v3</h1><p class="text">Versiune actuala</p></span>';
echo '<span style="border-radius: 0px 15px 10px 0px; background-color: black; filter: alpha(opacity=50); opacity: 0.5; border: black solid 1px; text-align: center;" class="showww ff col-sm-2 well well-sm"><h1 class="glyphicon glyphicon-certificate"></h1><h1>NOT OK</h1><p class="text">API este in lucru!</p></span>'; // Codul poate fi rulat | Se lucreaza la cod | Probleme la API | Se face update la cod
echo '<style>';
echo '.showww .text {
display: none;
}

.showww:hover .text {
display: block;
}';
echo '</style>';
echo '</div>';
echo '</div>';

// CLOSE CONN
$conn->close();
?>
