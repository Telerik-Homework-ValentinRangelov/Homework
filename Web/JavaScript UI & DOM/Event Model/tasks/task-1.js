/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  If an id is provided, select the element
  Finds all elements with class button or content within the provided element
    Change the content of all .button elements with "hide"
  When a .button is clicked:
    Find the topmost .content element, that is before another .button and:
      If the .content is visible:
        Hide the .content
        Change the content of the .button to "show"
      If the .content is hidden:
        Show the .content
        Change the content of the .button to "hide"
      If there isn't a .content element after the clicked .button and before other .button, do nothing
  Throws if:
  The provided DOM element is non-existant
  The id is either not a string or does not select any DOM element

*/

function solve(){
  return function (selector) {
    var element,
    classButton,
    classContent,
    buttonElement,
    addListenerHere;
    if(typeof selector !== 'string' && !(selector instanceof HTMLElement)){
      throw new Error('Invalid selector');
    }
    if(typeof selector === 'string'){
      element = document.getElementById(selector);
      if(typeof element ==='undefined' || element === null){
        throw new Error('Element is undefined or null');
      }
    }else{
      element = selector;
    }
    classContent = document.querySelectorAll('.content'); 
    classButton = document.querySelectorAll('.button');
    if(classButton.length < 1){
      return;
    }
    
    for(buttonElement in classButton){
      classButton[buttonElement].innerHTML = 'hide';
      
    }
    
    
      
    
    addListenerHere = document.getElementById('root');
    addListenerHere.addEventListener('click',theFunction,false);
    function theFunction(ev){
      if(ev.target.className ==='button'){
        var target = ev.target;
        var next = target;
      
      while(next){
        if(next.className === 'content'){
          break;
        }
        next = next.nextElementSibling;
      }
      if(next.style.display === ''){
        target.innerHTML = 'show';
        next.style.display = 'none';
      }else if(next.style.display === 'none'){
        target.innerHTML = 'hide';
        next.style.display = '';
      }
    }
    }
    
  };
};

module.exports = solve;