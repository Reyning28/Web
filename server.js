const express = require('express');
const bodyParser = require('body-parser');

const app = express();
app.use(bodyParser.json());
app.use(express.static(__dirname)); // Sirve los archivos HTML, CSS y JS

app.post('/save', (req, res) => {
    console.log('Datos recibidos:', req.body.data);
    res.send({ message: 'Datos guardados exitosamente' });
});

app.listen(3000, () => {
    console.log('Servidor corriendo en http://localhost:3000');
});
