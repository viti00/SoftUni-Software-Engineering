const url = 'http://localhost:3030/jsonstore/advanced/table';

export async function getStudents(){
    let response = await fetch(url);
    let result = await response.json();

    return result;
}