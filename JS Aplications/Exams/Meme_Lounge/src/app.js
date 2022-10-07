import page from "../node_modules/page/page.mjs";
import {contentDecorator} from "./middlewares/renderMiddleware.js";
import { allMemeView } from "./views/allMemesView.js";
import { createView } from "./views/createView.js";
import { detailsView } from "./views/detailsView.js";
import { editView } from "./views/editView.js";
import {homeView} from"./views/homeView.js"
import { loginView } from "./views/loginView.js";
import { logoutFunc } from "./views/logout.js";
import { myProfileView } from "./views/myProfileView.js";
import { registerView } from "./views/registerView.js";


page(contentDecorator);
page('/', homeView);
page('/login', loginView);
page('/register', registerView);
page('/logout', logoutFunc);
page('/catalogue', allMemeView);
page('/create', createView);
page('/my-profile', myProfileView);
page('/details/:id', detailsView);
page('/edit/:id', editView)


page.start();