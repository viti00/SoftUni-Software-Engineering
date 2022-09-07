import { logout } from "../api.js";
import { updateNavigation } from "../util.js";


export async function onLogout(ctx){
    await logout();

    updateNavigation();

    ctx.page.redirect('/');
}