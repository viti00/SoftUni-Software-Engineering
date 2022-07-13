const numberOperations = require('../03.number-operations-resources');
const { assert } = require('chai');

describe("Tests …", function () {
    describe("test power function", function () {
        it("shoud powered number", function () {
            let expectedResult = 4;

            assert.equal(numberOperations.powNumber(2), expectedResult);
        });
    });
    describe('test number checker function', function () {
        it('Shoud throw exception if cant parse input to number', function () {
            assert.throws(() => numberOperations.numberChecker('peshko'), Error);
        });
        it('Shoud return correct message when number is lower than 100', function () {
            let expectedResult = 'The number is lower than 100!';

            assert.equal(numberOperations.numberChecker('99'), expectedResult);
        });
        it('Shoud return correct message when number is bigger than 100', function () {
            let expectedResult = 'The number is greater or equal to 100!';

            assert.equal(numberOperations.numberChecker('901'), expectedResult);
        });
        it('Shoud return correct message when number is equal than 100', function () {
            let expectedResult = 'The number is greater or equal to 100!';

            assert.equal(numberOperations.numberChecker('100'), expectedResult);
        });
    });
    describe('test sum arrays function', function () {
        it('Shoud return correct array', function () {
            let expectedResult = [4, 8, 7];

            let arr1 = [1, 2, 3];
            let arr2 = [3, 6, 4];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });
        it('Shoud return correct array', function () {
            let expectedResult = [4, 8, 7, 10];

            let arr1 = [1, 2, 3, 10];
            let arr2 = [3, 6, 4];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });
        it('Shoud return correct array', function () {
            let expectedResult = [4, 8, 7, 45];

            let arr1 = [1, 2, 3];
            let arr2 = [3, 6, 4, 45];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });
        it('Shoud return correct array', function () {
            let expectedResult = [];

            let arr1 = [];
            let arr2 = [];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });

        it('Shoud return correct array', function () {
            let expectedResult = ['peshogogo', 'chikirogo'];

            let arr1 = ['pesho', 'chiki'];
            let arr2 = ['gogo', 'rogo'];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });
        it('Shoud return correct array', function () {
            let expectedResult = ['pesho1', 'chiki2'];

            let arr1 = ['pesho', 'chiki'];
            let arr2 = [1, 2];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });

        it('Shoud return correct array', function () {
            let expectedResult = ['pesho1', 'chiki'];

            let arr1 = ['pesho', 'chiki'];
            let arr2 = [1];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });

        it('Shoud return correct array', function () {
            let expectedResult = ['pesho1', 'chiki2', 3, 5];

            let arr1 = ['pesho', 'chiki'];
            let arr2 = [1, 2, 3, 5];

            assert.sameMembers(numberOperations.sumArrays(arr1, arr2), expectedResult);
        });
    });

});
