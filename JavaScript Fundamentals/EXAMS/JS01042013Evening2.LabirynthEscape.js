function Solve(params) {
    var dims = params[0],startPos = params[1], x, matrix = [], matrixValues=[], inMatrix = true, playerCoords, cells, posX, posY, sum;
    dims = dims.split(' ');
    dims[0]=parseInt(dims[0]);
    dims[1]=parseInt(dims[1]);
    for (x =0;x<dims[0];x+=1){
        matrix[x]=[];
        matrixValues[x]=[];
        for (y =0;y<dims[1];y+=1){
            matrix[x].push(params[x+2][y]);
            matrixValues[x].push(y+1+x*(dims[1]));
            matrixValues[x][y] = matrixValues[x][y] * 1;
        }
    }
    playerCoords=params[1].split(' ');
    posX=playerCoords[0] * 1;
    posY=playerCoords[1] * 1;
    sum = 0;
    sum = matrixValues[posX][posY];
    matrixValues[posX][posY] ='visited';
    cells = 1;
    while(inMatrix){
        switch(matrix[posX][posY]){
            case 'l':posY=posY -1;break;
            case 'r':posY=posY +1;break;
            case 'u':posX=posX -1;break;
            case 'd':posX=posX +1;break;
        }
        if (posX<0||posX>=dims[0]||
        posY<0||posY>=dims[1]){
            console.log('out ' + sum);
            inMatrix = false;
            break;
        }
        cells = cells+1;
        if (matrixValues[posX][posY] ==='visited'){
            cells = cells -1;
            console.log('lost ' + cells);
            break;
        }
        sum = sum +matrixValues[posX][posY];
        matrixValues[posX][posY] = 'visited';
    }



    // Your code here...
    //return maxSum;

}



function input(){
    var args =[
        "5 8",
        "0 0",
        "rrrrrrrd",
        "rludulrd",
        "durlddud",
        "urrrldud",
        "ulllllll"];
    Solve(args);
}