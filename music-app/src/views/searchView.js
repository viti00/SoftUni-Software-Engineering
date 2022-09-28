import { getSearch } from "../api.js";
import { cardTemplate, noDataTemplate, searchTemplate } from "../templates/searchTemplate.js";
import { getUser } from "../util.js";


export async function searchView(ctx) {
    ctx.render(searchTemplate(undefined, undefined, onSearch));

    async function onSearch(e) {
        debugger;
        e.preventDefault();

        const query = e.target.parentNode.children[0].value;

        if (query.length > 0) {
            const data = await getSearch(query);

            const user = getUser();

            ctx.render(searchTemplate(data, user, onSearch));
        }
        else {
            alert('Missing fields!');
        }
    }
}