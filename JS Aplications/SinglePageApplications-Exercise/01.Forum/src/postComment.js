let divClassTopicTitle = document.querySelector('.topic-title');


import { createPost } from "./createPost.js";

export async function postComment(e) {
    e.preventDefault();
    debugger;
    let form = e.target.parentNode.parentNode;

    let dataForm = new FormData(form);

    let title = dataForm.get('topicName');
    let username = dataForm.get('username');
    let comment = dataForm.get('postText');

    if (title.length > 0 && username.length > 0 && comment.length > 0) {
        let date = new Date();
        let currDate = `${date.getFullYear()}-${date.getMonth() + 1}-${date.getDate()}T${date.getHours()}:${date.getMinutes()}:${date.getSeconds()}`;
        form.reset();
        let createResponse = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts', {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify({
                topicName: title,
                username: username,
                postText: comment,
                date: currDate
            })
        })

        let createResult = await createResponse.json();
        let post = createPost(createResult);
        divClassTopicTitle.appendChild(post);

    }
}