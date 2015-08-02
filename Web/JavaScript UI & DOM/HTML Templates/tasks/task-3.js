/// <reference path="..\node_modules\jquery\dist\jquery.js" />
/// <reference path="..\node_modules\handlebars\dist\handlebars.js" />


function solve() {
  return function(){
    $.fn.listview = function(data){
        var templateHolder = this.attr('data-template'),
            template = $('#' + templateHolder).html(),
            compiledHTML = handlebars.compile(template),
            i,
            len;

        for (i = 0, len = data.length; i < len; i += 1) {
            this.append(compiledHTML(data[i]));
        }
    };
  };
}

module.exports = solve;
