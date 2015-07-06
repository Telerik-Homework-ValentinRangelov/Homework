
function sum(x) {
    
   
        var sum = 0;
        
        if (arr.length === 0) {
            return null;
        }
        if (arr === undefined) {
            throw 'Error- Undifined';
        }
        
        for (num in arr) {
            arr[num] = +arr[num];
            if (isNaN(arr[num])) {
                throw 'not a number!';
            }
            sum += arr[num];
        }
        return sum;
    
   
    

};