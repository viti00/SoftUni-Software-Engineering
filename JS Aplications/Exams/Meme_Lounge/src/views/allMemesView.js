import { getAllMemes } from "../api.js";
import{allMemesTemplate} from "../templates/allMemesTemplate.js"


export async function allMemeView(ctx){
    const data = await getAllMemes();

    ctx.render(allMemesTemplate(data))
}