function Solve(params) {
    var N = parseInt(params[0]), i, j, arrayOfNumbers = [], count;
    var answer = 0;
    for (i =0;i<N; i+=1){
        arrayOfNumbers[i] = params[i + 1];
    }
    // Your code here...

    count = 0;
    for (j = 0;j <N -1;j+=1){
        if (arrayOfNumbers[j+1]>=arrayOfNumbers[j]){
            continue;
        } else{
            count+=1;
        }
    }
    count = count + 1;
    return count;
}

function input() {
    var params =[
        9,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8,
        8

    ];
    Solve(params);
}
