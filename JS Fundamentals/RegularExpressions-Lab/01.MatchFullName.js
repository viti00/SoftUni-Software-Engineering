function matchFullName(input){
    let pattern = /\b[A-Z][a-z]+ [A-Z][a-z]+\b/g;
    debugger;

    let matches = [];
    let match = "";
    while((match = pattern.exec(input)) !== null){
        matches.push(match[0]);
    }
    console.log(matches.join(" "));
}

matchFullName("Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan	Ivanov"
);