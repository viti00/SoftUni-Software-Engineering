import { createAlbum } from "../api.js";
import { createTemplate } from "../templates/createTemplate.js"

export async function createView(ctx) {
    ctx.render(createTemplate(onCreate));

    async function onCreate(e) {
        debugger
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
            
            await createAlbum(data);
            form.reset();
            ctx.page.redirect('/catalog');

        }
        else {
            alert('Missing fields!');
        }
    }
}