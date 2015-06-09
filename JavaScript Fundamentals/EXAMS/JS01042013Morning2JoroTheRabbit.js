/**
 * Created by private on 7.6.2015 ã..
 */
function solve(params){
    var dims = params[0],
    dims = dims.split(' '), posX, posY, startPos, i, j, k,
    x = dims[0] * 1, y = dims[1] * 1, matrix = [], result, numberOfJumps, currentX, currentY, jump, inMatrix  = true,sum, jumpsInput;
    startPos = params[1].split(' ')
    posX = startPos[0] * 1;
    posY = startPos[1] * 1;
    jumpsInput = dims[2] * 1;
    for (i =0;i<x;i+=1){
        matrix[i]= [];
        for(j = 0; j < y; j+=1){
            matrix[i].push( j+1+i*y);
        }
    }
    k=2;
    sum = matrix[posX][posY];
    matrix[posX][posY] = 'visited';
    numberOfJumps = 0;
    while (inMatrix){
        jump = params[k].split(' ');
        currentX = jump[0] * 1;
        currentY = jump[1] * 1;
        posX = posX + currentX;
        posY = posY + currentY;
        if (posX <0 || posX >= x||
        posY<0 || posY >= y){
            result = 'escaped ' +sum;
            break;
        } else if (matrix[posX][posY] ==='visited') {
            numberOfJumps = numberOfJumps + 1;
            result = 'caught ' + numberOfJumps;
            break;
        }
        numberOfJumps = numberOfJumps + 1;
        sum = sum + matrix[posX][posY];
        matrix[posX][posY] = 'visited';
        k+=1;
        if (k === jumpsInput + 2){
            k = 2;
        }
    }

    return result;
}



function input(){
    var args =[
            '6 7 3',
            '0 0',
            '2 2',
            '-2 2',
            '3 -1'
        ];
        solve(args);

}
