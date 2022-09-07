import { html } from "../../../node_modules/lit-html/lit-html.js";

export function updateNavigation() {
    const user = JSON.parse(sessionStorage.getItem('user'));

    if (user) {
        document.querySelectorAll('#guest').forEach(el => el.style.display = 'none');
        document.querySelectorAll('#user').forEach(el => el.style.display = 'inline-block');
    } else {
        document.querySelectorAll('#guest').forEach(el => el.style.display = 'inline-block');
        document.querySelectorAll('#user').forEach(el => el.style.display = 'none');
    }
}

export function changeActiveClass(element) {

    document.querySelectorAll('nav a').forEach(el => el.classList.remove('active'));

    element.classList.add('active');
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

export function validateFunction(e) {
    e.currentTarget.querySelectorAll('.form-control').forEach(el => el.classList.remove('is-valid'));
    e.currentTarget.querySelectorAll('.form-control').forEach(el => el.classList.remove('is-invalid'));

    let make = e.currentTarget.querySelector('#new-make');

    if (make.value.length >= 4) {

        make.classList.add('is-valid')
    }
    else {
        make.classList.add('is-invalid')
    }

    let model = e.currentTarget.querySelector('#new-model');

    if (model.value.length >= 4) {
        model.classList.add('is-valid')
    }
    else {
        model.classList.add('is-invalid')
    }

    let year = e.currentTarget.querySelector('#new-year');
    if (Number(year.value) >= 1950 && Number(year.value) <= 2050) {
        year.classList.add('is-valid')
    }
    else {
        year.classList.add('is-invalid');
    }

    let description = e.currentTarget.querySelector('#new-description');
    if (description.value.length > 10) {
        description.classList.add('is-valid');
    }
    else {
        description.classList.add('is-invalid');
    }

    let price = e.currentTarget.querySelector('#new-price');
    if (Number(price.value) > 0) {
        price.classList.add('is-valid');
    }
    else {
        price.classList.add('is-invalid');
    }

    let img = e.currentTarget.querySelector('#new-image');
    if (img.value.length > 0) {
        img.classList.add('is-valid');
    }
    else {
        img.classList.add('is-invalid');
    }

    let material = e.currentTarget.querySelector('#new-material');
    material.classList.add('is-valid');

    let dataIsValid = true;

    e.currentTarget.querySelectorAll('.form-control').forEach(el => {
        if (!el.classList.contains('is-valid')) {
            dataIsValid = false;
        }
    });

    const data = {
        make: make.value,
        model: model.value,
        year: Number(year.value),
        description: description.value,
        price: Number(price.value),
        img: img.value,
        material: material.value
    };
    return {
        dataIsValid,
        data
    };
}

export const spinner = () => html`<h1>Loading &hellip;</h1>`;