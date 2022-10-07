import { getToken } from "./util.js";


const baseUrl = 'http://localhost:3030';


export async function login(email, password) {
    try {
        let response = await fetch(`${baseUrl}/users/login`, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify({ email, password })
        });
        if (!response.ok) {
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

export async function logout() {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/users/logout`, {
            method: 'get',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': token
            }
        });
        if (!response.ok) {
            const error = await response.json();
            throw new Error(error.message);
        }
        sessionStorage.removeItem('user');

    } catch (error) {
        alert(error.message);
        throw error;
    }

}

export async function register(data) {
    try {
        let response = await fetch(`${baseUrl}/users/register`, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify(data)
        });
        if (!response.ok) {
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

export async function getAllMemes(){
    const res = await fetch(`${baseUrl}/data/memes?sortBy=_createdOn%20desc`);

    const result = res.json();

    return result;
}

export async function createMeme(data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/memes`, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': token

            },
            body: JSON.stringify(data)
        });
        if (!response.ok) {
            const error = await response.json();
            throw new Error(error.message);
        }
    } catch (error) {
        alert(error.message);
        throw error;
    }
}

export async function getMyMemes(userId){
    const res = await fetch(`${baseUrl}/data/memes?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);

    const result = await res.json();

    return result;
}

export async function getMeme(memeId){
    const res = await fetch(`${baseUrl}/data/memes/${memeId}`);

    const result = await res.json();

    return result;
}

export async function deleteFunc(id) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/memes/${id}`, {
            method: 'delete',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': token
            }
        });
        if (!response.ok) {
            const error = await response.json();
            throw new Error(error.message);
        }

        return await response.json();
    } catch (error) {
        alert(error.message);
        throw error;
    }

}

export async function editMeme(memeId, data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/memes/${memeId}`, {
            method: 'put',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': token

            },
            body: JSON.stringify(data)
        });
        if (!response.ok) {
            const error = await response.json();
            throw new Error(error.message);
        }
    } catch (error) {
        alert(error.message);
        throw error;
    }
}