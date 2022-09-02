export function cancel(e) {
    e.preventDefault();

    e.target.parentNode.parentNode.reset();
}
