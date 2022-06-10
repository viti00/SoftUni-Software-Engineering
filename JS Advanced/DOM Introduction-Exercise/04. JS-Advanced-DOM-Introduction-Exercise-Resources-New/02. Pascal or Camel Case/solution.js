function solve() {
  let textElement = document.getElementById('text').value;

  let namingStrategyElement = document.getElementById('naming-convention').value;

  let result = '';
  let wordArr = textElement.split(' ').map(w=> w.toLowerCase());
    if(namingStrategyElement == 'Camel Case'){
      for (let i = 0; i < wordArr.length; i++) {
        if(i !== 0){
          result += wordArr[i].charAt(0).toUpperCase() + wordArr[i].slice(1);
        }
        else{
          result += wordArr[i];
        }
      }
    }
    else if(namingStrategyElement == 'Pascal Case'){
      for (let i = 0; i < wordArr.length; i++) {
        result += wordArr[i].charAt(0).toUpperCase() + wordArr[i].slice(1);
      }
    }
    else {
      result = 'Error!';
    }

    let spanElement = document.getElementById('result');

    spanElement.textContent = result;
}