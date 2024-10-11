
const request = fetch('https://jsonplaceholder.typicode.com/users');

/*request.then(response => {
    console.log(response);
    response.json().then(data => {
        console.log(data);
    })
})*/

request
    .then(response => response.json())
    .then(data => console.log(data));

console.log('Prueba de delay');