import { html } from "../../node_modules/lit-html/lit-html.js";


export const detailsTemplate = (theater, userId, likes, onwLike) => html`
    <section id="detailsPage">
            <div id="detailsBox">
                <div class="detailsInfo">
                    <h1>Title: ${theater.title}</h1>
                    <div>
                        <img src="${theater.imageUrl}" />
                    </div>
                </div>

                <div class="details">
                    <h3>Theater Description</h3>
                    <p>${theater.description}</p>
                    <h4>Date: ${theater.date}</h4>
                    <h4>Author: ${theater.author}</h4>
                    <div class="buttons">
                        ${theater._ownerId == userId ? html`
                        <a class="btn-delete" href="/delete/${theater._id}">Delete</a>
                        <a class="btn-edit" href="/edit/${theater._id}">Edit</a>
                        `: null}
                        ${userId != theater._ownerId && userId != null && onwLike == false? html`
                        <a class="btn-like" href="/like/${theater._id}">Like</a>
                        `: null}
                    </div>
                    <p class="likes">Likes: ${likes}</p>
                </div>
            </div>
        </section>
`;