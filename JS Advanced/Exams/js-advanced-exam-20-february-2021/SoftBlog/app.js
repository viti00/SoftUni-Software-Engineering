function solve(){
   debugger;
      let createButton = document.getElementsByClassName('btn create')[0];
      let sections = document.querySelectorAll('section');

      let archiveElements = [];

      createButton.addEventListener('click', createPost);

      function createPost(e){
         debugger;
         e.preventDefault();

         let newArticle = document.createElement('article');

         let author = document.getElementById('creator');

         let title = document.getElementById('title');

         let category = document.getElementById('category');

         let content = document.getElementById('content');

         let newH1Element = document.createElement('h1');
         newH1Element.textContent = title.value;

         let firstPElement = document.createElement('p');
         firstPElement.textContent = 'Category:'
         let newStrongElement = document.createElement('strong');
         newStrongElement.textContent = category.value;
         firstPElement.appendChild(newStrongElement);

         let secondPElement = document.createElement('p');
         secondPElement.textContent = 'Creator:'
         let newStrongElementSecondP = document.createElement('strong');
         newStrongElementSecondP.textContent = author.value;
         secondPElement.appendChild(newStrongElementSecondP);

         let thirdPElement = document.createElement('p');
         thirdPElement.textContent = content.value;

         let newDivElement = document.createElement('div');
         newDivElement.setAttribute('class', 'buttons');

         let deleteButton = document.createElement('button');
         deleteButton.setAttribute('class', 'btn delete');
         deleteButton.textContent = 'Delete';

         let archiveButton = document.createElement('button');
         archiveButton.setAttribute('class', 'btn archive');
         archiveButton.textContent = 'Archive';

         newDivElement.appendChild(deleteButton);
         newDivElement.appendChild(archiveButton);

         newArticle.appendChild(newH1Element);
         newArticle.appendChild(firstPElement);
         newArticle.appendChild(secondPElement);
         newArticle.appendChild(thirdPElement);
         newArticle.appendChild(newDivElement);

         sections[1].appendChild(newArticle);

         archiveButton.addEventListener('click', archivePosts);

         deleteButton.addEventListener('click', deletePosts);

         function archivePosts(){
            debugger;
            let articleElement = archiveButton.parentNode.parentNode;

            let olElement = sections[3].children[1];

            let newLiElement = document.createElement('li');
            newLiElement.textContent = articleElement.children[0].textContent;

            archiveElements.push(newLiElement);

            archiveElements.sort((a,b) => a.textContent.localeCompare(b.textContent));

            for (const element of archiveElements) {
               olElement.appendChild(element); 
            }

            sections[1].removeChild(articleElement);
         }

         function deletePosts(){
            let articleElement = archiveButton.parentNode.parentNode;
            sections[1].removeChild(articleElement);
         }
      }
  }
