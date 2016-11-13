<?php
session_start();
if(isset($_SESSION['username']) && isset($_SESSION['password'])) {
if($_SESSION['username'] == "Administrator" && $_SESSION['password'] == "pa$$worD") {
	header('Location: /stiri/dashboard.php');
	die();
} else {
	//NIMIC;
}
}
?>
<!DOCTYPE html>
<html>
<head><title>Panel Stiri</title></head>
<body>
<div align="center" style="text-align: center;">
<h1>Login la Stiri</h1>
<form method="POST" action="/stiri/dashboard.php">
<input style="text-align: center;" align="center" type="text" name="username" placeholder="username"><br>
<input style="text-align: center;" align="center" type="password" name="password" placeholder="password"><br>
<input style="text-align: center;" align="center" type="submit" value="Login">
</form><br></br>
<h2>Cateva chestii importante:</h2>
<p>Multumim mult pentru contribuirea adminului <a href="http://orangepanel.bugged.ro/profile/vick" target="_blank">ViCK</a> de pe acest <a href="http://orangepanel.bugged.ro/" target="_blank">server</a>, pentru ca ne-a ajutat foarte mult sa imbunatatim 'securitatea' la stiri. Daca nu ar fi fost el, codul ar fi murit.</p>
<p>Si uite asa... multumim adminilor ca se implica atat de mult pentru fixarea 'vulnerabilitatilor' de mica paguba care pot fi produse in favoarea lor.</p>
<p>In caz ca au fost alti hax0ri care l-au ajutat pe <a href="http://orangepanel.bugged.ro/profile/vick" target="_blank">ViCK</a> sa 'sparga' stirile si sa scrie 'ViCK power', inseamna ca Maribu este bun si fara coduri.</p>
<p>Multumiri speciale pentru dezvaluirea bazei de date & link-ului de la stiri care nu mai exista: GooD & Live-urile lui</p><br>
<h2>De retinut:</h2>
<p>api.xpeedo.net este un site care DOAR* gazduite API-uri si diverse script-uri PHP. Momentan, urmatoarele proiecte gazduite pe aceasta platforma sunt:</p>
<p>- CheatsTW.com.</p><br>
<sub>* api.xpeedo.net nu este afiliat CheatsTW.com.</sub>
<audio autoplay loop preload="auto" src="/stiri/music1.mp3"></audio>
</div>
</body>
</html>