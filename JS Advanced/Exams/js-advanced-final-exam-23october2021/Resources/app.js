window.addEventListener('load', solve);

function solve() {
    let addButton = document.getElementById('add-btn');

    addButton.addEventListener('click', addSong);

    function addSong(e){

        e.preventDefault();

        let genreElement = document.getElementById('genre');

        let nameElement = document.getElementById('name');

        let authorElement = document.getElementById('author');

        let dateElement = document.getElementById('date');

        let songCOntainer = document.getElementsByClassName('all-hits-container')[0];

        let newDivElement = document.createElement('div');
        newDivElement.setAttribute('class', 'hits-info');

        let imgElement = document.createElement('img');
        imgElement.setAttribute('src', './static/img/img.png');

        let genreH2Elemenent = document.createElement('h2');
        genreH2Elemenent.textContent = `Genre: ${genreElement.value}`;

        let nameH2Element = document.createElement('h2');
        nameH2Element.textContent = `Name: ${nameElement.value}`;

        let authorH2Element = document.createElement('h2');
        authorH2Element.textContent = `Author: ${authorElement.value}`;

        let dateH3Element = document.createElement('h3');
        dateH3Element.textContent = `Date: ${dateElement.value}`;

        let saveBtn = document.createElement('button');
        saveBtn.setAttribute('class', 'save-btn');
        saveBtn.textContent = 'Save song';

        let likeBtn = document.createElement('button');
        likeBtn.setAttribute('class', 'like-btn');
        likeBtn.textContent = 'Like song';

        let deleteBtn = document.createElement('button');
        deleteBtn.setAttribute('class', 'delete-btn');
        deleteBtn.textContent = 'Delete';


        newDivElement.appendChild(imgElement);
        newDivElement.appendChild(genreH2Elemenent);
        newDivElement.appendChild(nameH2Element);
        newDivElement.appendChild(authorH2Element);
        newDivElement.appendChild(dateH3Element);
        newDivElement.appendChild(saveBtn);
        newDivElement.appendChild(likeBtn);
        newDivElement.appendChild(deleteBtn);

        if(genreElement.value.length > 0 && nameElement.value.length > 0 && authorElement.value.length > 0 && dateElement.value.length > 0){
            songCOntainer.appendChild(newDivElement);

            genreElement.value = '';
            nameElement.value = '';
            authorElement.value = '';
            dateElement.value = '';

            likeBtn.addEventListener('click', likeSong);
            saveBtn.addEventListener('click', saveSong);
            deleteBtn.addEventListener('click', deleteSong);

            function likeSong(e){
                debugger;
                let divEl = document.getElementsByClassName('likes')[0];
                let pElement = divEl.children[0];

                let currLikes = Number(pElement.textContent.substring(pElement.textContent.length-2, ));
                currLikes++;

                pElement.textContent = `Total Likes: ${currLikes}`;

                e.target.disabled = true;
            }

            function saveSong(e){
                let divSavedSong = document.getElementsByClassName('saved-container')[0];

                let h2Genre = document.createElement('h2');
                h2Genre.textContent = `${e.target.parentNode.children[1].textContent}`;

                let h2Name = document.createElement('h2');
                h2Name.textContent = `${e.target.parentNode.children[2].textContent}`;

                let h2Author = document.createElement('h2');
                h2Author.textContent = `${e.target.parentNode.children[3].textContent}`;

                let h3Date = document.createElement('h3');
                h3Date.textContent = `${e.target.parentNode.children[4].textContent}`;


                let divSongChild = document.createElement('div');
                divSongChild.setAttribute('class', 'hits-info');

                divSongChild.appendChild(imgElement);
                divSongChild.appendChild(h2Genre);
                divSongChild.appendChild(h2Name);
                divSongChild.appendChild(h2Author);
                divSongChild.appendChild(h3Date);
                divSongChild.appendChild(deleteBtn);

                divSavedSong.appendChild(divSongChild);

                e.target.parentNode.remove();

            }

            function deleteSong(e){
                e.target.parentNode.remove();
            }
        }
    }
}