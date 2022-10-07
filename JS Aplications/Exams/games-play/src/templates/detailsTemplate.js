import { html } from "../../node_modules/lit-html/lit-html.js";


export const detailsTemplate = (game, userId, comments, onSubmit) => html`
    <section id="game-details">
        <h1>Game Details</h1>
        <div class="info-section">
    
            <div class="game-header">
                <img class="game-img" src="${game.imageUrl}" />
                <h1>${game.title}</h1>
                <span class="levels">MaxLevel: ${game.maxLevel}</span>
                <p class="type">${game.category}</p>
            </div>
    
            <p class="text">
                ${game.summary}
            </p>
    
            <div class="details-comments">
                <h2>Comments:</h2>
                ${comments.length > 0 ? html`
                <ul>
                    ${comments.map(c => commentTemplate(c))}
                </ul>
                ` : html`<p class="no-comment">No comments.</p>`}                
            </div>
    
            ${userId === game._ownerId ? html`
            <div class="buttons">
                <a href="/edit/${game._id}" class="button">Edit</a>
                <a href="/delete/${game._id}" class="button">Delete</a>
            </div>
            `: null}
        </div>
    
        <!-- Bonus -->
        <!-- Add Comment ( Only for logged-in users, which is not creators of the current game ) -->
        ${userId != null && userId != game._ownerId ? html`
        <article class="create-comment">
            <label>Add new comment:</label>
            <form @submit=${onSubmit} class="form">
                <textarea name="comment" placeholder="Comment......"></textarea>
                <input class="btn submit" type="submit" value="Add Comment">
            </form>
        </article>
        ` : null}

    </section>
`;


const commentTemplate = (c) => html`
    <li class="comment">
        <p>Content: ${c.comment}</p>
    </li>
`;