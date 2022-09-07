import { html } from '../../../node_modules/lit-html/lit-html.js';
import { login } from '../api.js';
import { changeActiveClass, updateNavigation } from '../util.js';

const loginTemplate = (onLogin) => html`
    <div class="row space-top">
        <div class="col-md-12">
            <h1>Login User</h1>
            <p>Please fill all fields.</p>
        </div>
    </div>
    <form @submit=${onLogin}>
        <div class="row space-top">
            <div class="col-md-4">
                <div class="form-group">
                    <label class="form-control-label" for="email">Email</label>
                    <input class="form-control" id="email" type="text" name="email">
                </div>
                <div class="form-group">
                    <label class="form-control-label" for="password">Password</label>
                    <input class="form-control" id="password" type="password" name="password">
                </div>
                <input type="submit" class="btn btn-primary" value="Login" />
            </div>
        </div>
    </form>
`;

const element = document.querySelector('#loginLink');

export function loginPage(ctx) {
    changeActiveClass(element);
    ctx.render(loginTemplate(onLogin));

    async function onLogin(e) {
        e.preventDefault();
        
        let formData = new FormData(e.currentTarget);

        let email = formData.get('email');
        let password = formData.get('password');

       
        if (email.length > 0 && password.length > 0) {
            e.currentTarget.reset();
            await login(email, password);
            updateNavigation();
            ctx.page.redirect('/');
        }
        else {
            alert('Invalid data! Try again');
        }
    }
}
