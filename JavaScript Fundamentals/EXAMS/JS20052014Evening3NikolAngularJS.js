function solve(params) {
    var s = params[0], i, j, k, l, m, n, p, q, r, t, u, v = 0,y, fin, codeIndex, htmlCodeLength, models = [], mainProgram = [], htmlCode = [], htmlStart = false, len, interimTemplate = [], templateKey = [], templateValue = [], topRow,
        modelsKey = [], modelsValue = [], lenModels, invertedRow, htmlRow, ifTopRow, renderRow, numOfTemplates, inHtml = false, htmlRowCounter = 0, hasTemplates = true,
        startComment = 0, endComment = 0;
    for (i = 0; i < params[0]; i += 1) {
        models.push(params[i + 1]);
    }
    len = params[params[0] * 1 + 1] * 1;
    for (j = params[0] * 1 + 1; j < len + 2 + params[0] * 1; j += 1) {
        //j ===params[0]*1 +1 Escaping second number row
        if (j === params[0] * 1 + 1) {
            j = j + 1;
        }
        mainProgram.push(params[j]);
        v += 1;
        if (mainProgram[v - 1] === undefined) {
            mainProgram[v - 1] = '';
        }
        if (inHtml === true || params[params[0] * 1 + 2].indexOf('<nk-template') === -1 ||
            (params[j - 1].indexOf("</nk-template") > -1 &&
            params[j].indexOf("<nk-template name=") === -1)) {
            inHtml = true;
        }
        if (inHtml) {
            htmlCode.push(params[j]);
            htmlRowCounter += 1;
            if (htmlCode[htmlRowCounter - 1] === undefined) {
                htmlCode[htmlRowCounter - 1] = '';
            }
        }
    }

    if (params[params[0] * 1 + 2].indexOf('<nk-template') === -1) {
        hasTemplates = false;
    }
    //TEMPLATES RECORD
    l = 0;
    while (hasTemplates && !(params[l].indexOf("</nk-template") > -1 &&
    params[l + 1].indexOf("<nk-template name=") === -1)) {
        if (mainProgram[l].indexOf('<nk-template name="') > -1) {
            topRow = mainProgram[l].split('"');
            templateKey.push(topRow[1]);
            k = 1;
            while (mainProgram[l + k].indexOf('</nk-template>') === -1) {
                interimTemplate.push(mainProgram[l + k])
                k += 1;
            }
            templateValue.push(interimTemplate);
            interimTemplate = [];
        }
        l += 1;
    }

    //MODELS SPLIT
    lenModels = models.length;
    for (m = 0; m < lenModels; m += 1) {
        models[m] = models[m].split('-');
        modelsKey.push(models[m][0]);
        modelsValue.push(models[m][1]);
        modelsValue[m] = modelsValue[m].split(';')
    }
    numOfTemplates = templateKey.length;
    var inComment = false;
    //HTML CODE FORMATTING
    for (codeIndex = 0, htmlCodeLength = htmlCode.length; codeIndex < htmlCodeLength; codeIndex += 1) {
        //COMMENT START
        inComment = false;
        var rowLen = htmlCode[codeIndex].length, z;
        var row = '';
        for (z = 0; z < rowLen; z += 1) {
            var segmentModel = htmlCode[codeIndex].substr(z, 10),
                segmentTemplate = htmlCode[codeIndex].substr(z, 21),
                segmentIf = htmlCode[codeIndex].substr(z, 6);
            if (htmlCode[codeIndex][z] === '{' && htmlCode[codeIndex][z + 1] === '{' &&
                htmlCode[codeIndex].indexOf('}}') > -1) {
                var newStart = htmlCode[codeIndex].indexOf('}}') +2;
                y =z;
                while (htmlCode[codeIndex][y] !== '}' && htmlCode[codeIndex][y + 1] !== '}') {
                    row = row + htmlCode[codeIndex][y + 2];
                    y+=1;
                }
                row = row +'}';

                z = newStart -1;
                row=row.replace('}}', '');
                if (z === rowLen -1){
                    htmlCode[codeIndex] =row;
                }
                //model sub
            } else if (segmentModel === '<nk-model>') {
                //     (inComment ===true &&htmlCode[codeIndex].indexOf('<nk-model>')>-1&&
                //     (htmlCode[codeIndex].indexOf('<nk-model>')>startComment&&htmlCode[codeIndex].indexOf('<nk-model>')>endComment)||
                //     (htmlCode[codeIndex].indexOf('</nk-model>')<startComment&&htmlCode[codeIndex].indexOf('</nk-model>')<endComment))){
                for (n = 0; n < lenModels; n += 1) {
                    if (htmlCode[codeIndex].indexOf(modelsKey[n]) > -1) {
                        htmlCode[codeIndex] = htmlCode[codeIndex].replace(modelsKey[n], modelsValue[n]);
                        htmlCode[codeIndex] = htmlCode[codeIndex].replace('<nk-model>', '');
                        htmlCode[codeIndex] = htmlCode[codeIndex].replace('</nk-model>', '');
                    }
                }
            }
            //render template
            else if (segmentTemplate === '<nk-template render="') {
                //   (inComment ===true &&htmlCode[codeIndex].indexOf('<nk-template render="')>-1 &&
                //   (htmlCode[codeIndex].indexOf('<nk-template render="')>startComment&&htmlCode[codeIndex].indexOf('<nk-template render="')>endComment)||
                //   (htmlCode[codeIndex].indexOf('<nk-template render="')<startComment&&htmlCode[codeIndex].indexOf('<nk-template render="')<endComment))){
                renderRow = htmlCode[codeIndex].split('"');
                for (p = 0; p < numOfTemplates; p += 1) {
                    if (htmlCode[codeIndex].indexOf(templateKey[p]) > -1) {
                        htmlCode.splice(codeIndex, 1);

                        for (q = 0; q < templateValue[p].length; q++) {
                            htmlCode.splice(codeIndex + q, 0, templateValue[p][q])
                        }
                        htmlCodeLength = htmlCode.length;
                    }

                }
            }
            //if statement
            else if (segmentIf ==='<nk-if') {
                // (inComment ===true &&htmlCode[codeIndex].indexOf('<nk-if')>-1&&
                // (htmlCode[codeIndex].indexOf('<nk-if"')>startComment&&htmlCode[codeIndex].indexOf('<nk-if"')>endComment)||
                // (htmlCode[codeIndex].indexOf('<nk-if"')<startComment&&htmlCode[codeIndex].indexOf('<nk-if"')<endComment))){
                ifTopRow = htmlCode[codeIndex].split('"');
                for (t = 0; t < lenModels; t += 1) {
                    if (ifTopRow[1] === modelsKey[t]) {
                        htmlCode.splice(codeIndex, 1);
                        u = 0;
                        if (modelsValue[t][0] === "false") {
                            while (htmlCode[codeIndex].indexOf('</nk-if>') === -1) {
                                htmlCode.splice(codeIndex, 1);
                            }
                            htmlCode.splice(codeIndex, 1);
                        }
                        else if (modelsValue[t][0] === "true") {
                            while (htmlCode[codeIndex + u].indexOf('</nk-if>') === -1) {
                                u += 1;
                            }
                            htmlCode.splice(codeIndex + u, 1);
                        }
                        //codeIndex = codeIndex -1;
                    }
                }
            }
            else if (htmlCode[codeIndex][z]!==undefined){

                row = row + htmlCode[codeIndex][z];
                if (z === rowLen -1){
                    htmlCode[codeIndex] =row;
                }
            }
        }






        //loop
        if (htmlCode[codeIndex].indexOf('<nk-repeat ')>-1){
        }

     }

    var result = '';
    for (fin = 0,htmlCodeLength = htmlCode.length;fin<htmlCodeLength;fin+=1){
        result=result + htmlCode[fin]+'\n';
    }
       // Your solution here

    console.log(result);
}


