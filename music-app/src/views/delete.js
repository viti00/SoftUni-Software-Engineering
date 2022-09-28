import { deleteFunc } from "../api.js";


export async function deleteAlbum(ctx){
    debugger;
    alert("Are you sure you want to delete item?");
    await deleteFunc(ctx.params.id);

    ctx.page.redirect('/catalog');
}