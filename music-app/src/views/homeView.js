import { homeTemplate } from "../templates/homePageTemplate.js";


export function homeView(ctx){
    ctx.render(homeTemplate());
}