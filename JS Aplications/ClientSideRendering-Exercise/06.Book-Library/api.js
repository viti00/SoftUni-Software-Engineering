const url = 'http://localhost:3030/jsonstore/collections/books';

export async function getBooks(){
    let response = await fetch(url);

    let result = await response.json();

    return result;
}

export async function editBookFunc(title, author, id){
    let response = await fetch(`${url}/${id}`, {
        method: 'put',
        headers: {
            'Content-Type':'aplication/json'
        },
        body: JSON.stringify({
            "title": title,
            "author": author
        })
    });
}

export async function add(title, author){
    let response = await fetch(url, {
        method: 'post',
        headers: {
            'Content-Type':'aplication/json'
        },
        body: JSON.stringify({
            "title": title,
            "author": author
        })
    });
}

export async function deleteFunc(id) {
    let response = await fetch(`${url}/${id}`, {
        method: 'delete'
    })
}