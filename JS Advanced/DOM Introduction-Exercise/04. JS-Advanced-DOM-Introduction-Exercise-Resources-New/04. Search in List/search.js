function search() {
   let listOfTowns = document.querySelectorAll('#towns li');

   let searcBoxText = document.getElementById('searchText').value;
   let counter = 0;
   for (const liElement of listOfTowns) {
      if(liElement.textContent.includes(searcBoxText)){
         counter++;
         liElement.style.textDecoration = 'underline';
         liElement.style.textDecoration = 'bold';
      }
      else{
         liElement.style.textDecoration = 'none';
      }
   }

   let divElement = document.getElementById('result');

   divElement.textContent = `${counter} matches found`
}
