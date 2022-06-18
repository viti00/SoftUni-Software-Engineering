function solve(numbers, sortType){
    if(sortType === 'asc'){
        numbers = numbers.sort((a, b) => a - b);
    }
    else if (sortType === 'desc'){
        numbers = numbers.sort((a, b) => b - a);
    }

    return numbers;
}

solve([14, 7, 17, 6, 8], 'asc');