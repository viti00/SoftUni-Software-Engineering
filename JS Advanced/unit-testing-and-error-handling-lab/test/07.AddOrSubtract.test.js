
const {assert} = require('chai');
const createCalculator = require('../07.AddOrSubtract').createCalculator;

describe('Testing 07.AddOrSubstract', () => {
    let calc;
    beforeEach(() => {
        calc = createCalculator();
    })
    it('Shoud return value when get function is called', () => {
        let expectedResult = 0;

        assert.equal(calc.get(), expectedResult);
    });

    it('Shoud add successful number', () => {
        let expectedResult = 2;

        calc.add(2);

        assert.equal(calc.get(), expectedResult);
    });

    it('Shoud subtract successful number', () => {
        let expectedResult = -2;

        calc.subtract(2);

        assert.equal(calc.get(), expectedResult);
    });

    it('Shoud return NaN when add with string', () => {
      
        calc.add('hello');
        let value = calc.get();
        assert.isNaN(value);
    });

    it('Shoud return NaN when subtract with string', () => {
        
        calc.subtract('hello');
        let value = calc.get();
        assert.isNaN(value);
    });
        
});