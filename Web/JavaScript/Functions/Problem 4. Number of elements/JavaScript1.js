var body = window.body;
function numOfDivs(body) {
    var count;
    count = document.getElementsByTagName('div').length;
    return count;
}

console.log(numOfDivs(body));