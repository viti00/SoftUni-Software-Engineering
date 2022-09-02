debugger;
import { router } from "./router.js";

let allAElements = document.querySelectorAll('a');

Array.from(allAElements).forEach(el => el.addEventListener('click', getUrl));

function getUrl(e){
    e.preventDefault();
    let url = new URL(e.target.href);
    
    router(url.pathname);
}