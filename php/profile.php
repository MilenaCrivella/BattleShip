<?php
    require "connect.php";
    
    $userID_query = "select * from users where login = '" . $_GET["n"] . "'";
    $userID = mysqli_query($GLOBALS["con"], $userID_query);
    if (mysqli_num_rows($userID) == 0) {  die("No user with given username.");  }
    $userID = mysqli_fetch_assoc($userID);

    echo "Hello, " . $_GET["n"] . 
    "<br>".
    "Victories -> " . $userID["vic"] .
    "<br>".
    "Defeats -> " . $userID["def"];
?>