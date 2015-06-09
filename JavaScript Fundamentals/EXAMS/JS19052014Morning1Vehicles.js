/**
 * Created by tishinov on 5.6.2015 ?..
 */
function solve(params) {
    var s = params;
    var count = 0,
        i,
        j,
        k;

    for(i=0;i<=s/3;i+=1){
        for(j=0;j<=s/4;j+=1){
            for(k=0;k<=s/10;k+=1){
                if((i * 3 + j*4+k*10) ===s){
                    count+=1;
                }
            }
        }
    }
    console.log(count);
}


function input(){
    solve(40);
}