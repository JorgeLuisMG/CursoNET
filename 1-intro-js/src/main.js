

//request
//    .then(response => response.json())
//    .then(data => console.log(data));

const findAllUsers = async() => {
    const response = await fetch('https://jsonplaceholder.typicode.com/users');
    const users = await response.json();
    const ul = document.createElement('ul');

    users.forEach(element => {
        const li = document.createElement('li');
        li.innerText = element.name;
        ul.append(li);
        console.log(element.name);
    });

    document.getElementById('root').append(ul);
}

findAllUsers();
//console.log(users);
console.log('Prueba de delay');