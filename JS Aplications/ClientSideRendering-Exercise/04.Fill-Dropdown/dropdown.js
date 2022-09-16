import { html, render } from "../node_modules/lit-html/lit-html.js";
import { getOption, postOption } from "./api.js";

const select = document.getElementById('menu');
const form = document.querySelector('form');

form.addEventListener('submit', addItem);

const optionTemplate = (data) => data.map(o => o = html`<option value="${o[1]._id}">${o[1].text}</option>`);

async function loadAllOptions() {
    let options = await getOption();
    const result = optionTemplate(Object.entries(options));

    render(result, select);
}

async function addItem(e) {
    e.preventDefault();

    const text = form.querySelector('#itemText');

    if (text.value.length > 0) {
        await postOption(text.value);
        form.reset();
        loadAllOptions();
    }
}


loadAllOptions();