/**
 * Created by private on 6.6.2015 ã..
 */
function Solve(params) {
    var N = parseInt(params[0]), m,i, j,k,mask,maskAndI,bit, arrayOfNumbers = [],isPreviousOne,tempPosStartCounter,sum = 0,maxSum = -1000000000,posStartCounter,posEndCounter,tempCount;
    var answer = 0;
    for (m =0;m<N;m+=1){
        arrayOfNumbers.push(params[m+1]*1);
    }

    var binaryTop = Math.pow(2, N) - 1;
    for (i = 0; i <= binaryTop; i++)
    {
        for (j = 0; j < N; j++)
        {
            mask = 1 << j;
            maskAndI = mask & i;
            bit = maskAndI >> j;
            if (bit === 1)
            {
                if (isPreviousOne === false)
                {
                    tempPosStartCounter = j;
                }
                isPreviousOne = true;
                sum = arrayOfNumbers[j] + sum;
                if (sum > maxSum)
                {
                    posStartCounter = tempPosStartCounter;
                    posEndCounter = tempCount + posStartCounter;
                    maxSum = sum;
                }
                tempCount++;
            }
            if ((bit === 0&&isPreviousOne==true)||j===N-1)
            {
                isPreviousOne = false;
                break;
            }
        }
        tempCount = 0;
        sum = 0;
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