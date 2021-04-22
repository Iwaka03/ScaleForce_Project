<?php include("server.php"); ?>
<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="StyleLogin.css">
</head>
<body>
    <div class="login-box">
        <h1>Login</h1>
    
        <form method="post" action="login.php">
        <!-- display validation errors here -->
        <?php include('errors.php'); ?>
            <div class="textbox">
            <label>Username</label>
            <i class="fas fa-user"></i>
            <input type="text" name="username">
        </div>
        
        <div class="textbox">
            <label>Password</label>
            <i class="fas fa-lock"></i>
            <input type="password" name="password">
        </div> 
        
        <div class="textbox">
            <button type="submit" name="login" class="btn">Login</button>
        </div> 
            <p>
                Not yet a member? <a href="register.php">Sign up</a>
            </p>
        </form>
    </div>
</body>
</html>