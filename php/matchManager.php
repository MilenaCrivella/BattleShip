<?php
    require "connect.php";
    require "security.php";
    
    function findMatch($user) {
        $matchFinder = "select * from matchs;";
        $matchResult = mysqli_query($GLOBALS['con'], $matchFinder);
        $matchCount = mysqli_num_rows($matchResult);
    
        if($matchCount < 1) {
            $matchStart = "insert into matchs (player1) values ('" . $user . "')";
            $matchResult = mysqli_query($GLOBALS['con'], $matchStart);
        } else {
            
        }
    }
?>