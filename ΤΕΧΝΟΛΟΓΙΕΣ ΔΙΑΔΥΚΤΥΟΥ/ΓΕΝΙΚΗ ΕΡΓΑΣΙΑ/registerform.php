<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Φόρμα Εγγραφής</title>
        <link rel="stylesheet" href="style.css">
        <style>
            body {
                font-family: Arial, sans-serif;
                background-color: #000000;
                margin: 0;
            }

            form {
                max-width: 700px;
                margin: 20px auto;
                background-color: #ff9500;
                padding: 30px;
                border-radius: 8px;
                box-shadow: 0 0 10px #ffffff;
            }

            form hr{
                height: 10px;
                background-color: #000000;
                width: 100%;
            }

            .form-group {
                margin-bottom: 15px;
            }

            label {
                display: block;
                margin-bottom: 8px;
                font-weight: bold;
            }

            input, select{
                width: 96%;
                padding: 10px;
                margin-top: 5px;
                margin-bottom: 15px;
                border: 5px solid #000000;
                border-radius: 4px;
            }

            input:focus {
                border-color: orange;
            }

            .form-buttons {
                display: flex;
                justify-content: space-between;
            }

            button {
                padding: 10px 15px;
                background-color: #007BFF;
                color: #fff;
                border: none;
                border-radius: 4px;
                cursor: pointer;
            }

            button:hover {
                background-color: #0056b3;
            }

            table {
                background-color: white;
            }

            @media (max-width: 650px) {
                /* Το εκανα 650 αντι για 500 γιατι δεν με αφηνει το chrome να κανω το παραθυρο μικρο αρκετα */
                form {
                    background-color: grey;
                }
            }
        </style>
    </head>

    <body>
        <form action="registerform.php" method="post">
            <div class="form-group">
                <label for="emailsearch"  title="Ψάξτε τον κωδικο σας">Search email:</label>
                <input type="text" name="emailsearch" id="emailsearch" placeholder="ilovepasswards@db.scam">
            </div>
            <div class="form-buttons">
                <button type="submit" name="searchsub">Υποβολή</button> 
            </div>
        </form>
        <form action="registerform.php" method="post">

            <h1><u>Φόρμα Εγγραφής για την εταιρία FRK</u></h1><hr>

            <div class="form-group">
                
                <label for="btnm">Κύριος</label>
                <input name="btn" checked="checked" type="radio" id="btnm" value="Κύριος">
                <label for="btnf">Κυρία</label>
                <input name="btn" type="radio" id="btnf" value="Κυρία">
            </div>
            <hr>
            <div class="form-group">
                <label for="name"  title="Συμπληρώστε το όνομα σας με ελληνικά γράμματα">Όνομα:</label>
                <input type="text" name="name" id="name" placeholder="Όνομα">
            </div>
            <hr>
            <div class="form-group">
                <label for="birthdate">Ημερομηνία Γέννησης:</label>
                <input type="date" name="birthdate" id="birthdate" max="2022-12-31" min="1980-01-01">
            </div>
            <hr>
            <div class="form-group">
                <label for="country">Χώρα Κατοικίας:</label>
                <select name="country" id="country">
                    <option value="Ελλάδα" selected>Ελλάδα</option>
                    <option value="Τουρκία">Τουρκία</option>
                    <option value="Ιταλία">Ιταλία</option>
                    <option value="Αλβανία">Αλβανία</option>
                    <option value="Βουλγαρία">Βουλγαρία</option>
                </select>
            </div>
            <hr>
            <div class="form-group">
                <label for="status">Οικογενειακή Κατάσταση:</label>
                <select name="status" id="status">
                    <option value="Έγγαμος">Έγγαμος</option>
                    <option value="Άγαμος">Άγαμος</option>
                </select>
            </div>
            <hr>
            <div class="form-group">
                <label for="address" title="Διέυθυνση με το νούμερο μαζί">Διεύθυνση:</label>
                <input style="width: 60px;" type="text" name="address" id="address" placeholder="Διεύθυνση" required>
            </div>
            <hr>
            <div class="form-group">
                <label for="city" title="Η πόλη στην οποία κατοικείτε">Πόλη:</label>
                <input type="text" name="city" id="city" placeholder="Πόλη">
            </div>
            <hr>
            <div class="form-group">
                <label for="region" title="Η περιοχή στην οποία κατοικείτε">Περιοχή/Περιφέρεια:</label>
                <input type="text" name="region" id="region" placeholder="Περιοχή">
            </div>
            <hr>
            <div class="form-group">
                <label for="postal-code" title="5-ψήφιο νούμερο">Ταχυδρομικός Κώδικας:</label>
                <input type="text" name="pc" id="postal-code" placeholder="Ταχυδρομικός Κώδικας" maxlength="5">
            </div>
            <hr>
            <div class="form-group">
                <label for="phone" title="Νούμερο κινητού τηλεφώνου">Τηλέφωνο:</label>
                <input type="tel" name="phone" id="phone" placeholder="Τηλέφωνο" maxlength="10">
            </div>
            <hr>
            <div class="form-group">
                <label for="email">Email:</label>
                <input type="email" name="email" id="email" placeholder="Email">
            </div>
            <hr>
            <div class="form-group">
                <label for="username">Συνθηματικό Πρόσβασης:</label>
                <input type="text" name="username" id="username" placeholder="Συνθηματικό Πρόσβασης" required>
            </div>
            <hr>
            <div class="form-group">
                <label for="password">Κωδικός Πρόσβασης:</label>
                <input type="password" name="password" id="password" placeholder="Κωδικός Πρόσβασης" required>
            </div>
            <hr>
            <div class="form-group">
                <label for="terms-agreement">Έχω διαβάσει και αποδέχομαι τους Όρους & Προϋποθέσεις</label>
                <input type="checkbox" id="terms-agreement" required>
            </div>
            <hr>
            <div class="form-buttons">
                <button type="reset">Ακύρωση</button>
                <button type="submit" name="formsub">Υποβολή</button> 
            </div>
        </form>
        
    </body>
