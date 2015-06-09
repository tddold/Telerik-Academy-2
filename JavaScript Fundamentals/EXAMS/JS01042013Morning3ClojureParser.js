function solve(params){
    var lines = [], i,j, k, operators = [],rowValues = [], whiteSpaceVar, currentName, varNames =[],varValues = [], currentLineLength, funcValue, defOperator =[], rowValueLength,
    lengthInput = params.length, rowResult =[],  isZeroDivided = false, divLine;
    for (i = 0; i < lengthInput; i+=1){
        lines.push(params[i]);
        lines[i]=lines[i].replace('(','');
        lines[i] = lines[i].trim();
        if (lines[i][0] === '+') {
            rowValues[i]= rowTransform(lines, i, rowValues);

            rowValues[i] = rowValues[i].split(' ');
            rowValueLength = rowValues[i].length;
            varValues.push('noneZ');
            varNames.push('noneZ');
            defOperator.push('NODEFOPERATOR');
            rowValues[i] = checkForFunctions(rowValues[i], varNames, varValues);
            rowResult.push(calculateSum(rowValues[i]));
        } else if (lines[i][0] === '-') {
            operators.push('-');
            rowValues[i]= rowTransform(lines, i, rowValues);

            rowValues[i] = rowValues[i].split(' ');
            rowValueLength = rowValues[i].length;
            varValues.push('noneZ');
            varNames.push('noneZ');
            defOperator.push('NODEFOPERATOR');
            rowValues[i] = checkForFunctions(rowValues[i], varNames, varValues);
            rowResult.push(calculateSub(rowValues[i]));

        } else if (lines[i][0] === '/') {
            operators.push('/');
            rowValues[i]= rowTransform(lines, i, rowValues);

            rowValues[i] = rowValues[i].split(' ');
            rowValueLength = rowValues[i].length;
            varValues.push('noneZ');
            varNames.push('noneZ');
            defOperator.push('NODEFOPERATOR');
            rowValues[i] = checkForFunctions(rowValues[i], varNames, varValues);
            rowResult.push(calculateDiv(rowValues[i]));
            if (rowResult[i]==='Division by zero!'){
                divLine = i + 1;
                console.log('Division by zero! At Line:'+divLine);
                isZeroDivided =true;
                break;
            }
        } else if (lines[i][0] === '*') {
            operators.push('*');
            rowValues[i]= rowTransform(lines, i, rowValues);

            rowValues[i] = rowValues[i].split(' ');
            rowValueLength = rowValues[i].length;
            varValues.push('noneZ');
            varNames.push('noneZ');
            defOperator.push('NODEFOPERATOR');
            rowValues[i] = checkForFunctions(rowValues[i], varNames, varValues);
            rowResult.push(calculateProd(rowValues[i]));
        } else if (lines[i][0] === 'd') {
            operators.push('d');
            lines[i] = lines[i].replace('def', '');
            lines[i] = lines[i].trim();
            currentName = '';
            j = 0;

            //Getting the name of the defined VAR
            while (lines[i][j] !== ' ') {
                currentName = currentName + lines[i][j];
                j += 1
            }
            currentName = currentName.trim();
            varNames.push(currentName);


            lines[i] = lines[i].replace(currentName,'');
            currentLineLength = lines[i].length;
            rowValues.push('');
            for (k = 0;k < currentLineLength; k+=1) {
                if (lines[i][k] !==' ' && lines[i][k+1] ===' '){
                    rowValues[i] = rowValues[i] + lines[i][k] + ' ';
                }
                if (lines[i][k] !==' ' && lines[i][k+1] !==' '){
                    rowValues[i] = rowValues[i] + lines[i][k];
                }
            }
            rowValues[i] = rowValues[i].replace('(','');
            //POSSIBLE MISTAKE
            rowValues[i] = rowValues[i].replace('))','');
            rowValues[i] = rowValues[i].replace(') )','');
            rowValues[i] = rowValues[i].replace(')','');
            rowValues[i] = rowValues[i].trim();
            //
            rowValues[i] = rowValues[i].split(' ');
            rowValueLength = rowValues[i].length;
            if (rowValueLength === 1){
                if (!isNaN(rowValues[i])){
                varValues.push(rowValues[i]*1);
                rowResult.push('NONENONE');
                defOperator.push('NODEFOPERATOR')
                } else {
                    rowValues[i] = checkForFunctions(rowValues[i], varNames, varValues);
                    rowResult.push('NONENONE');
                    varValues.push(rowValues[i]*1);
                }
            } else {
                rowResult.push('NONENONE');
                defOperator[i] = rowValues[i][0];
                rowValues[i] = checkForFunctions(rowValues[i], varNames, varValues);
                if (defOperator[i] ==='+'){
                    varValues[i] = calculateSum(rowValues[i]);
                }
                else if (defOperator[i] ==='-'){
                    varValues[i] = calculateSub(rowValues[i]);
                }
                else if (defOperator[i] ==='*'){
                    varValues[i] = calculateProd(rowValues[i]);
                }
                else if (defOperator[i] ==='/'){
                    varValues[i] = calculateDiv(rowValues[i]);

                    if (varValues[i]==='Division by zero!'){
                        divLine = i + 1;
                        console.log('Division by zero! At Line:'+divLine);
                        isZeroDivided =true;
                        break;
                    }
                }
            }
        }

    }
    if (isZeroDivided ===false) {
        console.log(rowResult[lengthInput - 1]);
    }
    function checkForFunctions(arrayOfValues, varNames, varValues){
        var i, j;
        for (i =0; i<arrayOfValues.length;i+=1) {
            for (j = 0; j < varNames.length; j += 1) {
                if (arrayOfValues[i] === varNames[j]){
                    arrayOfValues[i] = varValues[j];
                }
            }
        }
        return arrayOfValues;
    }
    function calculateSum(arrayOfValues){
        var i= 1,sum = 0;
        for (i=1;i<arrayOfValues.length;i+=1){
            sum = arrayOfValues[i]*1+sum;
        }
        return sum;
    }
    function calculateSub(arrayOfValues){
        var i= 1,result = arrayOfValues[1];
        for (i=2;i<arrayOfValues.length;i+=1){
            result =result - arrayOfValues[i]*1;
        }
        return result;
    }

    function calculateProd(arrayOfValues){
        var i= 1,result = arrayOfValues[1];
        for (i=2;i<arrayOfValues.length;i+=1){
            result =result * (arrayOfValues[i]*1);
        }
        return result;
    }

    function calculateDiv(arrayOfValues){
        var i= 1,result = arrayOfValues[1];
        for (i=2;i<arrayOfValues.length;i+=1){
            if (arrayOfValues[i]*1===0){
                return 'Division by zero!';
            }
            result =result /( arrayOfValues[i]*1);
        }
        result = result | 0;

        return result;
    }

    function rowTransform(lines,i, rowValues) {
        var currentLineLength;
        currentLineLength = lines[i].length;
        rowValues.push('');
        for (var k = 0; k < currentLineLength; k += 1) {
            if (lines[i][k] !== ' ' && lines[i][k + 1] === ' ') {
                rowValues[i] = rowValues[i] + lines[i][k] + ' ';
            }
            if (lines[i][k] !== ' ' && lines[i][k + 1] !== ' ') {
                rowValues[i] = rowValues[i] + lines[i][k];
            }
        }
        rowValues[i] = rowValues[i].replace('(', '');
//POSSIBLE MISTAKE
        rowValues[i] = rowValues[i].replace('))', '');
        rowValues[i] = rowValues[i].replace(') )', '');
        rowValues[i] = rowValues[i].replace(')', '');
        rowValues[i] = rowValues[i].trim();
        return rowValues[i];
    }
}







