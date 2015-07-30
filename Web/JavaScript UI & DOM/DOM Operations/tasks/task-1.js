/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
      var docFragment = document.createDocumentFragment(),
          editingElement,
          div,
          content,
          currentElement;
      
      if(!Array.isArray(contents)){
        throw new Error('Contents is not an array');
      }    
      for(content in contents){
        if(typeof contents[content]!=='string' && typeof contents[content]!=='number'){
          throw new Error('Wrong content in contents');
        }
      }     
      
      if(typeof element !== 'string' && !(element instanceof HTMLElement)){
        throw new Error('Element must be string or element from the html!');
      }
      
      if(typeof element === 'string'){
        editingElement = document.getElementById(element);
        if(typeof element === 'undefined' || element === null){
          throw new Error('Element is null or undefined, it does not exists!');
        }
      }else{
        editingElement = element;
      }
      
      editingElement.innerHTML = '';
      
      div = document.createElement('div');
      
      for (content in contents){
       currentElement = div.cloneNode(true);
       currentElement.innerText = contents[content];
       docFragment.appendChild(currentElement);
      }
      
      editingElement.appendChild(docFragment);
  };
};