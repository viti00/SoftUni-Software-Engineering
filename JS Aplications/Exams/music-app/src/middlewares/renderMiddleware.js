import {render} from "../../node_modules/lit-html/lit-html.js";
import { updateNavigation } from "../util.js";

const root = document.getElementById('main-content');

export function contentDecorator(ctx, next){
    updateNavigation();
    ctx.render = (content) => render(content, root);

    next();
} 