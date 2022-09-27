import { getMyTheaters } from "../api.js";
import { profileTemplate } from "../templates/profileTemplate.js";
import { getUser } from "../util.js";


export async function profileView(ctx){
    const user = getUser();


    const data = await getMyTheaters(user._id);

    ctx.render(profileTemplate(data, user))
}