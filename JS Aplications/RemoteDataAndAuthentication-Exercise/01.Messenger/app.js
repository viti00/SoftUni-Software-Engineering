function attachEvents() {
    debugger;
    let baseUrl = 'http://localhost:3030/jsonstore/messenger';

    let textareaElement = document.getElementById('messages');
    textareaElement.value = '';

    let divControlsElement = document.getElementById('controls');

    let submitBtn = document.getElementById('submit');
    let refreshBtn = document.getElementById('refresh');

    submitBtn.addEventListener('click', post);
    refreshBtn.addEventListener('click', get);

    async function post() {

        let author = divControlsElement.children[1].value;
        let content = divControlsElement.children[4].value;

        await fetch(baseUrl, {
            method: "post",
            headers: {
                'Content-Type': "aplication/json"
            },
            body: JSON.stringify({
                author: author,
                content: content,
            })

        })

        divControlsElement.children[1].value = '';
        divControlsElement.children[4].value = '';
    }

    async function get() {
        await fetch(baseUrl)
            .then(response => response.json())
            .then(messages => {
                for (const key in messages) {
                    let { author, content } = messages[key];
                    textareaElement.value += `${author}: ${content}\n`;
                }
            })

        divControlsElement.children[1].value = '';
        divControlsElement.children[4].value = '';
    }

}

attachEvents();