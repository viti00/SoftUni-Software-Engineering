function solve(library, orders){
    let result = [];

    for (let i = 0; i < orders.length; i++) {
        let object = orders[i].template;

        orders[i].parts.forEach(part => {
            object[part] = library[part]    
        });

        result.push(object);
    }

    return result;
}


let library = {
    print: function () {
      console.log(`${this.name} is printing a page`);
    },
    scan: function () {
      console.log(`${this.name} is scanning a document`);
    },
    play: function (artist, track) {
      console.log(`${this.name} is playing '${track}' by ${artist}`);
    },
  };

  let orders = [
    {
      template: { name: 'ACME Printer'},
      parts: ['print']      
    },
    {
      template: { name: 'Initech Scanner'},
      parts: ['scan']      
    },
    {
      template: { name: 'ComTron Copier'},
      parts: ['scan', 'print']      
    },
    {
      template: { name: 'BoomBox Stereo'},
      parts: ['play']      
    }
  ];


const products = solve(library, orders);
console.log(products);

  