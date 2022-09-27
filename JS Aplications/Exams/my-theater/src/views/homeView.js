import { getAllTheaters } from "../api.js";
import { homeTemplate } from "../templates/homeTemplate.js";


export async function homeView(ctx){
    const data = await getAllTheaters();

    ctx.render(homeTemplate(data));
}