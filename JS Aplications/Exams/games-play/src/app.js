import page from "../node_modules/page/page.mjs";
import { contentDecorator } from "./middlewares/renderMiddleware.js";
import { homeView } from "./views/homeView.js";
import { catalogueView } from "./views/catalogueView.js";
import { loginView } from "../src/views/loginView.js";
import {registerView} from "../src/views/registerView.js";
import { logoutFunc } from "../src/views/logout.js";
import { detailsView } from "./views/detailsView.js"
import { createView } from "./views/createView.js";
import { editView } from "./views/editView.js";
import { deleteGame } from "./views/delete.js";


page(contentDecorator)
page('/', homeView);
page('/catalogue', catalogueView)
page('/login', loginView);
page('/register', registerView);
page('/logout', logoutFunc);
page('/details/:id', detailsView);
page('/create', createView);
page('/edit/:id', editView);
page('/delete/:id', deleteGame)


page.start();