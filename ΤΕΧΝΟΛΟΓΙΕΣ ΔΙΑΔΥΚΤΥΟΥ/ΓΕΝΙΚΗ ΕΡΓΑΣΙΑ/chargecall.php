<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Κλήσεις Κινητής Τηλεφωνίας</title>
    <style>
        body {
        font-family: Arial, sans-serif;
        text-align: center;
        margin: 20px;
        color: white;
        background-color: rgb(80, 79, 79);
        }

        *{
        text-shadow:2px 2px 5px;
        }

        form {
        border: dotted;
        border-radius: 30px;
        margin-bottom: 20px;
        padding-top: 20px;
        padding-bottom: 20px;
        }

        button, input {
        border-radius: 10px;
        margin-top: 10px;
        text-shadow: 5px 5px 5px white;
        }
    </style>
</head>
<body>
    <h2>Κλήσεις Κινητής Τηλεφωνίας</h2>

    <form id="callForm">
        <label for="duration">Διάρκεια Ομιλίας (δευτερόλεπτα): </label>
        <input type="number" id="duration" required>
        <button type="button" onclick="calculateCharge()">Υπολογισμός Χρέωσης</button>
        <button type="button" onclick="terminate()">Τερματισμός</button>
    </form>

    <script>
        let totalCharges = 0;
        let callCount = 0;
        let expensivecalls = 0;

        function calculateCharge() {
            const durationInput = document.getElementById('duration');
            const duration = parseInt(durationInput.value);

            if (duration > 0) {
                const charge = calculateChargeAmount(duration);
                totalCharges += charge;
                callCount++;

                if (charge >= 2){
                    expensivecalls++;
                }

                // Save call details to CSV
                saveToCSV(callCount, duration, charge);

                // Check termination conditions
                if (totalCharges > 10 || callCount >= 100) {
                    terminate();
                }

                alert(`Χρέωση για την κλήση ${callCount}: ${charge.toFixed(2)} ευρώ`);
                durationInput.value = '';
            } else {
                alert('Παρακαλώ εισάγετε θετικό αριθμό για τη διάρκεια της κλήσης.');
            }
        }

        function calculateChargeAmount(duration) {
            const firstThreeMinutesCharge = 0.06;
            const additionalMinutesCharge = 0.04;

            const totalMinutes = Math.ceil(duration / 60);
            let charge = 0;

            if (totalMinutes <= 3) {
                charge = totalMinutes * firstThreeMinutesCharge;
            } else {
                charge = 3 * firstThreeMinutesCharge + (totalMinutes - 3) * additionalMinutesCharge;
            }

            return charge;
        }

        function terminate() {
            const percentageAbove2Euros = (expensivecalls / callCount) * 100;
            alert(`Συνολικές Χρεώσεις: ${totalCharges.toFixed(2)} ευρώ\nΠοσοστό Κλήσεων άνω των 2 ευρώ: ${percentageAbove2Euros.toFixed(2)}%`);
        }

        function saveToCSV(callNumber, duration, charge) {
            const xhr = new XMLHttpRequest();
            xhr.open('POST', 'saveCall.php', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4 && xhr.status == 200) {
                    console.log(xhr.responseText);
                }
            };
            xhr.send(`callNumber=${callNumber}&duration=${duration}&charge=${charge}`);
        }
    </script>
	

	
</body>
</html>
