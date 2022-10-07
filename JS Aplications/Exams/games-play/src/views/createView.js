import { createGame } from "../api.js";
import { createTemplate } from "../templates/createTemplate.js";


export async function createView(ctx){
    ctx.render(createTemplate(onCreate));

    async function onCreate(e){
        e.preventDefault();

        const form = e.currentTarget;

        const formData = new FormData(form);

        const title = formData.get('title');
        const category = formData.get('category');
        const maxLevel = formData.get('maxLevel');
        const imageUrl = formData.get('imageUrl');
        const summary = formData.get('summary');

        if(title.length > 0 && category.length >0 && maxLevel.length > 0 && imageUrl.length > 0 && summary.length > 0){
            const data = {
                title,
                category,
                maxLevel,
                imageUrl,
                summary
            };

            await createGame(data);
            form.reset();
            ctx.page.redirect('/');
        }
        else {
            alert('Missing fields!');
        }
    }
}