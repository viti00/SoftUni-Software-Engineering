import { solve } from "./app.js";


const routes = {
    '/home': solve,
    //'/content': commentPage
}

export function router(path){
    let renderer = routes[path];
    renderer();
}