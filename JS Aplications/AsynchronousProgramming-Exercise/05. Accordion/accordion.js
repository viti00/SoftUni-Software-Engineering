function solution() {
    let baseUrl = 'http://localhost:3030/jsonstore/advanced/articles';
    let sectionElement = document.getElementById('main');

    fetch(`${baseUrl}/list`)
        .then(response => {
            return response.json();
        })
        .then(articles => {
            for (const article of articles) {
                let { _id, title } = article;

                let divAccordionElement = createArticle(_id, title);

                sectionElement.appendChild(divAccordionElement);
            }
        })
        .catch(err=> {

        })


    function createArticle(id, title) {
        let divAccordionElement = document.createElement('div');
        divAccordionElement.setAttribute('class', 'accordion');

        let divHeadElement = document.createElement('div');
        divHeadElement.setAttribute('class', 'head');

        let spanTitleElement = document.createElement('span');
        spanTitleElement.textContent = title;

        let buttonElement = document.createElement("button");
        buttonElement.setAttribute('class', 'button');
        buttonElement.setAttribute('id', id);
        buttonElement.textContent = 'More';

        divHeadElement.appendChild(spanTitleElement);
        divHeadElement.appendChild(buttonElement);

        divAccordionElement.appendChild(divHeadElement);

        buttonElement.addEventListener('click', showHideFunction)

        return divAccordionElement;
    }

    function showHideFunction(e) {

        let id = e.target.getAttribute("id");
        let divAccordion = e.target.parentNode.parentNode;

        fetch(`${baseUrl}/details/${id}`)
            .then(response => response.json())
            .then(data => {
                let { content } = data;
                let extraInfo = createExtraInfo(content);
                debugger;

                if (e.target.textContent == "More") {
                    divAccordion.appendChild(extraInfo);
                    extraInfo.classList.remove('extra');

                    e.target.textContent = 'Less';
                }
                else if (e.target.textContent == 'Less') {
                    
                    let elementToDelete = e.target.parentNode.nextSibling;
                    elementToDelete.remove();

                    e.target.textContent = 'More';
                }

            })
            .catch(err=> {
                
            })
    }

    function createExtraInfo(content) {
        let divExtraElement = document.createElement('div');
        divExtraElement.setAttribute('class', "extra");

        let pElement = document.createElement('p');
        pElement.textContent = content;

        divExtraElement.appendChild(pElement);

        return divExtraElement;
    }
}

solution();