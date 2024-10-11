
const obtenerInfo = (name = 'Jorge', apellido = 'Mtz') => `${name} ${apellido}`;
const sum = (a = 0, b = 0) => a + b;

const info = obtenerInfo('Luis', 'Gfr');

console.log(info);
console.log(sum(20,10));