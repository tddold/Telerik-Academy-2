function solve(params) {
    var numberKeyValuePairs = params[0]* 1,
        i,
        j,
        k,
        l,
        m,
        n,
        pairs = [],
        key = [],
        keysLength,
        valueOfKey = [],
        viewRows = [],
        inSectionDefining = true,
        counter,
        section,
        content = [],
        sections = [{}],
        sectionCounter,
        start,
        index,
        paramsIndex,
        text = [],
        command='',
        kliomba,
        contentLength,
        name,
        row;
    for (i=0;i<numberKeyValuePairs;i+=1){
        pairs[i] = params[i+1];
        pairs[i] = pairs[i].split(':');
        key.push(pairs[i][0]);
        valueOfKey.push(pairs[i][1]);
        if (valueOfKey[i].indexOf(',')>-1){
            valueOfKey[i] = valueOfKey[i].split(',')
        }
        console.log(key[i] + ' '+valueOfKey[i])
    }
    for (j=0;j<params.length - numberKeyValuePairs -1;j+=1){
        viewRows[j] = params[numberKeyValuePairs+j+1];
    }
    //for (var l=0;l<numberKeyValuePairs;l+=1){
    //    console.log(pairs[l]);
    //}
    //console.log('--------------------------')
    //for (var k=0;k<viewRows.length;k+=1){
    //    console.log(viewRows[k]);
    //}
    counter = numberKeyValuePairs + 2;
    while (inSectionDefining){
        sectionCounter = 0;
        if (params[counter].indexOf('html>')===-1){
            if (params[counter].indexOf('@section')>-1){
                params[counter] = params[counter].split(' ');
                sectionCounter =1;
                content =[];
                while (params[counter+sectionCounter]!==('}')){
                    content[sectionCounter -1] = params[counter + sectionCounter];
                    sectionCounter+=1
                }
                section = {name: params[counter][1], content: content
                };
                sections.push(section);
            }
            counter =1 +sectionCounter+counter;
        }
        else{
            start = counter;
            inSectionDefining = false;
        }
    }
    keysLength = key.length;
    index = 0;
    paramsIndex = 0;
    while (params[paramsIndex + start].indexOf('</html>')){
        text.push(params[paramsIndex+start]);
        if (text[index].indexOf('@')>-1 &&text[index].indexOf('@@')===-1){
            kliomba = text[index].indexOf('@');
             k = kliomba;
            command ='';
            while(text[index][k]!==' '&&text[index][k]!=='<'
            &&text[index][k]!==undefined){

                command = command+(text[index][k]);
                k+=1;
            }
            if (command!=='@if'&&command.indexOf('@renderSection')<0
                && command!=='foreach'){
                for (l =0;l<keysLength;l+=1){
                    if (command === '@'+key[l]){
                        row = text[index].replace(command,valueOfKey[l]);
                        text[index]= row;
                    }
                }
            } else if (command.indexOf('@renderSection')>=0){
                name = command.split('"');
                for (m =0;m<sections.length;m+=1){
                    if (name[1] === sections[m].name){
                        row ='';
                        row = text[index].replace(command,sections[m].content[0]);
                        text[index]= row;
                        contentLength = sections[m].content.length;
                        for (n=1;n<contentLength;n++){
                            text.push(sections[m].content[n]);
                            index+=1;
                        }
                    }
                }
            } else if (command==='@if'){
                var line = text[index].substring(k);
                line = text[index].split(' ');
                line[1]=line[1].replace('(','');
                line[1]=line[1].replace(')','');
                for (var r =0;r<keysLength;r+=1){
                    if (line[1] === key[r] && valueOfKey[r] === 'true'){
                        text.splice(index);
                        while(params[paramsIndex+start+1]!=='}') {
                            text.push(params[paramsIndex+1+start])
                            index += 1;
                            paramsIndex += 1;
                        }
                    }
                }
            }
        }
        paramsIndex+=1;
        index+=1;
    }
    var result = '';
    // Your solution here
    console.log(text);
}


function input(){
    var args =['6',
    'showSubtitle:true',
    'title:Telerik Academy',
    'subTitle:Free training',
    'showMarks:true',
   'marks:3,4,5,6',
    'students:Pesho,Gosho,Ivan',
    '42',
'@section menu {',
    '<ul id="menu">',
            '<li>Home</li>',
            '<li>About us</li>',
        '</ul>',
    '}',
'@section footer {',
    '<footer>',
        'Copyright Telerik Academy 2014',
        '</footer>',
    '}',
'<!DOCTYPE html>',
    '@renderSection("menu")',
        '@if (showMarks) {',
        '<div>',
        '@marks',
        '</div>',
        '}',
    '<h1>@title</h1>',
    '@if (showSubtitle) {',
    '<h2>@subTitle</h2>',
        '<div>@@JustNormalTextWithDoubleKliomba ;)</div>',
    '}',

'<ul>',
        '@foreach (var student in students) {',
    '<li>',
                '@student',
        '</li>',
        '<li>Multiline @title</li>',
    '}',
'</ul>',


    '@renderSection("footer")',
    '</body>',
    '</html>'];

//console.log(args);
    output = solve(args);

}

//
//'<html>',
//    '<head>',
//    '<title>Telerik Academy</title>',
//    '</head>',
//    '<body>',
//    ,
