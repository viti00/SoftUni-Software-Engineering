function encodeAndDecodeMessages() {
    let encodeBtn = document.getElementsByTagName('button')[0];
    let decodeBtn = document.getElementsByTagName('button')[1];
    let inputArea = document.getElementsByTagName('textarea')[0];
    let decodedArea = document.getElementsByTagName('textarea')[1];

    encodeBtn.addEventListener('click', encode);
    decodeBtn.addEventListener('click', decode);

    function encode() {
        let textToEncode = inputArea.value;
        let result = '';

        for (let i = 0; i < textToEncode.length; i++) {
            let currCode = textToEncode[i].charCodeAt(0);
            let newSymbol = String.fromCharCode(currCode + 1);
            result += newSymbol;
        }

        decodedArea.value = result;
        inputArea.value = '';
    }

    function decode(){
        let textToDecode = decodedArea.value;
        let result = '';

        for (let i = 0; i < textToDecode.length; i++) {
            let currCode = textToDecode[i].charCodeAt(0);
            let newSymbol = String.fromCharCode(currCode - 1);
            result += newSymbol;
        }

        decodedArea.value = result;
    }

}