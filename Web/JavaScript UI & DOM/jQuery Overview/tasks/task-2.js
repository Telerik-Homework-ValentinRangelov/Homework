/// <reference path="..\node_modules\jquery\dist\jquery.js" />

/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function (selector) {
        var allButtonElements = $('.button'),
            allContentElements = $('.content'),
            topMostContentElement,
            theSelector;

        if (selector === undefined || selector === null) {
            throw Error('');
        }
        if (typeof selector === 'string') {
            theSelector = $(selector);
        } else {
            theSelector = selector;
        }
        if (theSelector.length < 1) {
            throw new Error('');
        }
        $('.button').text('hide');
        //console.log(allContentElements);
        $('#root').on('click', '.button', function (ev) {
            if (ev.target.className === 'button') {
                var target = ev.target;
                var next = target;

                while (next) {
                    if (next.className === 'content') {
                        break;
                    }
                    next = next.nextElementSibling;
                }
                if (next.style.display === '') {
                    target.innerHTML = 'show';
                    next.style.display = 'none';
                } else if (next.style.display === 'none') {
                    target.innerHTML = 'hide';
                    next.style.display = '';
                }
            }
        });



    };
};

module.exports = solve;