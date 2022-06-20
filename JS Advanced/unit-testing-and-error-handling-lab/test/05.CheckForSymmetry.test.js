const isSymmetric = require('../05.CheckForSymmetry');
const {assert} = require('chai');


describe('Testing 05.CheckForSymmetry', () => {
    it('Shoud fail when argument is not array', () => {
        let arr = {};

        let expectedResult = false;

        let actualResult = isSymmetric(arr);

        assert.equal(actualResult, expectedResult);
    });

    it('Shoud pass when array is symmetric', () => {
        let arr = [1, 2, 1];

        let expectedResult = true;

        let actualResult = isSymmetric(arr);

        assert.equal(actualResult, expectedResult);
    });

    it('Shoud fail when array is not symmetric', () => {
        let arr = [1, 1, 2];

        let expectedResult = false;
        
        assert.equal(isSymmetric(arr), expectedResult);
    });

    it('Shoud fail when array have different types element', ()=> {
        let arr = ['1', 2, 1];

        let expectedResult = false;

        assert.equal(isSymmetric(arr), expectedResult);
    });

    it('Shoud pass when array is empty', () => {
        let arr = [];

        let expectedResult = true;

        assert.equal(isSymmetric(arr), expectedResult);
    });
});