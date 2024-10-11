const carros = [
    {
        id: 1,
        marca: 'Seat',
        modelo: 'Fr',
        anio: 2018,
        nombre: 'Leon',
        client: {
            name: 'Gustavoo',
            apellido: 'Rodriguez'
        }
    },
    {
        id: 2,
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
        id: 3,
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
        id: 4,
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
        id: 5,
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

const carroPorNombre = carros.find(i => i.client.name === 'Gustavo')

console.log(carroPorNombre);

const carroFilter = carros.filter(i => i.id !== 1 )

console.log(carroFilter);

const carroSome = carros.some(i => i.client.name === 'Gustavvo')

console.log(carroSome);