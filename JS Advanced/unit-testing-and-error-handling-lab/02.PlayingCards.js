function solve(face, suit) {
    debugger;

    let validFaceArr = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];

    let result = '';

    return {
        'face': face,
        'suit': suit,
        toString: () => {
            try{
                if (!validFaceArr.includes(face)) {
                    throw new Error('Error');
                }
                else {
                    switch (suit) {
                        case 'S':
                            result = face + '\u2660';
                            break;
                        case 'H':
                            result = face + '\u2665';
                            break;
                        case 'D':
                            result = face + '\u2666';
                            break;
                        case 'C':
                            result = face + '\u2663';
                            break;
                    }
        
                    return result;
                }
                
            }
            catch(error){
                return (error.message);
            }
        }
    }
}

let card = solve('1', 'C');
console.log(card.toString());

