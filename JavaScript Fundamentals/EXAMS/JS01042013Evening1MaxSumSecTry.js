
function Solve(params) {
    var N = parseInt(params[0]), m, i,k,length,arrayOfNumbers = [],sum, maxSum=-1000000000;
    var answer = 0;
    for (m =0;m<N;m+=1){
        arrayOfNumbers.push(params[m+1]*1);
    }
    length = arrayOfNumbers.length;
    for (i = 0; i < length; i++)
    {
        sum = 0;
        for ( k = i; k < length; k++)
        {
            sum += arrayOfNumbers[k];
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
    }




    console.log(maxSum);

    // Your code here...
    //return maxSum;

}



function input(){
    var params = [
        9,
        -9,
        -8,
        -8,
        -7,
        -6,
        -5,
        -1,
        -7,
        -6

    ];
    Solve(params)
}