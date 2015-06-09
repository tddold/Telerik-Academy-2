function Solve(params) {
   var count, i, inputLength = params.length, lines = [], sumOfCoins = 0, numberString, isNumber, x1,x2,x3;
    for (i = 0 ;i < inputLength;i +=1 ){
        lines.push(params[i]);
        isNumber = true
        lines[i] = params[i].trim();
        lines[i] = lines[i].replace(/  +/g, ' ');
        lines[i] = lines[i].split(' ');
        lines[i][0] = lines[i][0].toLowerCase();
        numberString = lines[i][1];
       if (isNaN(numberString)){
           isNumber = false;
       }
        if (lines[i][0]==='coin'&&lines[i][1]*1>-1&&(lines[i][1]*1) % 1 === 0){
            sumOfCoins = sumOfCoins + lines[i][1]*1;
        }
    }
    x1=0;
    x2 =0;
    x3 =0;


    x3 = sumOfCoins %10;
    x2 = (sumOfCoins -x3)/10;
    x2 = x2%10;
    x1 = (sumOfCoins - x3 - x2*10)/100;


    console.log('gold : '+x1);
    console.log('silver : '+x2);
    console.log('bronze : '+x3);

}



function input(){
    var params =
        ['coin 0','coin 0', '     Coin     5    ', 'coin 10', 'coin 20', 'coin 50', 'coin 100', 'coin 200', 'coin 500','cigars 1']
    ;
    Solve(params)
}

function input2(){
    var params =
            ['Coin 0']
        ;
    Solve(params)
}