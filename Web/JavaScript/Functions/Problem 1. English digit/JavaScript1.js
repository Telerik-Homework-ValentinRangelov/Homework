function lastDigit(number) {
    var numberAsWord,
        n = number % 10;
    if (n == 0) {
        numberAsWord = "Zero";
    } else if (n == 1) {
        numberAsWord = "One";
    } else if(n == 2){
        numberAsWord = "Two";
    } else if (n == 3) {
        numberAsWord = "Three";
    } else if (n == 4) {
        numberAsWord = "Four";
    } else if (n == 5) {
        numberAsWord = "Five";
    } else if (n == 6) {
        numberAsWord = "Six";
    } else if (n ==7) {
        numberAsWord = "Seven";
    } else if (n == 8) {
        numberAsWord = "Eight";
    } else {
        numberAsWord = "Nine";
    }
    return numberAsWord;
}

console.log(lastDigit(1123123));