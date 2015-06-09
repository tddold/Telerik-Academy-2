/**
 * Created by private on 3.6.2015 ã..
 */

function solve(params) {
    var inputDims = params[0],
    dims = inputDims.split(' ');
    var count = 0,
        i,
        matrix = [[]],
        isValid = true,
        currentPosX = 0,
        currentPosY = 0,
        numberMatrix,
        positionMatrix = [],
        rowPos,
        colPos,
        sum  =1 ,
        output,
        zzza;
    zzzz =0;
    dims[0] = parseInt(dims[0]);
    dims[1] = parseInt(dims[1]);
    for (i = 0; i < dims[0];i+=1){
        matrix[i] = params[i + 1].split(' ');
        //console.log(matrix[i][i]);
    }
    for (rowPos = 0; rowPos < dims[0]; rowPos+=1){
        positionMatrix[rowPos] = new Array(colPos);
        for(colPos = 0; colPos <dims[1]; colPos+=1){
            positionMatrix[rowPos][colPos] = false;
        }
    }

    while (isValid){
        if (matrix[currentPosX][currentPosY] === 'dr'){
            currentPosX = currentPosX + 1;
            currentPosY = currentPosY + 1;
        }
        else if(matrix[currentPosX][currentPosY] === 'dl'){
            currentPosX = currentPosX + 1;
            currentPosY = currentPosY - 1;
        }
        else if(matrix[currentPosX][currentPosY] === 'ur'){
            currentPosX = currentPosX - 1;
            currentPosY = currentPosY + 1;
        }
        else if(matrix[currentPosX][currentPosY] === 'ul'){
            currentPosX = currentPosX - 1;
            currentPosY = currentPosY - 1;
        }
        if (currentPosX < 0 ||
            currentPosX >= dims[0] ||
            currentPosY < 0 ||
            currentPosY >= dims[1]){
            return output = 'successed with ' + sum;
            isValid = false;
        }
        if (positionMatrix[currentPosX][currentPosY] === true){
            return output = 'failed at (' + currentPosX+', '+currentPosY+')'
            isValid = false;
        }
        else{
            positionMatrix[currentPosX][currentPosY] = true;
            sum = sum + Math.pow(2,currentPosX) + currentPosY;
        }
    }

}

function input(){
var args =[
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
    ],
    output = solve(args);

}
