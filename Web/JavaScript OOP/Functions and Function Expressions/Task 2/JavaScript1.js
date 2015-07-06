//Write a function that finds all the prime numbers in a range
//It should return the prime numbers in an array
//It must throw an Error if any of the range params is not convertible to Number
//It must throw an Error if any of the range params is missing
function solve() {

    return function findAllPrimeNums(from, to) {

        var arr = [],
            i,
            isPrime = true;
        if (from * 1 != Number || to * 1 != Number) {
            throw 'Not a digit';
        }
        if (from === undefined || to === undefined) {
            throw 'Undefined';
        }
        if (from === 1) {
            arr.push(from);
            from = 2;
        }
        while (from != to) {
            
            for (i = 2, k=Math.sqrt(from); i <k  ; i += 1) {
                if (from % i === 0) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true) {
                arr.push(from);
            }
            isPrime = true;
            from += 1;
        }
        return arr;
    }
    
}