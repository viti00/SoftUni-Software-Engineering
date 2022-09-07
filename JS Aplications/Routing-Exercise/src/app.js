import page from "../../node_modules/page/page.mjs";
import { render } from "../../node_modules/lit-html/lit-html.js";
import { dashboardPage } from "./views/dashboardPage.js";
import { updateNavigation } from "./util.js";
import { loginPage } from "./views/loginPage.js";
import { onLogout } from "./views/logout.js";
import { registerPage } from "./views/registerPage.js";
import { createPage } from "./views/createPage.js";
import { details } from "./views/detailsPage.js";
import { edit } from "./views/editPage.js";
import { delFunc } from "./views/delete.js";


const root = document.querySelector('.container');


updateNavigation();
page.redirect('/');

page(decoratorContext);
page('/', dashboardPage);
page('/details/:id', details);
page('/create', createPage);
page('/login', loginPage);
page('/logout', onLogout);
page('/register', registerPage);
page('/my-furniture', dashboardPage);
page('/edit/:id', edit);
page('/delete', delFunc);

page.start();


function decoratorContext(ctx, next) {
    ctx.render = (content) => render(content, root);
    next();
}



