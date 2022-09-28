import { createMeme } from "../api.js";
import {createTemplate} from"../templates/createTemplate.js"
import { hideNotification, showNotification } from "../util.js";

export async function createView(ctx){
    ctx.render(createTemplate(onCreate));

    async function onCreate(e){
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
            
            await createMeme(data);
            form.reset();
            ctx.page.redirect('/catalogue');
        }
        else {
            showNotification('All fields are required!');

            setTimeout(hideNotification, 3000);
        }
    }
}