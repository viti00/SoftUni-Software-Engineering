let divClassTopicTitle = document.querySelector('.topic-title');

import { createPost } from "./createPost.js";

export async function showAllTopics() {
    let response = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts');
    let posts = await response.json();
    for (const key in posts) {
        let post = createPost(posts[key]);
        divClassTopicTitle.appendChild(post);
    }
}