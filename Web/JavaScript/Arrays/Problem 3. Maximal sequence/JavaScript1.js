
var arr = [1,2,3,3,3,4,5,6,7],
    max = 1,
    currentMax = 1,
    maxEndIndex = 0,
    i,
    len,
    maxSequence;

for (i = 0, lenght = arr.lenght; i < length; i += 1) {
    if (arr[i] === arr[i - 1]) {
        currentMax += 1;
        if (currentMax > max) {
            max = currentMax;
            maxEndIndex = i;
        }
    } else {
        currentMax = 1;
    }
}

maxSequence = arr.splice(maxEndIndex - max + 1, max).join(', ');
console.log(maxSequence);

