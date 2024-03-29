import { login } from "../api.js";
import { loginTemplate } from "../templates/loginTemplate.js";


export async function loginView(ctx) {
    debugger;
    ctx.render(loginTemplate(onLogin));

    async function onLogin(e) {
        e.preventDefault();

        const form = e.currentTarget;

        const formData = new FormData(form);

        const email = formData.get('email');
        const password = formData.get('password');

        if (email.length > 0 && password.length > 0) {
            await login(email, password);
            form.reset();
            ctx.page.redirect('/');
        }
        else{
            window.alert("Invalid data!");
        }
    }
}
