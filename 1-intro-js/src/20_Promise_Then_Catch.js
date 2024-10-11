import { carroPorId } from './data/carros'

const promise = new Promise((resolve, reject) => {
    setTimeout(() => {
        const test = carroPorId(10);
        
        if(test){
            resolve(test);
        }else{
            reject('Error> No se encontro el carro');
        }

    }, 3000);
});

promise.then((json) => {
    console.log(json);
    console.log('Realicado con exito');
}).catch((error) => {
    console.error(error);
});