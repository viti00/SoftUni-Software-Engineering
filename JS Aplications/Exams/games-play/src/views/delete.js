import { deleteFunc } from "../api.js";


export async function deleteGame(ctx){
    const id = ctx.params.id;
    await deleteFunc(id);

    ctx.page.redirect('/');
}