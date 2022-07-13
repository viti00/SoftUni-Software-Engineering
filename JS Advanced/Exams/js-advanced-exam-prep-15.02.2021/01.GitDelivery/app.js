function solution() {
    let addBtn = document.querySelector('button');
    let ulElements = document.querySelectorAll('ul');

    addBtn.addEventListener('click', addGift);

    function addGift(){
        let giftNameElement = document.querySelector('input');

        let newLiElement = document.createElement('li');
        newLiElement.setAttribute('class', 'gift');
        newLiElement.textContent = giftNameElement.value;

        let sendBtn = document.createElement('button');
        sendBtn.setAttribute('id', 'sendButton');
        sendBtn.textContent = 'Send';

        let discardBtn = document.createElement('button');
        discardBtn.setAttribute('id', 'discardButton');
        discardBtn.textContent = 'Discard';


        newLiElement.appendChild(sendBtn);
        newLiElement.appendChild(discardBtn);

        
        ulElements[0].appendChild(newLiElement);
        giftNameElement.value = '';

        let sortedGifts = Array.from(ulElements[0].children).sort((a,b) => a.textContent.localeCompare(b.textContent));

        ulElements[0].innerHTML = '';
        for (const gift of sortedGifts) {
            ulElements[0].appendChild(gift);
        }

        sendBtn.addEventListener('click', sendGift);
        discardBtn.addEventListener('click', discardGift);


        function sendGift(e){
            let parent = e.target.parentNode;

            let liElementForSentGift = document.createElement('li');
            liElementForSentGift.setAttribute('class', 'gift');
            liElementForSentGift.textContent = parent.childNodes[0].textContent;

            ulElements[1].appendChild(liElementForSentGift);

            parent.remove();

        }

        function discardGift(e){
            let parent = e.target.parentNode;
            let liElementForDiscardGift = document.createElement('li');
            liElementForDiscardGift.setAttribute('class', 'gift');
            liElementForDiscardGift.textContent = parent.childNodes[0].textContent;

            ulElements[2].appendChild(liElementForDiscardGift);

            parent.remove();
        }
    }
}