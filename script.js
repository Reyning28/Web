document.addEventListener("DOMContentLoaded", () => {
    const inputs = document.querySelectorAll(".color-input");
    const redCountSpan = document.getElementById("redCount");
    const greenCountSpan = document.getElementById("greenCount");
    const blueCountSpan = document.getElementById("blueCount");

    // Función para actualizar los contadores
    function updateCounts() {
        let redCount = 0;
        let greenCount = 0;
        let blueCount = 0;

        inputs.forEach(input => {
            const value = input.value.trim().toLowerCase();

            // Revisar el valor y actualizar los contadores
            if (value === "rojo") redCount++;
            else if (value === "verde") greenCount++;
            else if (value === "azul") blueCount++;
        });

        // Actualizar los contadores en la interfaz
        redCountSpan.textContent = redCount;
        greenCountSpan.textContent = greenCount;
        blueCountSpan.textContent = blueCount;
    }

    // Agregar evento a cada input para detectar cambios
    inputs.forEach(input => {
        input.addEventListener("input", () => {
            const value = input.value.trim().toLowerCase();

            // Quitar clases previas
            input.classList.remove("red", "green", "blue");

            // Asignar color según el valor
            if (value === "rojo") {
                input.classList.add("red");
            } else if (value === "verde") {
                input.classList.add("green");
            } else if (value === "azul") {
                input.classList.add("blue");
            }

            // Actualizar los contadores
            updateCounts();
        });
    });

    // Guardar datos al presionar el botón
    document.getElementById("saveButton").addEventListener("click", () => {
        const data = Array.from(inputs).map(input => input.value.trim());
        console.log("Datos a guardar:", data); // Debug en consola

        fetch('/save', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ data })
        }).then(response => {
            console.log("Datos guardados en el servidor:", response);
        }).catch(error => {
            console.error("Error al guardar los datos:", error);
        });
    });
});
