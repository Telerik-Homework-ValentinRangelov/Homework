var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 4, 4];

function countANum(arr , number) {
    var num,
        count = 0;
    for (num in arr) {
        if (arr[num] === number) {
            count += 1;
        }
    }
    return count;
}
console.log(countANum(arr, 4));