function convertToJSON(name, lastName, hairColor){
    let myObj ={};

    myObj.name = name;
    myObj.lastName = lastName;
    myObj.hairColor = hairColor;

    let json = JSON.stringify(myObj);


    console.log(json);
}

convertToJSON('George',
'Jones',
'Brown'
);