const testNumbers = require('../03.TestNumbers');
const {assert} = require('chai');

describe("Tests …", function() {
    describe("sumNumbers function", function() {
        it("shoud return undefined when parameters not a number", function() {
            assert.isUndefined(testNumbers.sumNumbers('5', 2));
            assert.isUndefined(testNumbers.sumNumbers(1, '2'));
            assert.isUndefined(testNumbers.sumNumbers('1', '3'));
        });
        it('shoud return correct result when everything is fine', function(){
            let expected = 5.23;
            assert.equal(testNumbers.sumNumbers(2, 3.23), expected);
        });
        it('shoud return correct result when everything is fine', function(){
            let expected = 0.00;
            assert.equal(testNumbers.sumNumbers(0, 0), expected);
        });
        it('shoud return correct result when everything is fine', function(){
            let expected = -5.00;
            assert.equal(testNumbers.sumNumbers(-2, -3), expected);
        });
        it('shoud return correct result when everything is fine', function(){
            let expected = 1.00;
            assert.equal(testNumbers.sumNumbers(2, -1), expected);
        });
     });
     describe('numberChecker function', function(){
        it('shoud trhow error when argument is not a number', function(){
            assert.throws(() => testNumbers.numberChecker('pesho'), Error);
        });
        it('shoud return \'The number is even!\' when argument is a even number', function(){
            let expected = 'The number is even!';

            assert.equal(testNumbers.numberChecker('4'), expected);
        });
        it('shoud return \'The number is odd!\' when argument is a odd number', function(){
            let expected = 'The number is odd!';

            assert.equal(testNumbers.numberChecker('5'), expected);
        });
        it('shoud return \'The number is even!\' when argument is a 0 number', function(){
            let expected = 'The number is even!';

            assert.equal(testNumbers.numberChecker('0'), expected);
        });
        it('shoud return \'The number is odd!\' when argument is a -1 number', function(){
            let expected = 'The number is odd!';

            assert.equal(testNumbers.numberChecker(-1), expected);
        });
        it('shoud return \'The number is even!\' when argument is a -2 number', function(){
            let expected = 'The number is even!';

            assert.equal(testNumbers.numberChecker('-2'), expected);
        });
     });
    describe('averegaesumArray function', function(){
        it('shoud return correct sum from array elements', function(){
            let expected = 2;

            assert.equal(testNumbers.averageSumArray([1,2,3]), expected);
        });
    });
});
