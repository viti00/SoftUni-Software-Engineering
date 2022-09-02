import { showCommentPage } from "./commentPage.js";
export function createPost(post){
    let { postText, username, topicName, _id, date } = post;

        let divTopicContainer = document.createElement('div');
        divTopicContainer.classList.add('topic-container');
        divTopicContainer.dataset.id = _id;

        let divTopicNameWrapper = document.createElement('div');
        divTopicNameWrapper.classList.add('topic-name-wrapper');

        let divClassTopicName = document.createElement('div');
        divClassTopicName.classList.add('topic-name');

        let aElement = document.createElement('a');
        aElement.classList.add('normal');
        aElement.setAttribute('href', '/content');

        aElement.addEventListener('click', (e) => {
            e.preventDefault();
            showCommentPage(e, postText);
        });

        let h2Element = document.createElement('h2');
        h2Element.textContent = topicName;

        aElement.appendChild(h2Element);

        let divClassColumns = document.createElement('div');
        divClassColumns.classList.add('columns')

        let divElement = document.createElement('div');

        let pElement = document.createElement('p');
        pElement.textContent = 'Date: ';

        let timeElement = document.createElement('time');
        timeElement.textContent = date;
        pElement.appendChild(timeElement);

        let divClassNickName = document.createElement('div');
        divClassNickName.classList.add('nick-name');

        let pUsernameElement = document.createElement('p');
        pUsernameElement.textContent = "Username: ";
        let spanElement = document.createElement('span');
        spanElement.textContent = username;
        pUsernameElement.appendChild(spanElement);
        divClassNickName.appendChild(pUsernameElement);

        divElement.appendChild(pElement);
        divElement.appendChild(divClassNickName);

        divClassColumns.appendChild(divElement);

        divClassTopicName.appendChild(aElement);
        divClassTopicName.appendChild(divClassColumns);

        divTopicNameWrapper.appendChild(divClassTopicName);
        divTopicContainer.appendChild(divTopicNameWrapper);

        return divTopicContainer;
}