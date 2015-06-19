function reverseNumber(number) {
    var reversedNumber="",
        i,
        n;
    number = number.toString();
    for (i = number.length-1; i >= 0; i-=1) {
        reversedNumber += number[i];
    }
    return +reversedNumber;
}

console.log(reverseNumber(12345));