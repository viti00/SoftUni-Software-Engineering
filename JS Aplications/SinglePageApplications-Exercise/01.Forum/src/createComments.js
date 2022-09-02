
export function createComment(comment) {
    let {name, postText, date, _id} = comment;

    let divUserComment = document.createElement('div');
    divUserComment.dataset.id = _id;

    divUserComment.innerHTML = `<div class="topic-name-wrapper">
        <div class="topic-name">
            <p><strong>${name}</strong> commented on <time>${date}</time></p>
            <div class="post-content">
                <p>${postText}</p>
            </div>
        </div>
    </div>`;

    return divUserComment;s
}