let sectionHome = document.getElementById('home-page');
let sectionComment = document.getElementById('theme-content-page');
let divTitle = document.querySelector('.theme-title');

import { postNewComment } from "./commentPosting.js";

export function showCommentPage(e, postText){
    sectionHome.style.display = 'none';
    sectionComment.style.display = 'block';

    let parent = e.target.parentNode.parentNode.parentNode.parentNode;
    let id = parent.getAttribute('id');

    let divClassColumns = parent.children[0].children[0].children[1];

    let postedOn = divClassColumns.children[0].children[0].textContent.substring(5);

    let userName =  divClassColumns.children[0].children[1].textContent.substring(9);

    divTitle.innerHTML = `
    <div class="theme-name-wrapper">
        <div class="theme-name">
            <h2>${e.target.textContent}</h2>
        </div>
        </div>
        <div class='comment'>
            <div class="header">
                <img src ="./static/profile.png" alt='avatar'>
                <p><span>${userName}</span> posted on <time>${postedOn}</time></p>
                <p class='post-content'>${postText}</p>
            </div>
        </div>`;

        let form = document.getElementById('create-comment');

        form.addEventListener('submit', (e) => {
            e.preventDefault();
            postNewComment(e, id);
        });
}