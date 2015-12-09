<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Battleship | Login</title>
        <link href="https://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet" type="text/css">
        <link href="https://fonts.googleapis.com/css?family=Oxygen" rel="stylesheet" type="text/css">
        <script src="../resources/jquery.js" type="text/javascript"></script>
        <style type="text/css">
            body {
                background-color: #0a0a0a;
                min-height: 350px;
                overflow-y: hidden;
                font-family: "Oxygen", sans-serif;
                margin: 0;
            }
            #main {
                width: 85%;
                margin-left: 7.5%;
                padding: 100px 0 0 0;
                background-color: #eee;
                height: calc(100% - 100px);
            }
            .d {
                display: block;
                margin: 15px;
            }
            .u {
                user-select: none;
                -webkit-user-select: none;
                -moz-user-select: none;
                -ms-user-select: none;
                -o-user-select: none;
                cursor: default;
            }
            .typ {
                border: 0;
                background-color: transparent;
                border-bottom: 2px solid #cecece;
                transition: border .1s ease;
                padding: 5px;
                font-family: "Oxygen", sans-serif;
            }
            .typ:focus {
                border-bottom: 2px solid #9b59b6;
                outline: 0;
            }
            .typ.err {
                border-bottom: 2px solid #c0392b;
            }
            .btn {
                cursor: pointer;
                border: 2px solid #cecece;
                padding: 5px 10px;
                margin-left: 5px;
                background-color: transparent;
                transition: border .1s ease;
            }
            .btn-login:hover, .btn-regis:hover {
                border-color: #9b59b6;
                background-color: #9b59b6;
                color: #eee;
            }
            .btn:focus {
                outline: 0;
            }
            .fill-in {
                display: none;
                padding-bottom: 10px;
                font-size: 13px;
                color: #c0392b;
                width: 110px;
            }
            .fill-in.err {
                display: block;
            }
            #bg {
                width: 800px;
                height: 200px;
                background-image: url(../bg.png);
                background-repeat: no-repeat;
                -webkit-background-size: contain;
                background-size: contain;
            }
            footer {
                bottom: 10px;
                position: absolute;
                width: 85%;
                font-size: 13px;
                font-family: "Open Sans", sans-serif;
            }
            .github {
                text-decoration: none;
                border-bottom: 1px dotted #9b59b6;
                color: #444;
                transition: all .2s ease;
            }
            .github:hover {
                color: #9b59b6;
                border-bottom: 1px solid #9b59b6;
            }
            .heart {
                color: #c0392b;
            }
        </style>
    </head>
    <body>
        <div id="main">
        <center>
            <div id="bg"></div>
            <form action="loginManager.php" method="post">
                <div class="d">
                    <input placeholder="Username" maxlength="14" class="typ typ-login" type="text" name="login" />
                </div>
                <div class="d">
                    <input placeholder="Password" maxlength="21" class="typ typ-passw" type="password" name="pass"
                    onchange="eye();" onkeypress="this.onchange();" onpaste="this.onchange();" oninput="this.onchange();" />
                </div>
                <span class="fill-in u">Please fill in both fields above!</span>
                <input class="btn btn-login u" type="submit" id="btnLogin" name="btnLogin" value="Login">
                <input class="btn btn-regis u" type="submit" id="btnRegister" name="btnRegister" value="Register">
            </form>
            <footer class="u">
                <div>
                Made with <b class="heart">❤</b> by
                <a class="github" href="http://github.com/FabieliHelena" target="_blank">Fabieli Helena</a>,
                <a class="github" href="http://github.com/jrflga" target="_blank">João Ricardo</a>,
                <a class="github" href="http://github.com/NaoEdoJose" target="_blank">José Caldas</a>,
                <a class="github" href="http://github.com/MatheusAvellar" target="_blank">Matheus Avellar</a>,
                <a class="github" href="http://github.com/MilenaCrivella" target="_blank">Milena Crivella</a> and
                <a class="github" href="http://github.com/othiago1" target="_blank">Thiago Moraes</a>.
                </div>
            </footer>
            <script type="text/javascript">
                (function() {
                    $(".btn-login, .btn-regis").on("click", function(e) {
                        var _c = !1;
                        if ($(".typ-login").val().trim() == "") {
                            _c = !0;
                            $(".typ-login").addClass("err");
                        } else {
                            $(".typ-login").removeClass("err");
                        }
                        if ($(".typ-passw").val().trim() == "") {
                            _c = !0;
                            $(".typ-passw").addClass("err");
                        } else {
                            $(".typ-passw").removeClass("err");
                        }
                        if (_c) {
                            e.preventDefault();
                            $(".fill-in").addClass("err");
                        } else {
                            $(".fill-in").removeClass("err");
                        }
                    });
                })();
            </script>
        </center>
      </div>
    </body>
</html>