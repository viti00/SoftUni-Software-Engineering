import { editTheater, getTheater } from "../api.js";
import { editTemplate } from "../templates/editTemplate.js";


export async function editView(ctx){
    const id = ctx.params.id;

    const theater = await getTheater(id);

    ctx.render(editTemplate(theater, onEdit));

    async function onEdit(e){
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

            await editTheater(id, data);
            form.reset();
            ctx.page.redirect(`/details/${id}`);  
        }
    }
}