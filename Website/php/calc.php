<!DOCTYPE html>
<html lang="en">
<head>
    <?php include("header.php");?>
    <link rel="stylesheet" href="../css/style.css">
	<script defer type="text/javascript" src="../js/main.js"></script>
    <title>BMI Calculator</title>
</head>
<body>
    <?php include("nav.php");?>

    <?php
        if(isset($_POST["berekenSubmit"])){
            $gewicht = 85;
            $lengte = 190 / 100;
            if(isset($_POST["gewicht"]) && !empty($_POST["gewicht"])){
                $gewicht = $_POST["gewicht"];
            }
            if(isset($_POST["lengte"]) && !empty($_POST["lengte"])){
                $lengte = $_POST["lengte"] / 100;
            }
            $bmi = $gewicht / ($lengte * $lengte);
            $uitkomst = "";
            if($bmi < 18.5){
                $uitkomst = "Ondergewicht";
            }
            elseif($bmi >= 18.5 && $bmi < 25){
                $uitkomst = "Goed gewicht";
            }
            elseif($bmi >= 25 && $bmi < 27){
                $uitkomst = "Licht overgewicht";
            }
            elseif($bmi >= 27 &&  $bmi < 30){
                $uitkomst = "Matig overgewicht";
            }
            elseif($bmi >= 30 && $bmi < 40){
                $uitkomst = "Ernstig overgewicht";
            }
            else{
                $uitkomst = "Gevaarlijk overgewicht";
            }
            $bmi = round($bmi);
            echo "Uw bmi is: $bmi . U heeft:  $uitkomst" ;
        }
    ?>
    <a href="../index.php">Terug naar Home </a>
    <?php include("footer.php");?>
</body>
</html>