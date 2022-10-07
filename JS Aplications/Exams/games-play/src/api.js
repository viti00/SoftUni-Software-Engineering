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

export async function register(email, password) {
    try {
        let response = await fetch(`${baseUrl}/users/register`, {
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

export async function getLatestGames(){
    const res = await fetch(`${baseUrl}/data/games?sortBy=_createdOn%20desc&distinct=category`);

    const result = await res.json();

    return result;
}

export async function getGame(gameId) {
    const res = await fetch(`${baseUrl}/data/games/${gameId}`);

    const result = await res.json();

    return result;
}

export async function createGame(data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/games`, {
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

export async function editGame(gameId, data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/games/${gameId}`, {
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

export async function deleteFunc(id) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/games/${id}`, {
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

export async function getAllGames(){
    const res = await fetch(`${baseUrl}/data/games?sortBy=_createdOn%20desc`);

    const result = await res.json();

    return result;
}

export async function getComments(gameId){
    const res = await fetch(`${baseUrl}/data/comments?where=gameId%3D%22${gameId}%22`);

    const result = res.json();

    return result;
}

export async function createComment(data){
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/comments`, {
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