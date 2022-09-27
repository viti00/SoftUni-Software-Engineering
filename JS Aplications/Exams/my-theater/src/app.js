import page from"../node_modules/page/page.mjs";
import { contentDecorator } from "./middlewares/renderMiddleware.js";
import { homeView } from "./views/homeView.js";
import { loginView } from "./views/loginView.js";
import { registerView } from "./views/registerView.js";
import { logoutFunc } from "./views/logout.js";
import { createView } from "./views/createView.js";
import { detailsView } from "./views/detailsView.js";
import { editView } from "./views/editView.js";
import { deleteTheater } from "./views/delete.js";
import { profileView } from "./views/profileView.js";
import { like } from "./views/like.js";
import { updateNavigation } from "./middlewares/updateNavigation.js";

page(updateNavigation);
page(contentDecorator);
page('/', homeView);
page('/login', loginView);
page('/register', registerView);
page('/logout', logoutFunc);
page('/create', createView);
page('/details/:id',detailsView);
page('/edit/:id', editView);
page('/delete/:id', deleteTheater);
page('/profile', profileView);
page('/like/:id', like);


page.start();