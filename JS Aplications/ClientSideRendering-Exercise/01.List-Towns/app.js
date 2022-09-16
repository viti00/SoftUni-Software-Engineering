import { html, render } from "../node_modules/lit-html/lit-html.js";

const form = document.querySelector('form');

const root = document.getElementById('root');


const townTemplate = (data) => html`
<ul>
    ${data.map(t => t = html`<li>${t}</li>`)}
</ul>
`

form.addEventListener('submit', (e) => {
    e.preventDefault();
    debugger;
    const formData = new FormData(form);

    if (formData.get('towns').length > 0) {
        const towns = formData.get('towns').split(', ');
        const result = townTemplate(towns);
        render(result, root);

        form.reset();
    }
})