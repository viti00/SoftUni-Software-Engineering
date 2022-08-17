function loadRepos() {
	let ulElement = document.getElementById('repos');
	ulElement.innerHTML = '';
	let usernameElement = document.getElementById('username');

	let baseUrl = 'https://api.github.com/users';

	fetch(`${baseUrl}/${usernameElement.value}/repos`)
		.then(function (response) {
			return response.json();
		})
		.then(function (character) {
			character.forEach(element => {
				
				let liElement = document.createElement('li');
				let aElement = document.createElement('a');

				aElement.setAttribute('href', `${element.html_url}`);
				aElement.textContent = element.full_name;

				liElement.appendChild(aElement);

				ulElement.appendChild(liElement);
			});
		})
		.catch(function (error) {
			ulElement.innerHTML = 'Not Found';
		})

}