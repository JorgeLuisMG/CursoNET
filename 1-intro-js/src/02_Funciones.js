
function obtenerInfo(name = 'Jorge', apellido = 'Mtz'){
    const info = `${name} ${apellido}`;

    return info;
}

const info = obtenerInfo('Luis', 'Gfr');

console.log(info);