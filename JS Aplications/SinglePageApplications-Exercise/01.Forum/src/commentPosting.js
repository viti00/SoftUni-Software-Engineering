let divTitle = document.querySelector('.theme-title');

import { createComment } from "./createComments.js";

export async function postNewComment(e, postId){
    let formData = new FormData(e.target);

    let commentator = formData.get('username');
    let comment = formData.get('postText');

    let date = new Date();
    let currDate = 
    `${date.getFullYear()}-${date.getMonth() + 1}-${date.getDate()}T${date.getHours()}:${date.getMinutes()}:${date.getSeconds()}`;

    let response = await fetch('http://localhost:3030/jsonstore/collections/myboard/comments', {
        method: 'post',
        headers: {
            'Content-Type': 'aplication/json'
        },
        body: JSON.stringify({
            name: commentator,
            postText: comment,
            date: currDate,
            postId: postId
        })
    })
    let result = await response.json();
    let newComment = createComment(result);
    divTitle.innerHTML += newComment;
}