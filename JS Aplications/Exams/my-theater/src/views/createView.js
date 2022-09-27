import { createTheater } from "../api.js";
import { createTemplate } from "../templates/createTemplate.js";


export async function createView(ctx){
    ctx.render(createTemplate(onCreate));

    async function onCreate(e){
        e.preventDefault();

        const form = e.currentTarget;

        const formData = new FormData(form);

        const title = formData.get('title');
        const date = formData.get('date');
        const author = formData.get('author');
        const description = formData.get('description');
        const imageUrl = formData.get('imageUrl');

        if(title.length > 0 && date.length > 0 && author.length > 0 && description.length > 0 && imageUrl.length > 0){
            const data = {
                title,
                date,
                author,
                imageUrl,
                description
            };

            await createTheater(data);
            form.reset();
            ctx.page.redirect('/');  
        }

    }
}