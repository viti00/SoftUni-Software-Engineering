import { editMeme, getMeme } from "../api.js";
import { editTemplate } from "../templates/editTemplate.js";
import { hideNotification, showNotification } from "../util.js";




export async function editView(ctx){
    const memeId = ctx.params.id;
    console.log(memeId);

    const meme = await getMeme(memeId);

    ctx.render(editTemplate(meme, onEdit));

    async function onEdit(e){
        e.preventDefault();

        const form = e.currentTarget;

        const formData = new FormData(form);

        const title = formData.get('title');
        const description = formData.get('description');
        const imageUrl = formData.get('imageUrl');

        if(title.length > 0 && description.length > 0 && imageUrl.length > 0){
            const data = {
                title,
                description,
                imageUrl
            };
            
            await editMeme(memeId, data);
            form.reset();
            ctx.page.redirect(`/details/${memeId}`);
        }
        else {
            showNotification('All fields are required!');

            setTimeout(hideNotification, 3000);
        }
    }
}