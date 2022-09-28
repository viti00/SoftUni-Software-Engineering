export function updateNavigation() {
    const user = getUser();

    if (user) {
        document.querySelectorAll('.guest').forEach(el => el.style.display = 'none');
        document.querySelectorAll('.user').forEach(el => el.style.display = 'inline-block');
    } else {
        document.querySelectorAll('.guest').forEach(el => el.style.display = 'inline-block');
        document.querySelectorAll('.user').forEach(el => el.style.display = 'none');
    }
}

export function getUser (){
    let user = JSON.parse(sessionStorage.getItem('user'));
    return user;
}
export function getToken() {
    let user = JSON.parse(sessionStorage.getItem('user'));
    return user !== null ? user.accessToken : user;
}

export function getUserId() {
    let user = JSON.parse(sessionStorage.getItem('user'));
    return user !== null ? user._id : user;
}