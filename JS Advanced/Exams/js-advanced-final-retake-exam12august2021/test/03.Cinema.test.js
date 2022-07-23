const cinema = require('../03.Cinema');
const {assert} = require('chai');

describe("Tests …", function() {
    describe("test showMovies function", function() {
        it("shoud return 'There are currently no movies to show.' when lenght is zero", function() {
            let expectedResult = 'There are currently no movies to show.';

            assert.equal(cinema.showMovies([]), expectedResult);
        });
        it("shoud return array splited by comma and space", function() {
            let expectedResult = 'Kong, Godzila';

            assert.equal(cinema.showMovies(['Kong', 'Godzila']), expectedResult);
        });

        it("shoud return array splited by comma and space", function() {
            let expectedResult = '1, 2';

            assert.equal(cinema.showMovies([1, 2]), expectedResult);
        });
     });
     describe('test ticketPrice function', function(){
        it("shoud throw error when projection is not in schedule", function() {
            
            assert.throws(()=> cinema.ticketPrice('peshko'), Error);
        });
        it("shoud return price for ticket when movie is in schedule", function() {
            let expectedResult = 12.00;

            assert.equal(cinema.ticketPrice('Premiere'), expectedResult);
        });
     });
     describe('test swapSeatsInHall', function(){
        it('shoud return "Unsuccessful change of seats in the hall." when have problem with seats', function(){
            let expectedResult = 'Unsuccessful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall(2.5, 3), expectedResult);
        });
        it('shoud return "Unsuccessful change of seats in the hall." when have problem with seats', function(){
            let expectedResult = 'Unsuccessful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall('2', 3), expectedResult);
        });
        it('shoud return "Unsuccessful change of seats in the hall." when have problem with seats', function(){
            let expectedResult = 'Unsuccessful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall(0, 3), expectedResult);
        });
        it('shoud return "Unsuccessful change of seats in the hall." when have problem with seats', function(){
            let expectedResult = 'Unsuccessful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall(25, 3), expectedResult);
        });
        it('shoud return "Unsuccessful change of seats in the hall." when have problem with seats', function(){
            let expectedResult = 'Unsuccessful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall(2, -3), expectedResult);
        });
        it('shoud return "Unsuccessful change of seats in the hall." when have problem with seats', function(){
            let expectedResult = 'Unsuccessful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall(2, 2), expectedResult);
        });
        it('shoud return "Unsuccessful change of seats in the hall." when have problem with seats', function(){
            let expectedResult = 'Unsuccessful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall('2', '3'), expectedResult);
        });
        it('shoud return "Successful change of seats in the hall." when everything is correct', function(){
            let expectedResult = 'Successful change of seats in the hall.';

            assert.equal(cinema.swapSeatsInHall(10, 3), expectedResult);
        });
     });
});
