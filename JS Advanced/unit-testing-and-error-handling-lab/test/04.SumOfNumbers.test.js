const sum = require('../04.SumOfNumbers');
const {assert} = require('chai');

describe('Teststing sum of Numbers', () =>{
    it('Shoud pass when sum is correct', () => {
        let arr = [1, 2, 3, 4];

        let expectedResult = 10;

        let actualResult = sum(arr);

        assert.equal(actualResult, expectedResult);
    });
    
});