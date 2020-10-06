<!DOCTYPE html>
<html lang="en">
<!DOCTYPE html>
<html lang="en">
<head>
    <?php include("php/header.php");?>
    <link rel="stylesheet" href="css/style.css">
	<script defer type="text/javascript" src="js/main.js"></script>
    <title>BMI Calculator</title>
</head>
<body>
    <?php include("php/nav.php");?>
    <div id="content">
        <form action="php/calc.php" method="POST">
            <label for="gewicht"> Gewicht:</label>
            <input type="number" name="gewicht" class="gewicht form-control">

            <label for="lengte"> Lengte: </label>
            <input type="number" name="gewicht" class="gewicht form-control">

            <input type="submit" name="berekenSubmit" class="btn btn-dark">
        </form>
    </div>
    
    <?php include("php/footer.php");?>
</body>
</html>