function oldBooks(input){
    let bookName = input.shift();

    let command = input.shift();
    let counter = 0;
    let i = 0;


    while(command != "No More Books"){
        let currBook = command;

        if(currBook == bookName){
            console.log(`You checked ${counter} books and found it.`);
            break;
        }

        counter++;

        command = input[i];
        i++;
    }

    if (bookName != command){
        console.log("The book you search is not here!");
        console.log(`You checked ${counter} books.`);
    }
}

oldBooks(["Troy", "mecho puh", "pod igogoto", "No More Books"]);