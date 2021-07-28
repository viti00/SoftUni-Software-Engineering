function metricConverter(input){
    let value = Number(input[0]);
    let firstMetric = input[1];
    let secondMetric = input[2];

    if (firstMetric == "mm"){
        if (secondMetric == "cm"){
            value /= 10;
        }
        else if (secondMetric == "m"){
            value /= 1000;
        }
    }
    else if (firstMetric == "cm"){
        if (secondMetric == "mm"){
            value *= 10;
        }
        else if (secondMetric == "m"){
            value /= 100;
        }
    }
    else if (firstMetric == "m"){
        if (secondMetric == "mm"){
            value *= 1000;
        }
        else if (secondMetric == "cm"){
            value *= 100;
        }
    }

    console.log(value.toFixed(3));
}

metricConverter(["1201.34", "mm", "cm"]);