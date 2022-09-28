import { getAlbumById } from "../api.js";
import { detailsTemplate } from "../templates/detailsTemplate.js";
import { getUserId } from "../util.js";


export async function detailsView(ctx){
    const userId = getUserId();
    const albumId = ctx.params.id;

    const album = await getAlbumById(albumId);

    ctx.render(detailsTemplate(album, userId));
}