function searchWord(text, word, casing) {
    if (casing === "insensitive") {
        word = word.toLowerCase();
        text = text.toLowerCase();
    }
    var numerOfOccurrences = 0;
    for (var i = 0; i < text.length; i++) {
        if (text[i] === word[0]) {
            var equal = false;
            for (var j = 0; j < word.length; j++) {
                if (text[i + j] === word[j])
                    equal = true;
                else {
                    equal = false;
                    break;
                }
            }
            if (equal)
                numerOfOccurrences++;
        }
    }
    return numerOfOccurrences;
}