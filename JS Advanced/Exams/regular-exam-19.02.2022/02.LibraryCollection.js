class LibraryCollection {
    constructor(capacity) {
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor) {
        if (this.books.length + 1 > this.capacity) {
            throw new Error('Not enough space in the collection.');
        }


        this.books.push({ bookName: bookName, bookAuthor: bookAuthor, payed: false });

        return `The ${bookName}, with an author ${bookAuthor}, collect.`;
    }

    payBook(bookName) {
        let book = this.books.find(x => x.bookName == bookName);

        if (book == undefined) {
            throw new Error(`${bookName} is not in the collection.`);
        }

        if (book.payed == true) {
            throw new Error(`${bookName} has already been paid.`);
        }

        book.payed = true;
        return `${bookName} has been successfully paid.`;
    }

    removeBook(bookName) {
        let book = this.books.find(x => x.bookName == bookName);

        if (book == undefined) {
            throw new Error(`The book, you're looking for, is not found.`);
        }

        if (book.payed == false) {
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }

        this.books = this.books.filter(x => x.bookName != bookName);

        return `${bookName} remove from the collection.`;
    }

    getStatistics(bookAuthor) {

        let result = [];
        if (bookAuthor == undefined) {
            result.push(`The book collection has ${this.capacity - this.books.length} empty spots left.`);
            for (const book of this.books.sort((a, b) => a.bookName.localeCompare(b.bookName))) {
                let { bookName, bookAuthor, payed } = book;
                let payedType = '';
                if (payed == true) {
                    payedType = 'Has Paid';
                }
                else {
                    payedType = 'Not Paid';
                }
                result.push(`${bookName} == ${bookAuthor} - ${payedType}.`);
            }
        }
        else {
            let filtered = this.books.filter(x => x.bookAuthor == bookAuthor);
            if (filtered.length > 0) {
                for (const book of this.books) {
                    let { bookName, bookAuthor, payed } = book;
                    let payedType = '';
                    if (payed == true) {
                        payedType = 'Has Paid';
                    }
                    else {
                        payedType = 'Not Paid';
                    }
                    result.push(`${bookName} == ${bookAuthor} - ${payedType}.`);
                }
            }
            else {
                throw new Error(`${bookAuthor} is not in the collection.`);
            }
        }

        return result.join('\n');
    }
}

debugger;
const library = new LibraryCollection(5)
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
library.addBook('Ulysses', 'James Joyce');
console.log(library.getStatistics());




