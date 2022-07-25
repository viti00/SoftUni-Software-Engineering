//const {Repository} = require('../02.Repository');
//const {assert} = require('chai');

describe("Tests …", function() {
    let repo = {}

	beforeEach(() => repo = new Repository({
		name: 'string',
		age: 'number',
		birthday: 'object'
	}))
    describe('testing count prop', () => {
		it(`repo.count -> 0`, () => {
			assert.equal(repo.count, 0);
		})

	});
    describe("Test add function", function() {
        it("Shoud throw when any propery mising", function() {

            let entity = {
                name: "Pesho",
                age: 22,
            };
            assert.throws(()=> repo.add(entity),Error);
        });
        it("Shoud throw when any propery mising", function() {

            let entity = {
                name: "Pesho",
                birthday: new Date(1998, 0, 7)
            }
            assert.throws(()=> repo.add(entity),Error);
        });
        it("Shoud throw when any propery mising", function() {

            let entity = {
                age: 22,
                birthday: new Date(1998, 0, 7)
            }
            assert.throws(()=> repo.add(entity),Error);
        });
        
        it("Shoud throw when any propery type is wrong", function() {

            entity = {
                name: 'Gosho',
                age: '22',
                birthday: new Date(1998, 0, 7)
            };
            
            
            assert.throws(()=> repo.add(entity),Error);
        });
        it("Shoud throw when any propery type is wrong", function() {

            entity = {
                name: 1,
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            
            
            assert.throws(()=> repo.add(entity),Error);
        });
        it("Shoud throw when any propery type is wrong", function() {

            entity = {
                name: 1,
                age: 22,
                birthday: '21.04.1999'
            };
            
            
            assert.throws(()=> repo.add(entity),Error);
        });

        it("Shoud return id when adding is success", function() {

            entity1 = {
                name: 'Pesho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            
            
            let expectedResult = 1;
            repo.add(entity1);
            assert.equal(repo.add(entity2), expectedResult);
        });
        it("Shoud increase count with 1", function() {

            entity1 = {
                name: 'Pesho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            }; 
            
            let expectedResult = 1;
            repo.add(entity1);
            assert.equal(repo.count, expectedResult);
        });

     });
     describe("Test getId function", function() {
        it('Shoud retunr entity with given id', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);
            repo.add(entity2);
            expectedResult = {name: 'Gosho', age: 22, birthday: new Date(1998, 0, 7)};

            assert.equal(JSON.stringify(repo.getId(1)),JSON.stringify(expectedResult));
        });
        it('Shoud throw when id not found', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);
            repo.add(entity2);

            assert.throws(()=> repo.getId(5), Error);
        });
        it('Shoud throw when id not found', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);
            repo.add(entity2);

            assert.throws(()=> repo.getId(-1), Error);
        });
        it('Shoud throw when id not found', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);
            repo.add(entity2);

            assert.throws(()=> repo.getId('1'), Error);
        });
     });

     describe("Test update function", function() {
        it('Shoud throw when id is no found', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);

            assert.throws(()=> repo.update(4, entity2), Error);
        });

        it('Shoud throw when new entity is not valid', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);

            assert.throws(()=> repo.update(0, entity2), Error);
        });


        it('Shoud change entity with give id with new entity if new entity is correct', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);

            let expectedResult = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            repo.update(0, entity2);

            assert.equal(JSON.stringify(repo.getId(0)), JSON.stringify(expectedResult));
        });
     });

     describe("Test del function", function() {
        it('Shoud throw when id is no found', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);
            repo.add(entity2);

            assert.throws(()=> repo.del(4), Error);
        });

        it('Shoud delete entity when id is found', function(){
            let entity1 = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            entity2 = {
                name: 'Gosho',
                age: 22,
                birthday: new Date(1998, 0, 7)
            };
            repo.add(entity1);
            repo.add(entity2);

            repo.del(1);

            let expectedResult = false;

           assert.equal(repo.data.has(1), expectedResult);
        });
     });
});
