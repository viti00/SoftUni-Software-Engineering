import { addLike } from "../api.js";


export async function like(ctx){
    debugger;
    const id = ctx.params.id;

    await addLike(id);
    ctx.page.redirect(`/details/${id}`);
}