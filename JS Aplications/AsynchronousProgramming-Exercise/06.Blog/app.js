function attachEvents() {
    let baseUrl = 'http://localhost:3030/jsonstore/blog';
    let postsElement = document.getElementById('posts');
    let loadBtnElement = document.getElementById('btnLoadPosts');
    let btnViewElement = document.getElementById('btnViewPost');
    let postCommentsElement = document.getElementById('post-comments');


    loadBtnElement.addEventListener('click', getPosts);
    btnViewElement.addEventListener('click', getCommnets);
    

    function getCommnets(){
        let option = document.getElementById('posts');

        fetch(`${baseUrl}/comments`)
            .then(response => response.json())
            .then(commnets => {
                
                let commentsForCurrPost = [];

                for (const key in commnets) {
                    if(commnets[key].postId == option.value){
                        commentsForCurrPost.push(commnets[key]);
                    }
                }

                return fetch(`${baseUrl}/posts`)
                    .then(response => response.json())
                    .then(posts => ({commentsForCurrPost, posts}))
            })
            .then(({commentsForCurrPost, posts})=> {

                let post = {};
                for (const key in posts) {
                    if(posts[key].id == option.value){
                        post = posts[key];
                        break;
                    }
                }
                postCommentsElement.innerHTML = '';
                let comments = createComments(commentsForCurrPost, post);

                for (const comment of comments) {
                    postCommentsElement.appendChild(comment);
                }
            })
            .catch(err=>{

            })
    }

    function getPosts(){
        fetch(`${baseUrl}/posts`)
        .then(response => response.json())
        .then(posts => {
            for (const key in posts) {
                let {title} = posts[key];

                let post = createPost(key, title);

                postsElement.appendChild(post);
            }
        })
        .catch(err=>{

        })
    }

    function createPost(key, title){
        let optionElement = document.createElement('option');
        optionElement.setAttribute('value', key);
        optionElement.textContent = title;

        return optionElement;
    }

    function createComments(commentsForCurrPost, post){
        let postTitle = document.getElementById('post-title');
        postTitle.textContent = post.title;

        let postBodyElement = document.getElementById('post-body');
        postBodyElement.textContent = post.body;

        let liElements = [];
        for (const key in commentsForCurrPost) {
            let liElement = document.createElement('li');
            liElement.setAttribute('id', commentsForCurrPost[key].id);
            liElement.textContent = commentsForCurrPost[key].text;

            liElements.push(liElement);
        }

        return liElements;
    }
}


attachEvents();