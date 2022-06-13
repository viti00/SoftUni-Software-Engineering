function focused() {
    let divElement = document.querySelector('div');

    Array.from(divElement.getElementsByTagName('input')).forEach(e => {
        e.addEventListener('focus', focus);
    });

    Array.from(divElement.getElementsByTagName('input')).forEach(e => {
        e.addEventListener('blur', blur);
    });

    function focus(e){
        let parent = e.target.parentNode;
        parent.classList.add('focused');
    }

    function blur(e) {
        let parent = e.target.parentNode;
        parent.classList.remove('focused');
    }
}