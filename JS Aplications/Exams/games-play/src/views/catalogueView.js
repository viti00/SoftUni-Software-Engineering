import { getAllGames } from "../api.js";
import { catalogueTemplate } from "../templates/catalogueTemplate.js";


export async function catalogueView(ctx){
    const data = await getAllGames();

    ctx.render(catalogueTemplate(data));
}