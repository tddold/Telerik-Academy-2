function solve(params) {
    var dims = params[0].split(' '), xCounter, yCounter,matrix=[],matrixValues=[],posX,posY, inMatrix = true,weeds= 0,jumps=0;
    for (xCounter = 0;xCounter<dims[0];xCounter+=1){
        matrix[xCounter]=[];
        matrixValues[xCounter]=[];
        for(yCounter = 0;yCounter<dims[1];yCounter+=1){
            matrix[xCounter][yCounter]=params[xCounter+1][yCounter];
            matrixValues[xCounter][yCounter] = Math.pow(2,xCounter) - yCounter;
        }
    }
    posX = dims[0] -1;
    posY = dims[1] -1;
    weeds = matrixValues[posX][posY];
    matrixValues[posX][posY] = 'visited';
    while (inMatrix){
        switch(matrix[posX][posY]){
            case '1':posX=posX-2;posY=posY+1;break;
            case '2':posX=posX-1;posY=posY+2;break;
            case '3':posX=posX+1;posY=posY+2;break;
            case '4':posX=posX+2;posY=posY+1;break;
            case '5':posX=posX+2;posY=posY-1;break;
            case '6':posX=posX+1;posY=posY-2;break;
            case '7':posX=posX-1;posY=posY-2;break;
            case '8':posX=posX-2;posY=posY-1;break;
        }

        if (posX<0||
            posX>dims[0]-1||
            posY<0||
            posY>dims[1]-1){
            inMatrix = false;
            console.log("Go go Horsy! Collected %d weeds",weeds);
            break;
        }
        if ( matrixValues[posX][posY] === 'visited'){
            jumps= jumps+1;
            console.log("Sadly the horse is doomed in %d jumps",jumps)
            break;
        }
        jumps+=1;
        weeds = weeds +matrixValues[posX][posY];
        matrixValues[posX][posY] = 'visited';

    }

}

function input(){
    args = [
        '3 5',
        '54561',
        '43328',
        '52388',
    ];


    solve(args);
}



