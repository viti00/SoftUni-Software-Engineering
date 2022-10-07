import { html } from "../../node_modules/lit-html/lit-html.js";

export const allMemesTemplate = (data) => html`
    <section id="meme-feed">
        <h1>All Memes</h1>
        <div id="memes">
           ${data.length > 0 ? html`
            ${data.map(m=> memeTemplate(m))}
           `: html`<p class="no-memes">No memes in database.</p>`}
        </div>
    </section>
`;


const memeTemplate = (m) => html`
    <div class="meme">
        <div class="card">
            <div class="info">
                <p class="meme-title">${m.title}</p>
                <img class="meme-image" alt="meme-img" src="${m.imageUrl}">
            </div>
            <div id="data-buttons">
                <a class="button" href="/details/${m._id}">Details</a>
            </div>
        </div>
    </div>
`;