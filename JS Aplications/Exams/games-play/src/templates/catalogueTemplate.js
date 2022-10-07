import { html } from "../../node_modules/lit-html/lit-html.js";



export const catalogueTemplate = (data) => html`
    <section id="catalog-page">
        <h1>All Games</h1>
        ${data.length > 0 ? html`
            ${data.map(c=> gameCardTemplate(c))}
        `: noDataTemplate()}
    </section>
`;

const gameCardTemplate = (c) => html`
    <div class="allGames">
        <div class="allGames-info">
            <img src="${c.imageUrl}">
            <h6>${c.category}</h6>
            <h2>${c.title}</h2>
            <a href="/details/${c._id}" class="details-button">Details</a>
        </div>
    
    </div>
`;

const noDataTemplate = () => html`
    <h3 class="no-articles">No articles yet</h3>
`;