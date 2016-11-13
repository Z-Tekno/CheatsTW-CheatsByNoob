<?php

If(isset($_GET['key']) && isset($_GET['set']) && isset($_GET['hash'])) {
$key = $_GET['key'];
$set = $_GET['set'];
$hash = $_GET['hash'];

if($set == 0) {
echo "Cheia a fost folosita cu success";
} elseif($set == 1) {
echo "Acum nu mai folosesti aceasta cheie";
}
}
?>