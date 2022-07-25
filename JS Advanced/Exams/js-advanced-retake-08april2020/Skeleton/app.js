function solve() {
    let addButn = document.getElementById('add');

    addButn.addEventListener('click', add);

    function add(e) {
        e.preventDefault();

        let taskElement = document.getElementById('task');

        let descriptionElement = document.getElementById('description');

        let dateElement = document.getElementById('date');

        let divElement = document.querySelectorAll('section')[1].children[1];

        let newArticle = document.createElement('article');

        let h3Element = document.createElement('h3');
        h3Element.textContent = taskElement.value;

        let pDescriptionElement = document.createElement('p');
        pDescriptionElement.textContent = `Description: ${descriptionElement.value}`;

        let pDudeDateElement = document.createElement('p');
        pDudeDateElement.textContent = `Due Date: ${dateElement.value}`;

        let newDivElement = document.createElement('div');
        newDivElement.setAttribute('class', 'flex');

        let startBtn = document.createElement('button');
        startBtn.setAttribute('class', 'green');
        startBtn.textContent = 'Start';

        let deleteBtn = document.createElement('button');
        deleteBtn.setAttribute('class', 'red');
        deleteBtn.textContent = 'Delete';

        newDivElement.appendChild(startBtn);
        newDivElement.appendChild(deleteBtn);

        newArticle.appendChild(h3Element);
        newArticle.appendChild(pDescriptionElement);
        newArticle.appendChild(pDudeDateElement);
        newArticle.appendChild(newDivElement);

        if (taskElement.value.length > 0 && descriptionElement.value.length > 0 && dateElement.value.length > 0) {
            divElement.appendChild(newArticle);

            taskElement.value = '';
            descriptionElement.value = '';
            dateElement.value = '';

            startBtn.addEventListener('click', start);
            deleteBtn.addEventListener('click', delFunc);

            function start(e) {
                let parentElement = e.target.parentNode.parentNode;

                let inProgresDiv = document.getElementById('in-progress');

                let inProgresArticleElement = document.createElement('article');

                let inProgresH3Element = document.createElement('h3');
                inProgresH3Element.textContent = parentElement.children[0].textContent;

                let inProgresPdescriptionElement = document.createElement('p');
                inProgresPdescriptionElement.textContent = parentElement.children[1].textContent;

                let inProgresPdudeDateElement = document.createElement('p');
                inProgresPdudeDateElement.textContent = parentElement.children[2].textContent;

                let inProgresDivElement = document.createElement('div');
                inProgresDivElement.setAttribute('class', 'flex');

                let finishBtn = document.createElement('button');
                finishBtn.setAttribute('class', 'orange');
                finishBtn.textContent = 'Finish';

                inProgresDivElement.appendChild(deleteBtn);
                inProgresDivElement.appendChild(finishBtn);

                inProgresArticleElement.appendChild(inProgresH3Element);
                inProgresArticleElement.appendChild(inProgresPdescriptionElement);
                inProgresArticleElement.appendChild(inProgresPdudeDateElement);
                inProgresArticleElement.appendChild(inProgresDivElement);

                inProgresDiv.appendChild(inProgresArticleElement);

                parentElement.remove();

                finishBtn.addEventListener('click', finish);

                function finish(e){
                    let parentArticle = e.target.parentNode.parentNode;

                    let completeDivElement = document.querySelectorAll('section')[3].children[1];

                    let completeArticleElement = document.createElement('article');

                    let completeH3Element = document.createElement('h3');
                    completeH3Element.textContent = parentArticle.children[0].textContent;

                    let completeDescriptionElement = document.createElement('p');
                    completeDescriptionElement.textContent = parentArticle.children[1].textContent;

                    let completeDueDateElement = document.createElement('p');
                    completeDueDateElement.textContent = parentArticle.children[2].textContent;

                    completeArticleElement.appendChild(completeH3Element);
                    completeArticleElement.appendChild(completeDescriptionElement);
                    completeArticleElement.appendChild(completeDueDateElement);

                    completeDivElement.appendChild(completeArticleElement);

                    parentArticle.remove();
                }
            }

            function delFunc(e){
                e.target.parentNode.parentNode.remove();
            }
        }

    }
}