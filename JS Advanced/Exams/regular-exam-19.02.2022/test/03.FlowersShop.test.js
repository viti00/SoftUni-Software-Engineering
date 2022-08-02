const flowerShop = require('../03.FlowersShop');
const {assert} = require('chai');

describe("Tests …", function() {
    describe("Test calcPriceOfFlowers function", function() {
        it("Shoud throw when parameters are invalid", function() {
            assert.throws(()=> flowerShop.calcPriceOfFlowers(5, 5, 2),Error);
        });
        it("Shoud throw when parameters are invalid", function() {
            assert.throws(()=> flowerShop.calcPriceOfFlowers('temenuga', '5', 2), Error);
        });
        it("Shoud throw when parameters are invalid", function() {
            assert.throws(()=> flowerShop.calcPriceOfFlowers('temenuga', 5, 'pesho'),Error);
        });
        it("Shoud return the correct message", function() {
            let expectedResult = `You need $10.00 to buy temenuga!`;

            assert.equal(flowerShop.calcPriceOfFlowers('temenuga', 5, 2), expectedResult);
        });
        it("Shoud return the correct message", function() {
            let expectedResult = `You need $-10.00 to buy temenuga!`;

            assert.equal(flowerShop.calcPriceOfFlowers('temenuga', -5, 2), expectedResult);
        });
        it("Shoud return the correct message", function() {
            let expectedResult = `You need $0.00 to buy temenuga!`;

            assert.equal(flowerShop.calcPriceOfFlowers('temenuga', 0, 2), expectedResult);
        });
        it("Shoud return the correct message", function() {
            let expectedResult = `You need $0.00 to buy temenuga!`;

            assert.equal(flowerShop.calcPriceOfFlowers('temenuga', 5, 0), expectedResult);
        });
        it("Shoud return the correct message", function() {
            let expectedResult = `You need $-10.00 to buy temenuga!`;

            assert.equal(flowerShop.calcPriceOfFlowers('temenuga', 5, -2), expectedResult);
        });
        it("Shoud return the correct message", function() {
            let expectedResult = `You need $10.00 to buy temenuga!`;

            assert.equal(flowerShop.calcPriceOfFlowers('temenuga', -5, -2), expectedResult);
        });
     });
    describe("Test checkFlowersAvailable function", function() {
        it("Shoud return the correct message when the flower is available", function() {
            let expectedResult = `The temenuga are available!`;

            assert.equal(flowerShop.checkFlowersAvailable('temenuga', ['gogi', 'temenuga', 'pesho']), expectedResult);
        });
        it("Shoud return the correct message when the flower is not available", function() {
            let expectedResult = `The temenuga are sold! You need to purchase more!`;

            assert.equal(flowerShop.checkFlowersAvailable('temenuga', ['gogi', 'tema', 'pesho']), expectedResult);
        });
     });
    describe("Test sellFlowers function", function() {
        it("Shoud throw when the parameters are invalid", function() {
            assert.throws(()=> flowerShop.sellFlowers({}, 3), Error);
        });
        it("Shoud throw when the parameters are invalid", function() {
            assert.throws(()=> flowerShop.sellFlowers([], 'pesho'), Error);
        });
        it("Shoud throw when the parameters are invalid", function() {
            assert.throws(()=> flowerShop.sellFlowers([], -3), Error);
        });
        it("Shoud throw when the parameters are invalid", function() {
            assert.throws(()=> flowerShop.sellFlowers(['Rose', 'Temenuga'], 3), Error);
        });
        it("Shoud return the correct output", function() {
            let expectedResult = `Rose / Orchid`;

            assert.equal(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 1), expectedResult);
        });
        it("Shoud return the correct output", function() {
            let expectedResult = `Lily / Orchid`;

            assert.equal(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 0), expectedResult);
        });

     });
});
