<?php
    require "connect.php";
    
    $login = (isset($_POST["login"])) ? $_POST["login"] : "";
    $pass = (isset($_POST["pass"])) ? $_POST["pass"] : "";
    
    //To avoid SQL Injection
    $login = stripslashes($login);
    $pass = stripslashes($pass);
    
    //UserID
    $userID_query = "select id from users where login = '" . $login . "'";
    $userID = mysqli_fetch_assoc(mysqli_query($GLOBALS["con"], $userID_query));
    $userID = $userID["id"];
    
    if(authUser($login, $pass)) {
        die("1|" . $userID);
    } else {
        die("0");
    }
?>