function input4() {
    var params = [
        '6',
        'title-Telerik Academy',
        'showSubtitle-true',
        'subTitle-Free training',
        'showMarks-false',
        'marks-3;4;5;6',
        'students-Ivan;Gosho;Pesho',
        '42',
        '<nk-template name="menu">',
        '    <ul id="menu">',
        '        <li>Home</li>',
        '        <li>About us</li>',
        '    </ul>',
        '</nk-template>',
        '<nk-template name="footer">',
        '    <footer>',
        '        Copyright Telerik Academy 2014',
        '    </footer>',
        '</nk-template>',
        '<!DOCTYPE html>',
        '<html>',
        '<head>',
        '    <title>Telerik Academy</title>',
        '</head>',
        '<body>',
        '    <nk-template render="menu" />',
        '',
        '    <h1><nk-model>title</nk-model></h1>',
        '    <nk-if condition="showSubtitle">',
        '        <h2><nk-model>subTitle</nk-model></h2>',
        '        <div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
        '    </nk-if>',
        '',
        '    <ul>',
        '        <nk-repeat for="student in students">',
        '            <li>',
        '                <nk-model>student</nk-model>',
        '            </li>',
        '            <li>Multiline <nk-model>title</nk-model></li>',
        '        </nk-repeat>',
        '    </ul>',
        '    <nk-if condition="showMarks">',
        '        <div>',
        '            <nk-model>marks</nk-model>',
        '        </div>',
        '    </nk-if>',
        '',
        '    <nk-template render="footer" />',
        '</body>',
        '</html>'];
    solve(params);
}

