import { logout } from "../api.js";


export async function logoutFunc(ctx){
    await logout();

    ctx.page.redirect('/');
}