var  arr = [],
     sum = 0,
     numOfWomens = 0,
     i;


function makePerson(firstname, lastname, age, gender) {
    arr.push({
        firstname: firstname,
        lastname: lastname,
        age: age,
        gender: gender
    })
    return arr;
}

for (i = 0; i < 10; i += 1) {
    if (i % 2) {
        makePerson('Firstname' + i, 'Lastname' + i, i, true);
    }
    else {
        makePerson('Firstname' + i, 'Lastname' + i, i, false);
    }
}

console.log(arr);

arr[1].age = 20;

console.log(arr.every(function (person) {
    return person.age < 18;
}))

result = arr.filter(function (person) {
    return person.age < 18;
})
.forEach(function (person) {
    console.log(person.firstname + ' ' + person.lastname + 'is ' + person.age + ' years old.');

});


averageFemaleAge = arr.filter(function (person) {
    person.gender = true;
}).forEach(function (person) {

    sum += person.age;
    numOfWomens += 1;
});
console.log(sum/numOfWomens);

