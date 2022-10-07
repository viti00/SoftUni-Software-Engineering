import { getMyMemes } from "../api.js";
import { myProfileTemplate } from "../templates/myProfileTemplate.js";
import { getUser } from "../util.js";


export async function myProfileView(ctx){
    const user = getUser();
    const data = await getMyMemes(user._id);

    ctx.render(myProfileTemplate(data, user));
}