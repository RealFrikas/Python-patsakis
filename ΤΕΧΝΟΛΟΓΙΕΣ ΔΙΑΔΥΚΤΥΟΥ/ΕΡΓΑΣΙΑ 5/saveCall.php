	<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $callNumber = $_POST["callNumber"];
    $duration = $_POST["duration"];
    $charge = $_POST["charge"];

    $callDetails = "$callNumber,$duration,$charge\n";
    file_put_contents('calls.csv', $callDetails, FILE_APPEND);
    echo "Call details saved successfully.";
}
?>
