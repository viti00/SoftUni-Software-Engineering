import { getUser } from "../util.js";

const guestLinks =  document.querySelectorAll('.guest');
const userLinks = document.querySelectorAll('.user');

export function updateNavigation(ctx, next){
    const user = getUser();
    if(user){
        guestLinks.forEach(el => el.style.display = 'none');
        userLinks.forEach(el => el.style.display = 'inline-block');
    }
    else {
        guestLinks.forEach(el => el.style.display = 'inline-block');
        userLinks.forEach(el => el.style.display = 'none');
    }

    next();
}