import { getLatestGames } from "../api.js";
import { homeTemplate } from "../templates/homeTemplate.js"


export async function homeView(ctx){
    const data = await getLatestGames();

    ctx.render(homeTemplate(data));
}