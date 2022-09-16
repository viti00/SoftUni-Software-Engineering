
const url = 'http://localhost:3030/jsonstore/advanced/dropdown';

export async function getOption(){
    let response = await fetch(url);
    let result = await response.json();

    return result;
}

export async function postOption(text){
    let response = await fetch(url, {
        method: 'post',
        headers: {
            'Content-Type': 'aplication/json'
        },
        body: JSON.stringify({text})
    });
}