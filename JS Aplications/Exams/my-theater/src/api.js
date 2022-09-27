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


export async function getAllTheaters(){
    const res = await fetch(`${baseUrl}/data/theaters?sortBy=_createdOn%20desc&distinct=title`);

    const result = res.json();

    return result;
}

export async function createTheater(data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/theaters`, {
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

export async function getTheater(tId){
    const res = await fetch(`${baseUrl}/data/theaters/${tId}`);

    const result = await res.json();

    return result;
}

export async function editTheater(tId, data) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/theaters/${tId}`, {
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
        let response = await fetch(`${baseUrl}/data/theaters/${id}`, {
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

export async function getMyTheaters(userId){
    const res = await fetch(`${baseUrl}/data/theaters?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);

    const result = await res.json();

    return result;
}

export async function addLike(theaterId) {
    let token = getToken();
    try {
        let response = await fetch(`${baseUrl}/data/likes`, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': token

            },
            body: JSON.stringify({
                theaterId
            })
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

export async function getTotalLikes(tId) {
    const res = await fetch(`${baseUrl}/data/likes?where=theaterId%3D%22${tId}%22&distinct=_ownerId&count`);

    const result = await res.json();

    return result;
}

export async function getLikeForUser(tId, userId) {
    if (userId != null) {
        const res = await fetch(`${baseUrl}/data/likes?where=theaterId%3D%22${tId}%22%20and%20_ownerId%3D%22${userId}%22&count`);

        const result = await res.json();

        return result > 0;
    }
}