function input() {
    var params = [
        '0',
        '15',
        '<div>',
        '<p>',
        '{{<nk-if condition="pesho">}}',
        '{{escaped}} dude',
        '</p>',
        '<p>',
        '{{<nk-template render="pesho">}}',
        '</p>',
        '<p>',
        '{{<nk-repeat for="pesho in peshos">}}',
        '{{escaped}} in comment',
        '</p>',
        '</div>'];
    solve(params);
}

function input3(){
    var params=['0',
        '21',
        '<nk-template name="first">',
        '    <ul>',
        '        <li>',
        '            In section UL',
        '        </li>',
        '        <li>',
        '            Still in section UL',
        '        </li>',
        '    </ul>',
        '</nk-template>',
        '<nk-template name="second">',
        '    <div>',
        '        Second section :)',
        '    </div>',
        '</nk-template>',
        '<div>',
        '    <nk-template render="first" />',
        '    <nk-template render="second" />',
        '</div>'];
    solve(params);
}


function input4() {
    var params = [
        '6',
        'title-Telerik Academy',
        'showSubtitle-true',
        'subTitle-Free training',
        'showMarks-false',
        'marks-3;4;5;6',
        'students-Ivan;Gosho;Pesho',
        '42',
        '<nk-template name="menu">',
        '    <ul id="menu">',
        '        <li>Home</li>',
        '        <li>About us</li>',
        '    </ul>',
        '</nk-template>',
        '<nk-template name="footer">',
        '    <footer>',
        '        Copyright Telerik Academy 2014',
        '    </footer>',
        '</nk-template>',
        '    <nk-if condition="showSubtitle">',
        '        <h2><nk-model>subTitle</nk-model></h2>',
        '        <div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
        '    </nk-if>',
        '<!DOCTYPE html>',
        '<html>',
        '<head>',
        '    <title>Telerik Academy</title>',
        '</head>',
        '<body>',
        '    <nk-template render="menu" />',
        '',
        '    <h1><nk-model>title</nk-model></h1>',
        '',
        '    <ul>',
        '        <nk-repeat for="student in students">',
        '            <li>',
        '                <nk-model>student</nk-model>',
        '            </li>',
        '            <li>Multiline <nk-model>title</nk-model></li>',
        '        </nk-repeat>',
        '    </ul>',
        '    <nk-if condition="showMarks">',
        '        <div>',
        '            <nk-model>marks</nk-model>',
        '        </div>',
        '    </nk-if>',
        '',
        '    <nk-template render="footer" />',
        '</body>',
        '</html>'];
    solve(params);
}
















































