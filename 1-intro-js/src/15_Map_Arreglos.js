const carros = [
    {
        marca: 'Seat',
        modelo: 'Fr',
        anio: 2018,
        nombre: 'Leon',
        client: {
            name: 'Gustavo',
            apellido: 'Rodriguez'
        }
    },
    {
        marca: 'Seat',
        modelo: 'Excellence',
        anio: 2018,
        nombre: 'Arona',
        client: {
            name: 'Gustavo',
            apellido: 'Rodriguez'
        }
    },
    {
        marca: 'Cupra',
        modelo: 'Cupra',
        anio: 2018,
        nombre: 'Ateca',
        client: {
            name: 'Gustavo',
            apellido: 'Rodriguez'
        }
    },
    {
        marca: 'Cupra',
        modelo: 'Cupra',
        anio: 2018,
        nombre: 'Formentor',
        client: {
            name: 'Gustavo',
            apellido: 'Rodriguez'
        }
    },
    {
        marca: 'Seat',
        modelo: 'Electrico',
        anio: 2018,
        nombre: 'Moto',
        client: {
            name: 'Gustavo',
            apellido: 'Rodriguez'
        }
    },
];

console.log(carros);

const marcasCarros = carros.map(i => {
    return i.marca;
});

const nombresCarros = carros.map(i => {
    return i.client.name;
});

console.log(marcasCarros);
console.log(nombresCarros);