import { deleteFunc } from "../api.js";


export async function deleteTheater(ctx){
    const id = ctx.params.id;
    const text = 'Are you sure you want to delete item?';
    
    if(confirm(text) == true){
        await deleteFunc(id);
        ctx.page.redirect('/profile');
    }
    
}