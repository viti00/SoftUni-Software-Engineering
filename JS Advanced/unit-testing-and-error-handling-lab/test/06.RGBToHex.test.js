const rgbToHexColor = require('../06.RGBToHex');
const {assert} = require('chai');

describe('Testing 06.RgbToHex', () => {
    it('Shoud fail when any of arguments is not a number and not in range 0-255', () => {
        let expectedResult = undefined;

        assert.equal(rgbToHexColor(-1, 253, 2), expectedResult);
        assert.equal(rgbToHexColor(256, 253, 3), expectedResult);
        assert.equal(rgbToHexColor('253', 253, 3), expectedResult);


        assert.equal(rgbToHexColor(155, -10, 3), expectedResult);
        assert.equal(rgbToHexColor(155, 256, 3), expectedResult);
        assert.equal(rgbToHexColor(155, '250', 3), expectedResult);

        assert.equal(rgbToHexColor(200, 251, null), expectedResult);
        assert.equal(rgbToHexColor(200, 251, -20), expectedResult);
        assert.equal(rgbToHexColor(200, 251, 1550), expectedResult);
    });

    it('Shoud return color in hex', () => {

        assert.equal(rgbToHexColor(0, 0, 0), '#000000');

        assert.equal(rgbToHexColor(255, 158, 170),'#FF9EAA');

        assert.equal(rgbToHexColor(255,255,255), '#FFFFFF');
    });

});