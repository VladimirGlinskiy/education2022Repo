const express = require('express');
const bodyParser = require('body-parser');
const app = express();
const port = 3000;
const path = require('path');


const db = require('./static/js/dbConnectors.js');


app.listen(port);
app.use(bodyParser.json());
app.use(
    bodyParser.urlencoded({
        extended: true,
    })
);

app.use(express.static('static'));

app.get('/', function (req, res) {
    res.sendFile(path.join(__dirname, '/static/gallery.html'));
});


app.get('/getToken', function (request, response) {

    if (request.query.token != null && request.query.token !== undefined) {
        let tokenValue = request.query.token;
        db.isUserTokenValid(tokenValue).then((result) => {
            response.send(result.rows);
        })
    }
});












