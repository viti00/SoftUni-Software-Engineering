import {html} from '../../../node_modules/lit-html/lit-html.js';
import { register } from '../api.js';
import { changeActiveClass, updateNavigation } from '../util.js';

const registerTempalte = (onRegister) => html`
    <div class="row space-top">
            <div class="col-md-12">
                <h1>Register New User</h1>
                <p>Please fill all fields.</p>
            </div>
        </div>
        <form @submit=${onRegister}>
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
                    <div class="form-group">
                        <label class="form-control-label" for="rePass">Repeat</label>
                        <input class="form-control" id="rePass" type="password" name="rePass">
                    </div>
                    <input type="submit" class="btn btn-primary" value="Register" />
                </div>
            </div>
        </form>
`

const element = document.querySelector('#registerLink');

export function registerPage(ctx){
    changeActiveClass(element);
    ctx.render(registerTempalte(onRegister))

    async function onRegister(e){
        e.preventDefault();

        let formData = new FormData(e.currentTarget);
    
        let email = formData.get('email');
        let password = formData.get('password');
        let rePass = formData.get('rePass');

        if(email.length > 0 && password.length > 0 && password === rePass){

            e.currentTarget.reset();
            await register(email, password, rePass);
            updateNavigation();
            ctx.page.redirect('/');
        }
        else {
            alert('Invalid data! Try again');
        }

    }
}