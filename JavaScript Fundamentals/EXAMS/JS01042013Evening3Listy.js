/**
 * Created by private on 6.6.2015 �..
 */
//LAST ROW FROM PARAMS
function Solve(params) {
    var answer = 0, listOfVars= [], i, j, k,m, n, p, q,x1, x2,len, rows = [], listOfResults=[],command, commands = [], firstSpace, leftBracket,name,
    len = params.length, commandLength, operator, listOfOperators = [], listOfValues = [], values, index,
        sum,lengthOfValues, parsed,lengthOfVars,operatorsLength, endValues =[], min, max,avg, valuesLength;
    for (i =0;i<len;i+=1){
        rows[i] = params[i];
        if (i < len -1) {
            rows[i] = rows[i].trim();
            command = rows[i].substr(rows[i].indexOf(' ') + 1);
            commands.push(command);
            commands[i] = commands[i].trimLeft();
            firstSpace = commands[i].indexOf(' ');
            leftBracket = commands[i].indexOf('[');
        } else {
            firstSpace = -2;
            rows[i] = rows[i].trim();
            commands.push(rows[i]);
            leftBracket = commands[i].indexOf('[');
        }

//first_space sum[
        name = '';
        if (firstSpace < leftBracket && firstSpace !== -1 && leftBracket - firstSpace > 1){
           commandLength = commands[i].length;
            operator = '';
            for (j=0;j<commandLength;j+=1){
                if (j<firstSpace){
                    name = name + commands[i][j];
                } else if(j<leftBracket){
                    operator = operator + commands[i][j];
                } else{
                    break;
                }

            }
            operator = operator.trim();
            listOfOperators.push(operator);
            listOfVars.push(name);
            values = commands[i].substring(commands[i].indexOf('[')+1,commands[i].indexOf(']'));
            listOfValues.push(values);
        } else if (firstSpace === -1 ||
            leftBracket - firstSpace ===1 ||
        firstSpace>leftBracket){
            commandLength = commands[i].length;
            for (k=0;k<commandLength;k+=1) {
                if (k < leftBracket) {
                    name = name + commands[i][k];
                }else{
                    break;
                }
            }
            name = name.trim();
            listOfVars.push(name);
            listOfOperators.push('none');
            values = commands[i].substring(commands[i].indexOf('[')+1,commands[i].indexOf(']'));
            listOfValues.push(values);
        }
    }

    for (index = 0;index < len; index+=1){
        listOfValues[index] = listOfValues[index].split(',');
        lengthOfValues = listOfValues[index].length;
        for (m=0;m<lengthOfValues;m+=1){
            parsed=listOfValues[index][m] * 1;
            if (!isNaN(parsed)){
                listOfValues[index][m] = parsed;
            } else{
                listOfValues[index][m] = listOfValues[index][m].trim();
                lengthOfVars = listOfVars.length;
                for (n = 0;n < lengthOfVars;n+=1){
                    if (listOfVars[n] === listOfValues[index][m]){
                        if (listOfResults[n] ==='blank') {
                            listOfValues[index].splice(m, 1);
                            m = m - 1;
                            listOfValues[index] = listOfValues[index].concat(listOfValues[n]);
                        }else{
                            listOfValues[index].splice(m, 1);
                            m = m - 1;
                            listOfValues[index]=listOfValues[index].concat(listOfResults[n]);
                        }

                    }
                }
            }
        }
        valuesLength = listOfValues[index].length;
        if (listOfOperators[index]==='sum'){
            sum =0;
            for (q=0;q<valuesLength;q+=1) {
                sum = sum+ listOfValues[index][q];
            }
            listOfResults.push(sum);
        }
        else if (listOfOperators[index]==='min'){
            min =9007199254740991;
            for (x1=0;x1<valuesLength;x1+=1) {
                if(min>listOfValues[index][x1]){
                    min = listOfValues[index][x1];
                }
            }
            listOfResults.push(min);
        }
        else if (listOfOperators[index]==='max'){
            max =-9007199254740991;
            for (x2=0;x2<valuesLength;x2+=1) {
                if(max<listOfValues[index][x2]){
                    max = listOfValues[index][x2];
                }
            }
            listOfResults.push(max);
        }
        else if (listOfOperators[index]==='avg'){
            avg =0;
            sum = 0;
            listOfValues.index
            for (x3=0;x3<valuesLength;x3+=1) {
                sum = sum+ listOfValues[index][x3];
            }
            avg = parseInt(sum / valuesLength);
            listOfResults.push(avg);
        }
        else if (listOfOperators[index]==='none'){
            listOfResults.push('blank');
        }
    }
    operatorsLength = listOfOperators.length;


    // Your code here...
    return listOfResults[listOfResults.length - 1];
}

function input(){
    param = [
        'def newFunc     [      123,432    , 4]',
        'def blaBLA sum[newFunc]',
        'def BLAbla min[newFunc]',
        'avg[BLAbla,blaBLA]',

    ];
    Solve(param);

}