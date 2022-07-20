const library = require('../03.Library');
const {assert} = require('chai');

describe("Tests …", function() {
    describe("test calcPriceOfBook fucntion", function() {
        it("shoud throw when book name is not a string", function() {
            assert.throws(() =>  library.calcPriceOfBook(55, 2019), Error);
        });
        it("shoud throw when book price is not a number", function() {
            assert.throws(() =>  library.calcPriceOfBook('pesho', 'gosho'), Error);
        });
        it("shoud correct price depending the year", function() {
            let expectedResult = `Price of pesho is 10.00`;

            assert.equal(library.calcPriceOfBook('pesho', 1975), expectedResult)
        });
        it("shoud correct price depending the year", function() {
            let expectedResult = `Price of pesho is 20.00`;

            assert.equal(library.calcPriceOfBook('pesho', 1981), expectedResult)
        });
        it("shoud correct price depending the year", function() {
            let expectedResult = `Price of pesho is 10.00`;

            assert.equal(library.calcPriceOfBook('pesho', 1980), expectedResult)
        });
     });
     describe("test findBook fucntion", function() {
        it("shoud throw when array length is zero", function() {
            assert.throws(()=> library.findBook([], 'pesho'), Error);
        });
        it("shoud return correct message when the book is found", function() {
            let expectedResult = 'We found the book you want.';

            assert.equal(library.findBook(['gogi', 'pepi', 'maria'], 'pepi'), expectedResult);
        });
        it("shoud return correct message when the book is not found", function() {
            let expectedResult = 'The book you are looking for is not here!';

            assert.equal(library.findBook(['gogi', 'pepi', 'maria'], 'pesho'), expectedResult);
        });
     });
     describe("test arrangeTheBooks fucntion", function() {
        it("shoud throw when count is not a number", function() {
            assert.throws(()=> library.arrangeTheBooks('peshko'), Error);
        });
        it("shoud throw when count is negative number", function() {
            assert.throws(()=> library.arrangeTheBooks(-5), Error);
        });
        it("shoud throw when count is not a number", function() {
            assert.throws(()=> library.arrangeTheBooks('5'), Error);
        });
        it('Shoud return correct message', function(){
            let expectedResult = 'Great job, the books are arranged.';

            assert.equal(library.arrangeTheBooks(5), expectedResult);
        });
        it('Shoud return correct message', function(){
            let expectedResult = 'Great job, the books are arranged.';

            assert.equal(library.arrangeTheBooks(40), expectedResult);
        });
        it('Shoud return correct message', function(){
            let expectedResult = 'Great job, the books are arranged.';

            assert.equal(library.arrangeTheBooks(0), expectedResult);
        });
        it('Shoud return correct message', function(){
            let expectedResult = 'Insufficient space, more shelves need to be purchased.';

            assert.equal(library.arrangeTheBooks(41), expectedResult);
        });
     });
});
