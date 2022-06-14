function lockedProfile() {
    let lockUnlockButtonsForFirtUser = document.getElementsByName('user1Locked');
    let lockUnlockButtonsForSecondUser = document.getElementsByName('user2Locked');
    let lockUnlockButtonsForThirdUser = document.getElementsByName('user3Locked');

    let showMoreButtons = document.getElementsByTagName('button');

    let hidenDivForFirstUser = document.getElementById('user1HiddenFields');
    let hideDivForSecondUser = document.getElementById('user2HiddenFields');
    let hideDivForThirdUser = document.getElementById('user3HiddenFields');

    showMoreButtons[0].addEventListener('click', (e) => {
        if (lockUnlockButtonsForFirtUser[1].checked == true) {

            if (e.target.textContent === 'Show more') {
                hidenDivForFirstUser.style.display = 'block';
                e.target.textContent = 'Hide it';
            }

            else if (e.target.textContent === 'Hide it') {
                hidenDivForFirstUser.style.display = 'none';
                e.target.textContent = 'Show more';
            }
        }
    });

    showMoreButtons[1].addEventListener('click', (e) => {
        if (lockUnlockButtonsForSecondUser[1].checked == true) {

            if (e.target.textContent === 'Show more') {
                hideDivForSecondUser.style.display = 'block';
                e.target.textContent = 'Hide it';
            }

            else if (e.target.textContent === 'Hide it') {
                hideDivForSecondUser.style.display = 'none';
                e.target.textContent = 'Show more';
            }
        }
    });


    showMoreButtons[2].addEventListener('click', (e) => {
        if (lockUnlockButtonsForThirdUser[1].checked == true) {

            if (e.target.textContent === 'Show more') {
                hideDivForThirdUser.style.display = 'block';
                e.target.textContent = 'Hide it';
            }

            else if (e.target.textContent === 'Hide it') {
                hideDivForThirdUser.style.display = 'none';
                e.target.textContent = 'Show more';
            }
        }
    });
}