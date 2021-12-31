function reverse(input){
    let string = input;

    let reversed = string.split('').reverse().join('');

    console.log(reversed);
}

reverse("hello");