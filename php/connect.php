<?php
    //PHP Configs
    define("HOST", getenv('IP'));
    define("USER", "loginBot");
    define("PASS", "JXPYd4gDWtgYHxrQ");
    define("DTBS", "battleship");
    define("PORT", 3306);

    define("CAN_REGISTER", "any");
    define("DEFAULT_ROLE", "user");

    define("SECURE", FALSE); // FOR DEVELOPMENT ONLY!!!!

    $con = mysqli_connect(HOST, USER, PASS, DTBS, PORT);
?>