var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'],
    arrLength = arr.length;
    
function removeElements(element , arr) {
    var i;
    for (i = 0; i < arrLength; i+=1) {
        if (arr[i] === element) {
            arr.splice(i, 1);
        }
    }
    return arr;
}
console.log(removeElements(1,arr));