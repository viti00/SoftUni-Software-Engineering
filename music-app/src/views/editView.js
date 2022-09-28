import { editAlbumById, getAlbumById } from "../api.js";
import { editTemplate } from "../templates/editTemplate.js";


export async function editView(ctx){

    const albumId = ctx.params.id;

    const album = await getAlbumById(albumId)

    ctx.render(editTemplate(album, onEdit));

    async function onEdit(e){
        e.preventDefault();

        const form = e.currentTarget;

        const formData = new FormData(form);

        const name = formData.get('name');
        const imgUrl = formData.get('imgUrl');
        const price = formData.get('price');
        const releaseDate = formData.get('releaseDate');
        const artist = formData.get('artist');
        const genre = formData.get('genre');
        const description = formData.get('description');

        if (name.length > 0 && imgUrl.length > 0 && price.length > 0
            && releaseDate.length > 0 && artist.length > 0
            && genre.length > 0 && description.length > 0) {
            const data = {
                name,
                imgUrl,
                price,
                releaseDate,
                artist,
                genre,
                description
            };
            
            await editAlbumById(albumId, data);
            form.reset();
            ctx.page.redirect(`/details/${albumId}`);
        }
    }
}