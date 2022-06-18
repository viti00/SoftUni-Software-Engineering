function getArticleGenerator(articles) {
    let arr = articles;

    function showNext() {
        if (arr.length > 0) {
            let newArticle = document.createElement('article');
            let divElement = document.getElementById('content');
            newArticle.textContent = arr.shift();

            divElement.appendChild(newArticle);
        }
    }

    return showNext
}
