let baseUrl = 'http://localhost:3030/jsonstore/collections/books';
let tbodyElement = document.getElementsByTagName('tbody')[0];
tbodyElement.querySelectorAll('tr').forEach(tr => tr.remove());
let formElement = document.getElementsByTagName('form')[0];

let idGlobal = '';

let submitBtn = formElement.getElementsByTagName('button')[0];


let loadBtn = document.getElementById('loadBooks');

loadBtn.addEventListener('click', loadBooks);

submitBtn.addEventListener('click', chooseMethod);


function createBook(book, id) {
    let { title, author } = book;

    let trElement = document.createElement('tr');
    trElement.dataset.id = id;

    let tdTitleElement = document.createElement('td');
    tdTitleElement.textContent = title;

    let tdAuthorElement = document.createElement('td');
    tdAuthorElement.textContent = author;

    let tdButtnosElement = document.createElement('td');

    let editBtn = document.createElement('button');
    editBtn.textContent = 'Edit';

    let deleteBtn = document.createElement('button');
    deleteBtn.textContent = 'Delete';

    editBtn.addEventListener('click', editBook);
    deleteBtn.addEventListener('click', deleteBook);

    tdButtnosElement.appendChild(editBtn);
    tdButtnosElement.appendChild(deleteBtn);

    trElement.appendChild(tdTitleElement);
    trElement.appendChild(tdAuthorElement);
    trElement.appendChild(tdButtnosElement);

    return trElement;
}

async function loadBooks() {
    debugger;
    tbodyElement.innerHTML = '';
    await fetch(baseUrl)
        .then(res => res.json())
        .then(books => {
            for (const key in books) {
                let book = createBook(books[key], key);

                tbodyElement.appendChild(book);
            }
        })
}

function chooseMethod(e) {
    e.preventDefault();
    let form = e.target.parentNode;
    let data = new FormData(form);

    let btn = formElement.getElementsByTagName('button')[0];


    if (btn.textContent == 'Save') {
        updateBook(data, idGlobal);
    }
    else if (btn.textContent == 'Submit') {
        submitBook(data);
    }
}


async function submitBook(data) {

    let title = data.get('title');
    let author = data.get('author');

    formElement.reset();

    if (title.length > 0 && author.length > 0) {
        let createResponse = await fetch(baseUrl, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify({
                title: title,
                author: author
            })
        })

        let createResult = await createResponse.json();
        let book = createBook(createResult, createResult._id);
        tbodyElement.appendChild(book);
    }
}

async function editBook(e) {
    let parent = e.target.parentNode.parentNode;

    let h3Elemet = formElement.getElementsByTagName('h3')[0];
    h3Elemet.textContent = 'Edit FORM'
    formElement.children[2].value = parent.children[0].textContent;
    formElement.children[4].value = parent.children[1].textContent;
    submitBtn.textContent = "Save";

    idGlobal = parent.getAttribute('data-id');
    parent.remove();
}

async function updateBook(data, id) {
    debugger;
    let editResponse = await fetch(`${baseUrl}/${id}`, {
        method: 'put',
        headers: {
            'Content-Type': 'aplication/json'
        },
        body: JSON.stringify({
            "title": data.get("title"),
            "author": data.get('author')
        })
    })
    let editResult = await editResponse.json();
    let editBook = createBook(editResult, editResult._id);
    tbodyElement.appendChild(editBook);

    formElement.reset();

    let h3Elemet = formElement.getElementsByTagName('h3')[0];
    h3Elemet.textContent = 'FORM'
    submitBtn.textContent = 'Submit';

}

async function deleteBook(e){
    let parent = e.target.parentNode.parentNode;

    let id = parent.getAttribute('data-id');

    parent.remove();

    await fetch(`${baseUrl}/${id}`, {
        method: 'delete'
    })
    
}
