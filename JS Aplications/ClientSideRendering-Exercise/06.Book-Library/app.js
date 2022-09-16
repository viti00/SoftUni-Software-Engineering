import { html, render } from "../node_modules/lit-html/lit-html.js";
import { add, editBookFunc, getBooks, deleteFunc } from "./api.js";


const body = document.querySelector('body');


const bodyTemplate = html`
    <button id="loadBooks">LOAD ALL BOOKS</button>
    <table>
        <thead>
            <tr>
                <th>Title</th>
                <th>Author</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
    
        </tbody>
    </table>
    
    <form id="add-form">
        <h3>Add book</h3>
        <label>TITLE</label>
        <input type="text" name="title" placeholder="Title...">
        <label>AUTHOR</label>
        <input type="text" name="author" placeholder="Author...">
        <input type="submit" value="Submit">
    </form>
    
    <form id="edit-form" style="display: none">
        <input type="hidden" name="id">
        <h3>Edit book</h3>
        <label>TITLE</label>
        <input type="text" name="title" placeholder="Title...">
        <label>AUTHOR</label>
        <input type="text" name="author" placeholder="Author...">
        <input type="submit" value="Save">
    </form>
`

const bookTemplate = (data) => data.map(b => b = html`
<tr>
    <td>${b[1].title}</td>
    <td>${b[1].author}</td>
    <td>
        <button data-id="${b[0]}" @click=${editBook}>Edit</button>
        <button data-id="${b[0]}" @click=${deleteBook}>Delete</button>
    </td>
</tr>
`)

renderPage();
document.getElementById('loadBooks').addEventListener('click', loadBooks);
const tbody = document.querySelector('tbody');
let addForm = document.getElementById('add-form');
let editForm = document.getElementById('edit-form');

addForm.addEventListener('submit', addBook);

async function addBook(e){
    e.preventDefault();

    let formData = new FormData(addForm);

    let title = formData.get('title');
    let author = formData.get('author');

    await add(title, author);
    loadBooks();
    addForm.reset();

}

async function loadBooks() {
    const books = await getBooks();

    const result = bookTemplate(Object.entries(books));

    render(result, tbody);
}

async function editBook(e) {
    debugger;
    addForm.style.display = 'none';
    editForm.style.display = 'block';
    let id = e.target.getAttribute('data-id');

    let parent = e.target.parentNode.parentNode;

    editForm.children[3].value = parent.children[0].textContent;
    editForm.children[5].value = parent.children[1].textContent;

    editForm.addEventListener('submit', async (e) => {
        e.preventDefault();
        const formData = new FormData(editForm);
        
        let title = formData.get('title');
        let author = formData.get('author');

        await editBookFunc(title, author, id);
        loadBooks();
        editForm.reset();
        editForm.style.display = 'none';
        addForm.style.display = 'block';
    })

}

async function deleteBook(e) {
    debugger;
    let id = e.target.getAttribute('data-id');
    deleteFunc(id);
    loadBooks();
}

function renderPage() {
    render(bodyTemplate, body);
}
