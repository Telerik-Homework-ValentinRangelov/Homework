var arr = [1, 2, 3, 4, 10, 6, 7, 8, 9],
    arrLenght = arr.length;

function check(arr, index) {
    var noNeighbour = 'There is no second neighbour to that number at that index!',
    yes = 'Yes they are equal: ' + arr[index - 1] + ' + ' + arr[index + 1] + ' === ' + arr[index],
    no = 'No they are not equal: ' + arr[index - 1] + ' + ' + arr[index + 1] + ' != ' + arr[index];
    if (index === 0 || index === arrLenght) {
        return noNeighbour;
    }
    else {
        if (arr[index - 1] + arr[index + 1] === arr[index]) {
            return yes;
        }
        else {
            return no;
        }
    }
    
}


console.log(check(arr , 4));
