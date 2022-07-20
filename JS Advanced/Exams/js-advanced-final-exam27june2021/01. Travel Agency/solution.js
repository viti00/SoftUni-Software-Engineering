window.addEventListener('load', solution);

function solution() {
    let submitBtn = document.getElementById('submitBTN');

    submitBtn.addEventListener('click', submit);

    function submit(){
        let fullNameElement = document.getElementById('fname');
        
        let emailElement = document.getElementById('email');

        let phoneElement = document.getElementById('phone');

        let addressElement = document.getElementById('address');

        let postCodeElement = document.getElementById('code');

        let ulElement = document.getElementById('infoPreview');

        let liFullNameElement = document.createElement('li');
        liFullNameElement.textContent = `Full Name: ${fullNameElement.value}`;

        let liEmailElement = document.createElement('li');
        liEmailElement.textContent = `Email: ${emailElement.value}`;

        let liPhoneElement = document.createElement('li');
        liPhoneElement.textContent = `Phone Number: ${phoneElement.value}`;

        let liAddressElement = document.createElement('li');
        liAddressElement.textContent = `Address: ${addressElement.value}`;

        let liPostCodeElement = document.createElement('li');
        liPostCodeElement.textContent = `Postal Code: ${postCodeElement.value}`;

        if(fullNameElement.value.length > 0 && emailElement.value.length > 0){
          ulElement.appendChild(liFullNameElement);
          ulElement.appendChild(liEmailElement);
          ulElement.appendChild(liPhoneElement);
          ulElement.appendChild(liAddressElement);
          ulElement.appendChild(liPostCodeElement);

          let valuesArr = [fullNameElement.value, emailElement.value, phoneElement.value, addressElement.value, postCodeElement.value];

          fullNameElement.value = '';
          emailElement.value = '';
          phoneElement.value = '';
          addressElement.value = '';
          postCodeElement.value = '';

          submitBtn.disabled = true;

          let editBtn = document.getElementById('editBTN');
          let continueBtn = document.getElementById('continueBTN');

          editBtn.disabled = false;
          continueBtn.disabled = false;

          editBtn.addEventListener('click', edit);
          continueBtn.addEventListener('click', continuefnc);

          function edit(){
            fullNameElement.value = valuesArr[0];
            emailElement.value = valuesArr[1];
            phoneElement.value = valuesArr[2];
            addressElement.value = valuesArr[3];
            postCodeElement.value = valuesArr[4];

            ulElement.innerHTML = '';

            editBtn.disabled = true;
            continueBtn.disabled = true;
            submitBtn.disabled = false;
          }

          function continuefnc(){
            let blockElement = document.getElementById('block');
            blockElement.innerHTML = '';

            let h3Element = document.createElement('h3');
            h3Element.textContent = 'Thank you for your reservation!';

            blockElement.appendChild(h3Element);
          }

        }
    }
}
