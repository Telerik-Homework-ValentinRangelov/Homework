var i,
    firstCharArr = ['a', 'b', 'c', 'd', 'e'],
    secondCharArr = ['a', 'b', 'g', 'p', 'e'],
    firstArrLenght = firstCharArr.length,
    secondArrLenght = secondCharArr.length;

if (firstArrLenght === secondArrLenght) {
    for (i = 0; i < firstArrLenght; i+=1) {
        if (firstCharArr[i] === secondCharArr[i]) {
            console.log(firstCharArr[i] + " = " + secondCharArr[i]);
        } else {
            console.log(firstCharArr[i] + " is not " + secondCharArr[i]);
        }
    }
}