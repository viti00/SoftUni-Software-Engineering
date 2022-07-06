
    class Contact{
        constructor(firstName, lastName, phone, email){
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.online = false;
        }
    
        render(id){
    
            let newArticleElement = document.createElement('article');
    
            let newDivClassTitleElement = document.createElement('div');
            newDivClassTitleElement.className = 'title';
            newDivClassTitleElement.textContent = `${this.firstName} ${this.lastName}`;
    
            let newButtonElement = document.createElement('button');
            newButtonElement.textContent = '&#8505;';
    
            newDivClassTitleElement.appendChild(newButtonElement);
    
            let newDivClassInfoElement = document.createElement('div');
            newDivClassInfoElement.className = 'info';
    
            let newSpanElementPhone = document.createElement('span');
            newSpanElementPhone.textContent = `&phone; ${this.phone}`;
    
            let newSpanElementEmail = document.createElement('span');
            newSpanElementEmail.textContent = `&#9993; ${this.email}`;
    
            newDivClassInfoElement.appendChild(newSpanElementPhone);
            newDivClassInfoElement.appendChild(newSpanElementEmail);
    
            newArticleElement.appendChild(newDivClassTitleElement);
            newArticleElement.appendChild(newDivClassInfoElement);
    
            let remindElement = document.getElementById(id);
    
            remindElement.appendChild(newArticleElement);
        }
    
    }

// let contacts = [
//     new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
//     new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
//     new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
//   ];
//   contacts.forEach(c => c.render('main'));
  
//   // After 1 second, change the online status to true
//   setTimeout(() => contacts[1].online = true, 2000);
  