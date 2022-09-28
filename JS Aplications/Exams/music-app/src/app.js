import page from "../node_modules/page/page.mjs";
import { contentDecorator } from "./middlewares/renderMiddleware.js";
import { catalogView } from "./views/catalogView.js";
import { createView } from "./views/createView.js";
import { deleteAlbum } from "./views/delete.js";
import { detailsView } from "./views/detailsView.js";
import { editView } from "./views/editView.js";
import { homeView } from "./views/homeView.js";
import { loginView } from "./views/loginView.js";
import { logoutFunc } from "./views/logout.js";
import { registerView } from "./views/registerView.js";
import { searchView } from "./views/searchView.js";

page(contentDecorator);
page('/', homeView);
page('/catalog', catalogView);
page('/login', loginView);
page('/register', registerView);
page('/logout', logoutFunc);
page('/create', createView);
page('/search', searchView);
page('/details/:id', detailsView);
page('/edit/:id', editView);
page('/delete/:id', deleteAlbum)

page.start();