import { getUserId } from "../util.js";
import { detailsTemplate } from "../templates/detailsTemplate.js"
import { createComment, getComments, getGame } from "../api.js";


export async function detailsView(ctx){
    debugger;
    const id = ctx.params.id;

    const [game, comments] = await Promise.all([
        getGame(id),
        getComments(id)
    ]);

    const userId= getUserId();

    ctx.render(detailsTemplate(game, userId, comments, onComment));

    async function onComment(e){
        e.preventDefault();
        const form = e.currentTarget;

        const formData = new FormData(form);

        const comment = formData.get('comment');

        if(comment.length > 0){
            const data = {
                gameId: id,
                comment: comment
            };

            await createComment(data);
            form.reset();
            ctx.page.redirect(`/details/${id}`);
        }
        else{
            alert("You can't send empty comment!")
        }
    }

}