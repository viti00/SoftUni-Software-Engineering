
import { getAlbums } from "../api.js";
import { catalogTemplate } from "../templates/catalogTemplate.js";
import { getUser } from "../util.js";



export async function catalogView(ctx){

    const data = await getAlbums();
    const user = getUser();
    ctx.render(catalogTemplate(data, user))
}