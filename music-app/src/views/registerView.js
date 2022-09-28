import { register } from "../api.js";
import { registerTemplate } from "../templates/registerTemplate.js";



export async function registerView(ctx){
    ctx.render(registerTemplate(onRegister));

    async function onRegister(e){
        e.preventDefault();

        const form = e.currentTarget;

        const formData = new FormData(form);

        const email = formData.get('email');
        const password = formData.get('password');
        const rePass = formData.get('conf-pass');


        if(email.length > 0 && password.length > 0 && password == rePass){
            await register(email, password);
            form.reset();
            ctx.page.redirect('/');
        }
    }
}