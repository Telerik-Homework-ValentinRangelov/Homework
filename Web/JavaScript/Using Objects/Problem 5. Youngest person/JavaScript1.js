var people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Minko', lastname: 'Jorov', age: 31 },
  { firstname: 'Valio', lastname: 'Stoqnov', age: 21 },
  { firstname: 'Georgi', lastname: 'Vasilev', age: 19 }];

function youngestPerson(people) {
    var minAge = Number.MAX_VALUE,
        person,
        fullname;
    for (person in people) {
        if (minAge > people[person].age) {
            minAge = people[person].age;
            fullname = people[person].firstname + " " + people[person].lastname;
        }
    }
    return fullname;
}
console.log(youngestPerson(people));

