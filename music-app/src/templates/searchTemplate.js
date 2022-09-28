import { html } from "../../node_modules/lit-html/lit-html.js";


export const searchTemplate = (data, user, onSubmit) => html`
    <section id="searchPage">
        <h1>Search by Name</h1>
    
        <div class="search">
            <input id="search-input" type="text" name="search" placeholder="Enter desired albums's name">
            <button @click=${onSubmit} class="button-list">Search</button>
        </div>
    
        <h2>Results:</h2>
        ${data != undefined ? html`
        <div class="search-result">
            ${data.length > 0 ? html`
            ${data.map(a => cardTemplate(a, user))}
            ` : noDataTemplate()}
        </div>
        `: null}
    </section>
`;

export const cardTemplate = (c, user) => html`
    <div class="card-box">
        <img src="${c.imgUrl}">
        <div>
            <div class="text-center">
                <p class="name">Name: ${c.name}</p>
                <p class="artist">Artist: ${c.artist}</p>
                <p class="genre">Genre: ${c.genre}</p>
                <p class="price">Price: $${c.price}</p>
                <p class="date">Release Date: ${c.releaseDate}</p>
            </div>
            ${user != null ? html`
            <div class="btn-group">
                <a href="/details/${c._id}" id="details">Details</a>
            </div>
            ` : null}
        </div>
    </div>
`;

export const noDataTemplate = () => html`
    <p class="no-result">No result.</p>
`;