import { editGame, getGame } from "../api.js";
import { editTemplate } from "../templates/editTemplate.js";


export async function editView(ctx){
    const id = ctx.params.id;

    const game = await getGame(id);

    ctx.render(editTemplate(game, onEdit));

    async function onEdit(e){
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

            await editGame(id, data);
            form.reset();
            ctx.page.redirect(`/details/${id}`);
        }
        else {
            alert('Missing fields!');
        }
    }
}