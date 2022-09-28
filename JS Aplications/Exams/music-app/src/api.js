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

export async function getAlbums() {
    let res = "";


    res = await fetch(`${baseUrl}/data/albums?sortBy=_createdOn%20desc&distinct=name`);


    let result = await res.json();

    return result;
}

export async function createAlbum(data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/albums`, {
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

export async function getAlbumById(albumId) {
    const res = await fetch(`${baseUrl}/data/albums/${albumId}`);

    const result = await res.json();

    return result;
}

export async function editAlbumById(albumId, data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/albums/${albumId}`, {
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
        let response = await fetch(`${baseUrl}/data/albums/${id}`, {
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

export async function getSearch(query) {
    const res = await fetch(`${baseUrl}/data/albums?where=name%20LIKE%20%22${query}%22`);

    const result = await res.json();

    return result;
}
