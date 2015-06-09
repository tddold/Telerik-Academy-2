function solve(params) {
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];
    var answer = 0,x1,x2,x3,diff,sum, minDiff =s;
    // Your solution here
    for (x1=0;x1<=s/c1;x1+=1){
        for (x2=0;x2<=s/c2;x2+=1){
            for (x3=0;x3<=s/c3;x3+=1){
               sum = x1*c1+x2*c2 + x3*c3;
                diff = s -sum;
                if (diff>=0&&diff<minDiff){
                    minDiff = diff;
                }
            }
        }
    }
    console.log(s-minDiff);
}

function input(){
    var params=[
        110,
        19,
        29,
        39
    ]
    solve(params);
}



