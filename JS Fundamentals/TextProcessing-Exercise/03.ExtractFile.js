function exctractFile(input){

    let fileNameStartIndex = input.lastIndexOf("\\") + 1;
    let fileNameLastIndex = input.lastIndexOf(".");

    let fileName = input.substr(fileNameStartIndex, fileNameLastIndex - fileNameStartIndex)

    let extensionName = input.substr(fileNameLastIndex + 1);

    console.log(`File name: ${fileName}`);
    console.log(`File extension: ${extensionName}`);
}

exctractFile('C:\\Internal\\training-internal\\Template.pptx');