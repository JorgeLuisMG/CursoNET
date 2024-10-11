const carros = ['Ferrari', 'Nissan GTR', 'Porsche', 'Mc Laren', 'Mercedes GLC'];

const carros2 = carros.concat('Mustang GT500', 'Callenger', 'Camaro');

const motos = ['Italika', 'Choper', 'Ninja', 'SuperSport'];

const tienda = [...motos, ...carros, 'rin 18'];

const tienda2 = motos.concat(carros2).concat('rin 18');

console.log(carros2);

console.log(tienda2);