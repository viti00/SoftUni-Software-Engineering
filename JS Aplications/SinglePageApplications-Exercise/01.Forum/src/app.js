
import { postComment } from "./postComment.js";
import { showAllTopics } from "./showAllTopics.js";
import { cancel } from "./cancel.js";

let divClassTopicTitle = document.querySelector('.topic-title');

export function solve() {
    debugger;
    Array.from(divClassTopicTitle.querySelectorAll('.topic-container')).forEach(el => el.remove());
    let postBtn = document.querySelector(".public");
    let cancelBtn = document.querySelector('.cancel');

    let sectionThemeContent = document.getElementById('theme-content-page');
    sectionThemeContent.style.display = 'none';

    postBtn.addEventListener('click', postComment);
    cancelBtn.addEventListener('click', cancel);

    showAllTopics();

}
