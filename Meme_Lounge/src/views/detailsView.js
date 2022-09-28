import { getMeme, deleteFunc } from "../api.js";
import { detailsTemplate } from "../templates/detailsTemplate.js";
import { getUserId } from "../util.js";



export async function detailsView(ctx){
    const memeId = ctx.params.id;

    const userId = getUserId();
    const meme = await getMeme(memeId);

    ctx.render(detailsTemplate(meme, userId, onDelete));

    async function onDelete(e){
        const id = e.target.dataset.id;

        await deleteFunc(id);
        ctx.page.redirect('/catalogue');
    }
}