import { html } from "../../node_modules/lit-html/lit-html.js";


export const myProfileTemplate = (data, user) => html`
    <section id="user-profile-page" class="user-profile">
        <article class="user-info">
            <img id="user-avatar-url" alt="user-profile" src="/images/female.png">
            <div class="user-content">
                <p>Username: ${user.username}</p>
                <p>Email: ${user.email}</p>
                <p>My memes count: ${data.length}</p>
            </div>
        </article>
        <h1 id="user-listings-title">User Memes</h1>
        <div class="user-meme-listings">
            ${data.length > 0 ? html`${data.map(m=> memeTemplate(m))}` :
            html`<p class="no-memes">No memes in database.</p>`}
        </div>
    </section>
`;

const memeTemplate = (m) => html`
    <div class="user-meme">
        <p class="user-meme-title">${m.title}</p>
        <img class="userProfileImage" alt="meme-img" src="${m.imageUrl}">
        <a class="button" href="/details/${m._id}">Details</a>
    </div>
`;