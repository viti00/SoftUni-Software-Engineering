import { html } from "../../node_modules/lit-html/lit-html.js";

export const homeTemplate = (data) => html`
            <section id="welcome-world">

<div class="welcome-message">
    <h2>ALL new games are</h2>
    <h3>Only in GamesPlay</h3>
</div>
<img src="./images/four_slider_img01.png" alt="hero">

<div id="home-page">
    <h1>Latest Games</h1>
    ${data.length > 0 ? html`
        ${data.map(c=> gameCardTemplate(c))}
    `: noDataTemplate()}    
</div>
</section>
`;

const gameCardTemplate = (c) => html`
    <div class="game">
        <div class="image-wrap">
            <img src="${c.imageUrl}">
        </div>
        <h3>${c.title}</h3>
        <div class="rating">
            <span>☆</span><span>☆</span><span>☆</span><span>☆</span><span>☆</span>
        </div>
        <div class="data-buttons">
            <a href="/details/${c._id}" class="btn details-btn">Details</a>
        </div>
    </div>
`;

const noDataTemplate = () => html`
    <p class="no-articles">No games yet</p>
`;