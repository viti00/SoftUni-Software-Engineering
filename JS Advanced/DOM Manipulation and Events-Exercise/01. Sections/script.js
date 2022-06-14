function create(words) {

   let divElement = document.getElementById('content');
   for (const word of words) {
      let newDiv = document.createElement('div');
      newDiv.setAttribute('class', 'content div');

      let newPElement = document.createElement('p');
      newPElement.textContent = word;
      newPElement.setAttribute('class', 'content div p');
      newPElement.style.display = 'none';

      newDiv.appendChild(newPElement);

      newDiv.addEventListener('click', (e) => {
         e.target.childNodes[0].style.display = 'block';
      });

      divElement.appendChild(newDiv);
   }
}