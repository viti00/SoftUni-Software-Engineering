import { getToken, getUserId } from "./util.js";

const baseUrl = 'http://localhost:3030';

export async function getAll(){
    let res = await fetch(`${baseUrl}/data/catalog`);
    let result = await res.json();

    return result;
}

export async function login(email, password) {
    try {
        let response = await fetch(`${baseUrl}/users/login`,{
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify({email, password})
        });
        if(!response.ok){
            const error = await response.json();
            throw new Error(error.message);
        }

        let user = await response.json();
        sessionStorage.setItem('user', JSON.stringify(user));
    } catch (error) {
        alert(error.message);
        throw error;
    }
}

export async function logout(){
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/users/logout`, {
            method: 'get',
            headers: {
                'Content-Type':'aplication/json',
                'X-Authorization': token
            }
        });
        if(!response.ok){
            const error = await response.json();
            throw new Error(error.message);
        }
        sessionStorage.removeItem('user');
       
    } catch (error) {
        alert(error.message);
        throw error;
    }

}

export async function register(email, password){
    try {
        let response = await fetch(`${baseUrl}/users/register`, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify({ email, password })
        });
        if(!response.ok){
            const error = await response.json();
            throw new Error(error.message);
        }

        let user = await response.json();
        sessionStorage.setItem('user', JSON.stringify(user));
    } catch (error) {
        alert(error.message);
        throw error;
    }
}

export async function create(data){
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/catalog`,{
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': token

            },
            body: JSON.stringify(data)
        });
        if(!response.ok){
            const error = await response.json();
            throw new Error(error.message);
        }
    } catch (error) {
        alert(error.message);
        throw error;
    }
}

export async function get(){
    let userId = getUserId();
    let res = await fetch(`${baseUrl}/data/catalog?where=_ownerId%3D%22${userId}%22`);
    let result = await res.json();

    return result;
}

export async function getFurniture(id){
    let res = await fetch(`${baseUrl}/data/catalog/${id}`);
    let result = await res.json();

    return result;
}

export async function editFurniture(id, data){
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/catalog/${id}`,{
            method: 'put',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': token

            },
            body: JSON.stringify(data)
        });
        if(!response.ok){
            const error = await response.json();
            throw new Error(error.message);
        }
    } catch (error) {
        alert(error.message);
        throw error;
    }
}

export async function deleteFunc(id){
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/catalog/${id}`,{
            method: 'delete',
            headers:{
                'Content-Type':'aplication/json',
                'X-Authorization': token
            }
        });
        if(!response.ok){
            const error = await response.json();
            throw new Error(error.message);
        }
    } catch (error) {
        alert(error.message);
        throw error;
    }

}
