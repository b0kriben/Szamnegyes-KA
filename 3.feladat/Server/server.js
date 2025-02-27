const express = require('express');
const app = express();
const port = 3000;

let foursDb = [];
let idCounter = 1;

app.use(express.json());

app.post('/fours', (req, res) => {
    const data = req.body;

    if (data.length !== 4) {
        return res.status(400).send('Invalid data');
    }

    const newFour = { id: idCounter++, numbers: data };
    foursDb.push(newFour);

    res.status(201).json(newFour);
});

app.get('/fours', (req, res) => {
    res.json(foursDb);
});

app.get('/fours/:id', (req, res) => {
    const id = parseInt(req.params.id, 10);
    const found = foursDb.find(four => four.id === id);

    if (!found) {
        return res.status(404).send('Not found');
    }

    res.json(found);
});

app.listen(port, () => {
    console.log(`Server running on http://localhost:${port}`);
});
