import { getLikeForUser, getTheater, getTotalLikes } from "../api.js";
import { detailsTemplate } from "../templates/detailsTemplate.js";
import { getUserId } from "../util.js";


export async function detailsView(ctx){
    const id = ctx.params.id;

    const userId = getUserId();

    const [theater, likes, onwLike] = await Promise.all([
        getTheater(id),
        getTotalLikes(id),
        getLikeForUser(id, userId)
    ]);

    ctx.render(detailsTemplate(theater, userId, likes, onwLike));
}