</html>

<?php

    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $gender = $_POST["btn"];
        $name = $_POST["name"];
        $birthdate = $_POST["birthdate"];
        $country = $_POST["country"];
        $status = $_POST["status"];
        $address = $_POST["address"];
        $city = $_POST["city"];
        $region = $_POST["region"];
        $postal_code = $_POST["pc"];
        $phone = $_POST["phone"];
        $mail = $_POST["email"];
        $username = $_POST["username"];
        $password1 = $_POST["password"];

        $servername = "localhost";
        $username = "root";
        $password = "";
        $dbname = "randomdb";

        $conn = new mysqli($servername, $username, $password, $dbname);

        if(isset($_POST['formsub'])){    
            $sql = "INSERT INTO formdata (gender, realname, birthdate, country, `status`, `address`, city, region, postalcode, phone, mail, username, `password`)
            VALUES ('$gender', '$name', '$birthdate', '$country', '$status', '$address', '$city','$region', '$postal_code', '$phone', '$mail', '$username', '$password1')";
            mysqli_query($conn, $sql);
        }

        if(isset($_POST['searchsub'])){ 
            $email_to_search = $_POST['emailsearch'];
            $sql_search = "SELECT * FROM formdata WHERE mail='$email_to_search'";
            $result = $conn->query($sql_search);

            if ($result->num_rows > 0) {
                echo "<table border='1'>
                    <tr style=\"backgroundcolor:white;\">
                        <th>gender</th>
                        <th>realname</th>
                        <th>birthdate</th>
                        <th>country</th>
                        <th>status</th>
                        <th>address</th>
                        <th>city</th>
                        <th>region</th>
                        <th>postalcode</th>
                        <th>phone</th>
                        <th>mail</th>
                        <th>username</th>
                        <th>password</th>
                    </tr>";

                while($row = $result->fetch_assoc()) {
                    $birth_year = date('Y', strtotime($row['birthdate']));
                    $background_color = ($birth_year % 2 == 0) ? "red" : "green";
                    echo "<tr style=\"background-color:". $background_color .";\">";
                        echo "<td>" . $row['gender'] . "</td>";
                        echo "<td>" . $row['realname'] . "</td>";
                        echo "<td>" . $row['birthdate'] . "</td>";
                        echo "<td>" . $row['country'] . "</td>";
                        echo "<td>" . $row['status'] . "</td>";
                        echo "<td>" . $row['address'] . "</td>";
                        echo "<td>" . $row['city'] . "</td>";
                        echo "<td>" . $row['region'] . "</td>";
                        echo "<td>" . $row['postalcode'] . "</td>";
                        echo "<td>" . $row['phone'] . "</td>";
                        echo "<td>" . $row['mail'] . "</td>";
                        echo "<td>" . $row['username'] . "</td>";
                        echo "<td>" . $row['password'] . "</td>";
                    echo "</tr>";
                }
                echo "</table>";
            } else {
                echo "Δεν βρέθηκαν αποτελέσματα";
            }
        }
        $conn->close();
    }
?>

