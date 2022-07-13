const dealership = require('../03.Dealership');
const {assert} = require('chai');

describe("Tests …", function() {
    describe("Test new car cost function", function() {

        it("Shoud return discount price when old car is in list", function() {
            let expetedResult = 10000;

            assert.equal(dealership.newCarCost('Audi A4 B8', 25000), expetedResult);
        });
        it("Shoud return same price when old car is not in list", function() {
            let expetedResult = 25000;

            assert.equal(dealership.newCarCost('Audi A4', 25000), expetedResult);
        });
        it("Shoud return same price when old car is not in list", function() {
            let expetedResult = -10000;

            assert.equal(dealership.newCarCost('Audi A4 B8', 5000), expetedResult);
        });
     });
     describe("Test carEquipment function", function() {

        it("Shoud return array whit extras", function() {
            let expetedResult = ['seats', 'belts'];

            assert.sameMembers(dealership.carEquipment(['AZ', 'seats','ti','belts'], [1, 3]), expetedResult);
        });
        it("Shoud return array whit extras", function() {
            let expetedResult = ['seats', undefined, undefined];

            assert.sameMembers(dealership.carEquipment(['AZ', 'seats','ti'], [1, 3, 4]), expetedResult);
        });
     });

     describe("Test eiroCategory function", function() {

        it("Shoud return correct message when car euro category is argument", function() {
            let expetedResult = `We have added 5% discount to the final price: 14250.`;

            assert.equal(dealership.euroCategory(4), expetedResult);
        });
        it("Shoud return correct message when car euro category is argument", function() {
            let expetedResult = `Your euro category is low, so there is no discount from the final price!`;

            assert.equal(dealership.euroCategory(2), expetedResult);
        });
     });
});