function input2(){
    var args =[
        '(def func 10)',
        '(+ func 2 43)',
        '(def newFunc (+  func 2))',
        '(def sumFunc (+ func func newFunc 0 0 0))',
        '(* sumFunc 2)'
];
    solve(args);

}

function input2(){
    var args =[
    '(def func (+ 5 2))',
    '(def func2 (/  func 5 2 1 0))',
    '(def func3 (/ func 2))',
    '(+ func3 func)'];
    solve(args);
}

function input2(){
    var args =[
        '(def myFunc 5)', // myFunc = 5
        '(def myNewFunc (+  myFunc  myFunc 2))', //myNewFunc = 12
        '(def MyFunc (* 2  myNewFunc))', //MyFunc = 24,myFunc = 5(Names are CaseSensitive)
        '(/   MyFunc  myFunc)'] //Now the parser should return 4
    solve(args);
}

function input2(){
    var args =[
        '(def     go6o    (+ -5 -2) )',
        '(def pe6o (   /  -15 go6o))',
        '(def asD (/ 2 0))',
        '(def func2 asD  )',
        '(           +        4          2      func2)']
    solve(args);
}

function input(){
    var args=[
        '(def     go6o    (/ -7 1 1 1 1) )',
        '(def asd (/ 0 5))',
        '(def func2 asd  )',
        '(           +        4          2      func2)'
    ];
    solve(args);
}

function input(){
    var args=[
       '(+ 4894894 5246 34123541 11)'
    ];
    solve(args);
}
