function processVehicleParkCommands(commands) {
    'use strict';

    var Models = (function() {
        var Employee = (function() {
            var Employee = {};
            Object.defineProperties(Employee, {
                init: {
                    value: function (name, position, grade) {
                        this.name = name;
                        this.position = position;
                        this.grade = grade;
                        return this;
                    }
                },
                name: {
                    get: function () {
                        return this._name;
                    },
                    set: function (name) {
                        if (name === undefined || name === "") {
                            throw new Error("Name cannot be empty or undefined.");
                        }
                        this._name = name;
                    }
                },
                position: {
                    get: function () {
                        return this._position;
                    },
                    set: function (position) {
                        if (position === undefined || position === "") {
                            throw new Error("Position cannot be empty or undefined.");
                        }
                        this._position = position;
                    }
                },
                grade: {
                    get: function () {
                        return this._grade;
                    },
                    set: function (grade) {
                        if (grade === undefined || isNaN(grade) || grade < 0) {
                            throw new Error("Grade cannot be negative.");
                        }
                        this._grade = grade;
                    }
                },
                toString: {
                    value: function () {
                        return " ---> " + this.name +
                            ",position=" + this.position;
                    }
                }
            });
            return Employee;
        }());

        var Vehicle = (function() {
            var Vehicle = {};
            Object.defineProperties(Vehicle, {
                init: {
                    value: function(brand, age, terrainCoverage,numberOfWheels, objectName){
                        this.brand = brand;
                        this.age = age;
                        this.terrainCoverage = terrainCoverage;
                        this.numberOfWheels = numberOfWheels;
                        this.objectName = objectName;
                        return this;
                    }
                },
                brand:{
                   get: function(){
                       return this._brand;
                   },
                    set: function(brand){
                        if (brand === undefined || brand === "") {
                            throw new Error("Brand cannot be empty or undefined.");
                        }
                        this._brand = brand;
                    }
                },
                age:{
                    get: function(){
                        return this._age;
                    },
                    set: function(age){
                        if (isNaN(parseFloat(age))||(parseFloat(age) < 0)){
                            throw  new Error;
                        }
                        age = age.toFixed(1);
                        this._age = age;
                    }
                },
                terrainCoverage:{
                    get: function(){
                        return this._terrainCoverage
                    },
                    set: function(terrainCoverage){
                        if (terrainCoverage !== "road" && terrainCoverage !== "all") {
                            throw new Error;
                        }
                        this._terrainCoverage = terrainCoverage;
                    }
                },
                numberOfWheels:{
                    get: function(){
                        return this._numberOfWheels;
                    },
                    set: function(numberOfWheels){
                        if (isNaN(parseInt(numberOfWheels))||(parseInt(numberOfWheels) < 0)){
                            throw  new Error;
                        }
                        this._numberOfWheels = numberOfWheels;
                    }
                },
                toString: {
                    value: function () {
                        return this.objectName + ': brand=' + this.brand + ',age=' + this.age + ',terrainCoverage=' + this.terrainCoverage +
                            ',numberOfWheels=' + this.numberOfWheels;
                    }
                }
            });
            return Vehicle;
        }());


        var Bike = (function(parent) {
            var Bike = Object.create(parent);
            Object.defineProperties(Bike, {
                init: {
                    value: function(brand, age, terrainCoverage,frameSize, numberOfShifts){
                        Vehicle.init.call(this,brand, age, terrainCoverage,2, 'Bike');
                        this.frameSize = frameSize;
                        this.numberOfShifts = numberOfShifts;
                        return this;
                    }
                },
                frameSize:{
                    get: function(){
                        return this._frameSize;
                    },
                    set: function(frameSize){
                        if (isNaN(parseFloat(frameSize))||(parseFloat(frameSize) < 0)){
                            throw  new Error;
                        }
                        this._frameSize = frameSize;
                    }
                },
                numberOfShifts:{
                    get: function(){
                        return this._numberOfShifts;
                    },
                    set: function(numberOfShifts){
                        if (numberOfShifts === "") {
                            throw new Error("Number of shifts cannot be empty or undefined.");
                        }
                        this._numberOfShifts = numberOfShifts;
                    }
                },
                toString: {
                    value: function () {
                        var stringShifts = this.numberOfShifts!==undefined ? ',numberOfShifts='+this.numberOfShifts:'';
                        return ' -> '+parent.toString.call(this)+',frameSize=' + this.frameSize +stringShifts;
                    }
                }
            });
            return Bike;
        }(Vehicle));

        var Automobile = (function(parent){
            var Automobile = Object.create(parent);
            Object.defineProperties(Automobile, {
                init: {
                    value: function(brand, age, terrainCoverage,numberOfWheels,consumption, typeOfFuel, objectName){
                        Vehicle.init.call(this, brand, age, terrainCoverage,numberOfWheels, objectName);
                        this.consumption = consumption;
                        this.typeOfFuel = typeOfFuel;
                        return this;
                    }
                },
                consumption:{
                    get: function(){
                        return this._consumption;
                    },
                    set:function(consumption){
                        if (isNaN(parseFloat(consumption))||(parseFloat(consumption) < 0)){
                            throw  new Error;
                        }
                        this._consumption = consumption;
                    }
                },
                typeOfFuel:{
                    get: function(){
                        return this._typeOfFuel;
                    },
                    set:function(typeOfFuel){
                        if (typeOfFuel === undefined || typeOfFuel === "") {
                            throw new Error;
                        }
                        this._typeOfFuel = typeOfFuel;
                    }
                },
                toString: {
                    value: function () {
                        return parent.toString.call(this)+ ',consumption=[' + this.consumption +'l/100km '+this.typeOfFuel+']';
                    }
                }
            });
            return Automobile
        }(Vehicle))

        var Truck = (function(parent){
            var Truck = Object.create(parent);
            Object.defineProperties(Truck, {
                init: {
                    value: function (brand, age, terrainCoverage, consumption, typeOfFuel, numberOfDoors) {
                        terrainCoverage = terrainCoverage ===undefined ? 'all' : terrainCoverage;
                        Automobile.init.call(this, brand, age, terrainCoverage, 4, consumption, typeOfFuel, 'Truck');
                        this.numberOfDoors = numberOfDoors;
                        return this;
                    }
                },
                numberOfDoors:{
                    get: function(){
                        return this._numberOfDoors;
                    },
                    set: function(numberOfDoors){
                        if (isNaN(parseFloat(numberOfDoors))||(parseFloat(numberOfDoors) < 0)){
                            throw  new Error;
                        }
                        this._numberOfDoors = numberOfDoors;
                    }
                },
                toString: {
                    value: function () {
                        return " -> "+ parent.toString.call(this) +',numberOfDoors='+ this.numberOfDoors;
                    }
                }
            });
            return Truck;
        }(Automobile));

        var Limo = (function(parent){
            var Limo = Object.create(parent);
            Object.defineProperties(Limo, {
                init: {
                    value: function (brand, age, numberOfWheels, consumption, typeOfFuel) {
                        Automobile.init.call(this, brand, age, 'road', numberOfWheels, consumption, typeOfFuel, 'Limo');
                        this._collectionOfEmployees = [];
                        return this;
                    }
                },
                appendEmployee: {
                    value: function(employee) {
                        var checkForDuplicateEmployee = this._collectionOfEmployees.filter(function(a){
                            if (a.name === employee.name){
                                return a;
                            }
                        });
                        if (checkForDuplicateEmployee.length === 0){
                            this._collectionOfEmployees.push(employee);
                        }
                    }
                },
                detachEmployee:{
                    value: function(employee){
                        var isEmployeeInTheCollection = false;
                        for (var countOfEmployees = 0, len = this._collectionOfEmployees.length;countOfEmployees < len; countOfEmployees+=1){
                            if (this._collectionOfEmployees[countOfEmployees].name === employee.name){
                                this._collectionOfEmployees.splice(countOfEmployees,1);
                                isEmployeeInTheCollection = true;
                                len = len -1;
                            }
                        }

                        //if (isEmployeeInTheCollection === false){
                        //    throw new Error;
                        //}
                    }
                },
                toString: {
                    value: function() {
                        var counterForEmployees,numberOfEmployees = this._collectionOfEmployees.length, result = " -> "+ parent.toString.call(this);
                        result = result +'\n' +' --> Employees, allowed to drive:';
                        if (numberOfEmployees >0) {
                            for (counterForEmployees = 0; counterForEmployees < numberOfEmployees; counterForEmployees += 1) {
                                result = result + '\n' + this._collectionOfEmployees[counterForEmployees].toString();
                            }
                        } else{
                            result = result +' ---';
                        }
                        return result;
                    }
                }
            });
            return Limo;
        }(Automobile));

        return {
            Employee: Employee,
            Vehicle: Vehicle,
            Bike: Bike,
            Automobile:Automobile,
            Truck: Truck,
            Limo: Limo
        }
    }());

    var ParkManager = (function(){
        var _vehicles;
        var _employees;

        function init() {
            _vehicles = [];
            _employees = [];
        }

        var CommandProcessor = (function() {

            function processInsertCommand(command) {
                var object;

                switch (command["type"]) {
                    case "bike":
                        object = Object.create(Models.Bike).init(
                            command["brand"],
                            parseFloat(command["age"]),
                            command["terrain-coverage"],
                            parseFloat(command["frame-size"]),
                            command["number-of-shifts"]);
                        _vehicles.push(object);
                        break;
                    case "truck":
                        object = Object.create(Models.Truck).init(
                            command["brand"],
                            parseFloat(command["age"]),
                            command["terrain-coverage"],
                            parseFloat(command["consumption"]),
                            command["type-of-fuel"],
                            parseFloat(command["number-of-doors"]));
                        _vehicles.push(object);
                        break;
                    case "limo":
                        object = Object.create(Models.Limo).init(
                            command["brand"],
                            parseFloat(command["age"]),
                            parseFloat(command["number-of-wheels"]),
                            parseFloat(command["consumption"]),
                            command["type-of-fuel"]);
                        _vehicles.push(object);
                        break;
                    case "employee":
                        object = Object.create(Models.Employee).init(command["name"],command["position"], parseFloat(command["grade"]));
                        _employees.push(object);
                        break;
                    default:
                        throw new Error("Invalid type.");
                }
                var createdObject = command['type'][0].toUpperCase() + command['type'].substr(1,command['type'].length - 1);
                return createdObject + " created.";
            }

            function processDeleteCommand(command) {
                var object,
                    index;

                switch (command["type"]) {
                    case "employee":
                        object = getEmployeeByName(command["name"]);
                        _vehicles.forEach(function(t) {
                            if (t instanceof Models.Limo && t.getEmployees().indexOf(object) !== -1) {
                                t.detachEmployee(object);
                            }
                        });
                        index = _employees.indexOf(object);
                        _employees.splice(index, 1);
                        break;
                    case "bike":
                    case "truck":
                    case "limo":
                        object = getVehicleByBrandAndType(command["brand"],command["type"]);
                        index = _vehicles.indexOf(object);
                        _vehicles.splice(index, 1);
                        break;
                    default:
                        throw new Error("Unknown type.");
                }

                return object.objectName + " deleted.";
            }

            function processListCommand(command) {
                return formatOutputList(_vehicles);
            }

            function processAppendEmployeeCommand(command) {
                var employee = getEmployeeByName(command["name"]);
                var limos = getLimosByBrand(command["brand"]);

                for (var i=0; i < limos.length; i++) {
                    limos[i].appendEmployee(employee);
                }
                return "Added employee to possible Limos.";
            }

            function processDetachEmployeeCommand(command) {
                var employee = getEmployeeByName(command["name"]);
                var limos = getLimosByBrand(command["brand"]);

                for (var i=0; i < limos.length; i++) {
                    limos[i].detachEmployee(employee);
                }

                return "Removed employee from possible Limos.";
            }

            // Functions below are not revealed

            function getVehicleByBrandAndType(brand, type) {
                for (var i=0; i < _vehicles.length; i++) {
                    if (_vehicles[i].objectName.toLowerCase() === type &&
                        _vehicles[i].brand === brand) {
                        return _vehicles[i];
                    }
                }
                throw new Error("No Limo with such brand exists.");
            }

            function getLimosByBrand(brand) {
                var currentVehicles = [];
                for (var i=0; i < _vehicles.length; i++) {
                    if (_vehicles[i].objectName === 'Limo' &&
                        _vehicles[i].brand === brand) {
                        currentVehicles.push(_vehicles[i]);
                    }
                }
                if (currentVehicles.length > 0) {
                    return currentVehicles;
                }
                throw new Error("No Limo with such brand exists.");
            }

            function getEmployeeByName(name) {

                for (var i = 0; i < _employees.length; i++) {
                    if (_employees[i].name === name) {
                        return _employees[i];
                    }
                }
                throw new Error("No Employee with such name exists.");
            }

            function formatOutputList(output) {
                var queryString = "List Output:\n";

                if (output.length > 0) {
                    queryString += output.join("\n");
                } else {
                    queryString = "No results.";
                }

                return queryString;
            }

            function processListEmployees(args){
                var filteredEmployees,parsedEvaluationGrade;
                if (args.grade!=='all') {
                    parsedEvaluationGrade = parseFloat(args.grade);
                    filteredEmployees = _employees.filter(function (a) {
                        if (a.grade >= parsedEvaluationGrade) {
                            return a;
                        }
                    });
                }
                else{
                    filteredEmployees =  _employees.slice(0);
                }

                filteredEmployees.sort(function(a,b){
                    if (a.name > b.name){
                        return 1;
                    } else{
                        return -1;
                    }
                });
                return formatOutputList(filteredEmployees);
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processAppendEmployeeCommand: processAppendEmployeeCommand,
                processDetachEmployeeCommand: processDetachEmployeeCommand,
                processListEmployees: processListEmployees
            }
        }());

        var Command = (function() {
            function Command(cmdLine) {
                this._cmdArgs = processCommand(cmdLine);
            }

            function processCommand(cmdLine) {
                var parameters = [],
                    matches = [],
                    pattern = /(.+?)=(.+?)[;)]/g,
                    key,
                    value,
                    split;

                split = cmdLine.split("(");
                parameters["command"] = split[0];
                while ((matches = pattern.exec(split[1])) !== null) {
                    key = matches[1];
                    value = matches[2];
                    parameters[key] = value;
                }

                return parameters;
            }

            return Command;
        }());

        function executeCommands(cmds) {
            var commandArgs = new Command(cmds)._cmdArgs,
                action = commandArgs["command"],
                output;

            switch (action) {
                case "insert":
                    output = CommandProcessor.processInsertCommand(commandArgs);
                    break;
                case "delete":
                    output = CommandProcessor.processDeleteCommand(commandArgs);
                    break;
                case "append-employee":
                    output = CommandProcessor.processAppendEmployeeCommand(commandArgs);
                    break;
                case "detach-employee":
                    output = CommandProcessor.processDetachEmployeeCommand(commandArgs);
                    break;
                case "list":
                    output = CommandProcessor.processListCommand(commandArgs);
                    break;
                case "list-employees":
                    output = CommandProcessor.processListEmployees(commandArgs);
                    break;
                default:
                    throw new Error("Unsupported command.");
            }

            return output;
        }

        return {
            init: init,
            executeCommands: executeCommands
        }
    }());

    var output = "";
    ParkManager.init();

    commands.forEach(function(cmd) {
        var result;
        if (cmd != "") {
            try {
                result = ParkManager.executeCommands(cmd) + "\n";
            } catch (e) {
                result = "Invalid command." + "\n";
                //result = e.message + "\n";
            }
            output += result;
        }
    });

    return output;
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processVehicleParkCommands(arr));
        });
    }
})();