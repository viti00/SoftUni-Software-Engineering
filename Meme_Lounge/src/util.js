const notification = document.querySelector('.notification');

export function updateNavigation() {
    const user = getUser();

    if (user) {
        const greetElement = document.querySelector('nav span');
        greetElement.textContent = `Welcome, ${user.email}`;
        document.querySelectorAll('.guest').forEach(el => el.style.display = 'none');
        document.querySelectorAll('.user').forEach(el => el.style.display = 'block');
    } else {
        document.querySelectorAll('.guest').forEach(el => el.style.display = 'block');
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

export function showNotification(message){
    notification.children[0].textContent = message;
    notification.style.display = 'block';
}

export function hideNotification(){
    notification.style.display = 'none';
}