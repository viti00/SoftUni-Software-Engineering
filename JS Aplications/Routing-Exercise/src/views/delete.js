import { deleteFunc } from "../api.js";
import { updateNavigation } from "../util.js";


export async function delFunc(ctx){

    let deleteBtn = document.querySelector('.btn.btn-red');

    let id = deleteBtn.getAttribute('data-id');

    await deleteFunc(id);
    
    updateNavigation();
    ctx.page.redirect('/');
}   