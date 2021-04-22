<?php include('server.php'); ?>
<!DOCTYPE html>
<html>
<head>
    <title>Register</title>
    <link rel="stylesheet" type="text/css" href="StyleRegister.css">
</head>
<body>
    <div class="Register-box">
        <h1>Register</h1>
    
        <form method="post" action="register.php">
        <!-- display validation errors here -->
        <?php include('errors.php'); ?>
            <div class="textbox">
                <label>Username</label>
                <i class="fas fa-user"></i>
                <input type="text" name="username" value="<?php echo $username; ?>">
            </div>
            <div class="textbox">
                <label>Email</label>
                <i class="fas fa-envelope"></i>
            <input type="text" name="email" value="<?php echo $email; ?>">
        </div>
        <div class="textbox">
            <label>Password</label>
            <i class="fas fa-lock"></i>
            <input type="password" name="password_1">
        </div> 
        <div class="textbox">
            <label>Confirm Password</label>
            <i class="fas fa-lock"></i>
            <input type="password" name="password_2">
        </div>
        <div class="input-group">
            <button type="submit" name="register" class="btn">Register</button>
        </div> 
        <p>
            Already a member? <a href="login.php">Sign in</a>
        </p>
    </div>
    </form>
</body>
</html>