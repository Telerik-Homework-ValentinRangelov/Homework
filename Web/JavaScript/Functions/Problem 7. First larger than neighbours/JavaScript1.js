var arr = [1, 2, 3, 4, 10, 6, 7, 8, 9],
    arrLenght = arr.length;

function check(arr) {
    var num,
        i,
        index;
    for (i = 0; i < arrLenght; i +=1) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            index = i;
            return index;
        }
    }
    return -1;
}


console.log(check(arr));
