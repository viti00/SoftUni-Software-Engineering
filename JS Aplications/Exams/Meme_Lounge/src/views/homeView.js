import { homeTemplate } from "../templates/homeTemplate.js";


export function homeView(ctx){
    ctx.render(homeTemplate());
}