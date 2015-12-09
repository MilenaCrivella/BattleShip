<?php 
    require 'connect.php';
    
    
    function authUser($user, $pass) {
        $query = "select * from users where login = '" . $user . "' and pass = '" . $pass . "'";
        $result = mysqli_query($GLOBALS['con'], "select * from users where login = '" . $user . "' and pass = '" . $pass . "'");
        $count = mysqli_num_rows($result);
    
        if($count == 1)
            return true;
        else
            return false;
    }
    
    function registerUser($user, $pass) {
        $select = "select * from users where login = '" . $user . "' and pass = '" . $pass . "'";
        $result = mysqli_query($GLOBALS['con'], $select);
        $count = mysqli_num_rows($result);
        
        if($count == 0) {
            $insert = "insert into users (login, pass) values ('" . $user . "', '" . $pass . "')";
            mysqli_query($GLOBALS['con'], $insert);
            return true;
        } else
            return false;
    }
?>