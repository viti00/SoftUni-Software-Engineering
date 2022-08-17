function loadCommits() {
    let ulElement = document.getElementById('commits');
    ulElement.innerHTML = '';
    let usernameElement = document.getElementById('username');
    let repoElement = document.getElementById('repo');

    fetch(`https://api.github.com/repos/${usernameElement.value}/${repoElement.value}/commits`)
        .then(function (response) {
            return response.json();
        })
        .then(function (commits) {
            commits.forEach(c => {
                let liElement = document.createElement('li');
                liElement.textContent = `${c.commit.author.name}: ${c.commit.message}`;
                ulElement.appendChild(liElement);
            });
        })
        .catch(function (error) {
            let liElement = document.createElement('li');
            liElement.textContent = `Error: 404 (Not Found)`;
            ulElement.appendChild(liElement);
        })
}