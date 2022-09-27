import { html } from "../../node_modules/lit-html/lit-html.js";

export const profileTemplate = (data, user) => html`
    <section id="profilePage">
        <div class="userInfo">
            <div class="avatar">
                <img src="./images/profilePic.png">
            </div>
            <h2>${user.email}</h2>
        </div>
        <div class="board">
            ${data.length > 0 ? html`
            ${data.map(t =>theaterTemplate(t))}
            `: html`
            <div class="no-events">
                <p>This user has no events yet!</p>
            </div>
            `}
    
        </div>
    </section>
`;

const theaterTemplate = (t) => html`
    <div class="board">
        <div class="eventBoard">
            <div class="event-info">
                <img src="${t.imageUrl}">
                <h2>${t.title}</h2>
                <h6>${t.date}</h6>
                <a href="/details/${t._id}" class="details-button">Details</a>
            </div>
        </div>
`