import { html } from "../../node_modules/lit-html/lit-html.js";


export const detailsTemplate = (meme, userId, onDelete) => html`
    <section id="meme-details">
        <h1>Meme Title: ${meme.title}</h1>
        <div class="meme-details">
            <div class="meme-img">
                <img alt="meme-alt" src="${meme.imageUrl}">
            </div>
            <div class="meme-description">
                <h2>Meme Description</h2>
                <p>
                    ${meme.description}
                </p>
                ${userId == meme._ownerId ? html`
                <a class="button warning" href="/edit/${meme._id}">Edit</a>
                <button @click=${onDelete} data-id="${meme._id}" class="button danger">Delete</button>
                `: null}
    
            </div>
        </div>
    </section>
`;