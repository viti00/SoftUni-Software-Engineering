import { register } from "../api.js";
import { registerTemplate } from "../templates/registerTemplate.js";
import { hideNotification, showNotification } from "../util.js";



export async function registerView(ctx){
    ctx.render(registerTemplate(onRegister));

    async function onRegister(e){
        e.preventDefault();
        debugger;
        const form = e.currentTarget;

        const formData = new FormData(form);

        console.log();
        
        const username = formData.get('username');
        const email = formData.get('email');
        const password = formData.get('password');
        const rePass = formData.get('repeatPass');
        const gender = formData.get('gender');


        if(username.length > 0 && email.length > 0 && password.length > 0 && password == rePass){
            const data = {
                username,
                email,
                password,
                gender
            }
            await register(data);
            form.reset();
            ctx.page.redirect('/catalogue');
        }
        else {
            showNotification("All fields are required!");

            setTimeout(hideNotification, 3000);
        }
    }
}