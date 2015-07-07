function processTravelAgencyCommands(commands) {
    'use strict';

    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    }


    var Models = (function() {
        var Destination = (function() {
            function Destination(location, landmark) {
                this.setLocation(location);
                this.setLandmark(landmark);
            }

            Destination.prototype.getLocation = function() {
                return this._location;
            }

            Destination.prototype.setLocation = function(location) {
                if (location === undefined || location === "") {
                    throw new Error("Location cannot be empty or undefined.");
                }
                this._location = location;
            }

            Destination.prototype.getLandmark = function() {
                return this._landmark;
            }

            Destination.prototype.setLandmark = function(landmark) {
                if (landmark === undefined || landmark == "") {
                    throw new Error("Landmark cannot be empty or undefined.");
                }
                this._landmark = landmark;
            }

            Destination.prototype.toString = function() {
                return this.constructor.name + ": " +
                    "location=" + this.getLocation() +
                    ",landmark=" + this.getLandmark();
            }

            return Destination

        }());

        var Travel =(function(){
            function Travel(name, startDate, endDate, price) {
                this.setName(name);
                this.setStartDate(startDate);
                this.setEndDate(endDate);
                this.setPrice(price);
                return this;
            }

            Travel.prototype.getName = function(){
                return this._name;
            };

            Travel.prototype.setName = function(name){
                if (name === undefined || name ==''){
                    throw new Error;
                }
                this._name = name;
            };

            Travel.prototype.getStartDate = function(){
                    return this._startDate;
            };

            Travel.prototype.setStartDate = function(startDate){
                if (startDate === undefined || !(startDate instanceof Date)) {
                    throw new Error("Start date should be a non-empty date object.")
                }
                var day, month, year,dates, startDateToString;
                startDateToString = startDate.toString();
                var dates = startDateToString.split(' ');
                day = dates[2];
                if (day[0] === '0'){
                    var currentDay = day[1];
                    day = currentDay;
                }
                month = dates[1];
                year = dates[3];
                this._startDate = day +'-'+month+'-'+year;
            };

            Travel.prototype.getEndDate = function(){
                return this._endDate;
            };


            Travel.prototype.setEndDate = function(endDate){
                if (endDate === undefined || !(endDate instanceof Date)) {
                    throw new Error("Start date should be a non-empty date object.")
                }
                var dates, day, month, year,endDateToString;
                endDateToString = endDate.toString();
                dates = endDateToString.split(' ');
                day = dates[2];
                if (day[0] === '0'){
                    var currentEndDay = day[1];
                    day = currentEndDay;
                }
                month = dates[1];
                year = dates[3];
                this._endDate = day +'-'+month+'-'+year;

            };

            Travel.prototype.getPrice = function(){
                return this._price;
            };

            Travel.prototype.setPrice = function(value){
                if (isNaN(value) || value ==='' ){
                        throw new Error;
                }
                value = parseFloat(value);
                value = value.toFixed(2);
                this._price = value;
            };

            Travel.prototype.toString = function(){
                var result  = ' name=' + this.getName() + ',start-date='+this.getStartDate() + ',end-date='+this.getEndDate()+',price='
                    + this.getPrice();
                return result;
            }
            return Travel;

        }());

        var Excursion = (function Excursion(Parent){
            Excursion.extends(Travel);
            function Excursion(name, startDate, endDate, price, transport){
                Parent.apply(this, arguments);
                this.setTransport(transport);
                this.collectionOfDestinations = [];
                return this;
            }

            Excursion.prototype.getTransport = function () {
                return this._transport;
            };

            Excursion.prototype.setTransport = function (value) {
                if (value.length === 0 || !value){
                    throw new Error;
                }
                this._transport = value;
            }

            Excursion.prototype.addDestination = function(destination){
                this.collectionOfDestinations.push(destination)
            }

            Excursion.prototype.removeDestination = function(destination){
                for (var j = 0; j < this.collectionOfDestinations.length; j++) {
                    if (this.collectionOfDestinations[j].getLocation() === destination.getLocation()
                        && this.collectionOfDestinations[j].getLandmark() === destination.getLandmark()) {
                        this.collectionOfDestinations.splice(j,1);
                    }
                }
            }

            Excursion.prototype.getDestinations = function(){
                return this.collectionOfDestinations;
            }


            Excursion.prototype.toString = function(){
                var excursionResult  = ' * Excursion: ' + 'name=' + this.getName() + ',start-date='+this.getStartDate() + ',end-date='+this.getEndDate()+',price='
                    + this.getPrice() + ',transport=' + this.getTransport();
                excursionResult = excursionResult +'\n' + ' ** Destinations: '
                if (this.collectionOfDestinations.length > 0){
                    for (var countOfDestinations = 0; countOfDestinations < this.collectionOfDestinations.length; countOfDestinations+=1){
                        excursionResult = excursionResult + this.collectionOfDestinations[countOfDestinations].toString();
                        if (countOfDestinations < this.collectionOfDestinations.length -1){
                            excursionResult = excursionResult + ';'
                        }
                    }
                } else {
                    excursionResult = excursionResult + '-';
                }
                return excursionResult;
            }
            return Excursion;
        }(Travel));

        var Vacation = (function(parent){
            Vacation.extends(Travel);

            function Vacation(name, startDate, endDate, price, location, accommodation){
                parent.apply(this, arguments);
                this.setAccommodation(accommodation);
                this.setLocation(location);
                this._destinations = []
            }

            Vacation.prototype.getAccommodation = function () {
                return this._accommodation;
            };

            Vacation.prototype.setAccommodation = function (value) {
                if (value !== undefined && value === ""){
                    throw new Error;
                }
                this._accommodation = value;
            }

            Vacation.prototype.getLocation = function () {
                return this._location;
            };

            Vacation.prototype.setLocation = function (value) {
                if (value.length === 0 || !value){
                    throw new Error;
                }
                this._location = value;
            }
             Vacation.prototype.toString = function () {
                 var accommodationdString = '';
                 if (this.getAccommodation() !== undefined){
                     accommodationdString = ',accommodation=' + this.getAccommodation();
                 }
                 var vacationResult  = ' * Vacation: ' + 'name=' + this.getName() + ',start-date='+this.getStartDate() + ',end-date='+this.getEndDate()+',price='
                     + this.getPrice() + ',location=' + this.getLocation() + accommodationdString;
                 //vacationResult = vacationResult +'\n' + ' ** Destinations:' ;
                 //if (this.collectionOfDestinations.length > 0){
                 //    for (var countOfDestinations = 0; countOfDestinations < this.collectionOfDestinations.length; countOfDestinations+=1){
                 //        vacationResult = vacationResult + this.collectionOfDestinations[countOfDestinations].toString() + ';';
                 //    }
                 //} else {
                 //    vacationResult = vacationResult + ' -';
                 //}
                 return vacationResult;
             }
            return Vacation;
        }(Travel));



        var Cruise = (function(Parent){
            Cruise.extends(Excursion);
            function Cruise(name, startDate, endDate, price, startDock){
                Parent.call(this, name, startDate, endDate, price, "cruise liner");
                this.setStartDock;
                return this;
            }

            Cruise.prototype.getStartDock = function () {
                return this._location;
            };

            Cruise.prototype.setStartDock = function (value) {
                if (value !== undefined && value === ""){
                    throw new Error;
                }
                this._location = value;
            }
            Cruise.prototype.toString = function() {
                var cruiseResult  = ' * Cruise:' + ' name=' + this.getName() + ',start-date='+this.getStartDate() + ',end-date='+this.getEndDate()+',price='
                    + this.getPrice() +',transport='+  this.getTransport();
                cruiseResult = cruiseResult +'\n' + ' ** Destinations: '
                if (this.collectionOfDestinations.length > 0){
                    for (var countOfDestinations = 0; countOfDestinations < this.collectionOfDestinations.length; countOfDestinations+=1){
                        cruiseResult = cruiseResult + this.collectionOfDestinations[countOfDestinations].toString();
                        if (countOfDestinations < this.collectionOfDestinations.length -1){
                            cruiseResult = cruiseResult + ';'
                        }
                    }
                } else {
                    cruiseResult = cruiseResult + '-';
                }
                return cruiseResult;
            }
            return Cruise;
        }(Excursion));

        return {
            Destination: Destination,
            Travel: Travel,
            Excursion: Excursion,
            Vacation: Vacation,
            Cruise: Cruise
        }
    }());

    var TravellingManager = (function(){
        var _travels;
        var _destinations;

        function init() {
            _travels = [];
            _destinations = [];
        }

        var CommandProcessor = (function() {

            function processInsertCommand(command) {
                var object;

                switch (command["type"]) {
                    case "excursion":
                        object = new Models.Excursion(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["transport"]);
                        _travels.push(object);
                        break;
                    case "vacation":
                        object = new Models.Vacation(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["location"], command["accommodation"]);
                        _travels.push(object);
                        break;
                    case "cruise":
                        object = new Models.Cruise(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["start-dock"]);
                        _travels.push(object);
                        break;
                    case "destination":
                        object = new Models.Destination(command["location"], command["landmark"]);
                        _destinations.push(object);
                        break;
                    default:
                        throw new Error("Invalid type.");
                }

                return object.constructor.name + " created.";
            }

            function processDeleteCommand(command) {
                var object,
                    index,
                    destinations;

                switch (command["type"]) {
                    case "destination":
                        object = getDestinationByLocationAndLandmark(command["location"], command["landmark"]);
                        _travels.forEach(function(t) {
                            if (t instanceof Models.Excursion && t.getDestinations().indexOf(object) !== -1) {
                                t.removeDestination(object);
                            }
                        });
                        index = _destinations.indexOf(object);
                        _destinations.splice(index, 1);
                        break;
                    case "excursion":
                    case "vacation":
                    case "cruise":
                        object = getTravelByName(command["name"]);
                        index = _travels.indexOf(object);
                        _travels.splice(index, 1);
                        break;
                    default:
                        throw new Error("Unknown type.");
                }

                return object.constructor.name + " deleted.";
            }

            function processListCommand(command) {
                return formatTravelsQuery(_travels);
            }

            function processAddDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.addDestination(destination);

                return "Added destination to " + travel.getName() + ".";
            }

            function processRemoveDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.removeDestination(destination);

                return "Removed destination from " + travel.getName() + ".";
            }

            function getTravelByName(name) {
                var i;

                for (i = 0; i < _travels.length; i++) {
                    if (_travels[i].getName() === name) {
                        return _travels[i];
                    }
                }
                throw new Error("No travel with such name exists.");
            }

            function getDestinationByLocationAndLandmark(location, landmark) {
                var i;

                for (i = 0; i < _destinations.length; i++) {
                    if (_destinations[i].getLocation() === location
                        && _destinations[i].getLandmark() === landmark) {
                        return _destinations[i];
                    }
                }
                throw new Error("No destination with such location and landmark exists.");
            }

            function formatTravelsQuery(travelsQuery) {
                var queryString = "";

                if (travelsQuery.length > 0) {
                    queryString += travelsQuery.join("\n");
                } else {
                    queryString = "No results.";
                }

                return queryString;
            }

            function processFilterTravelsCommand(commands){
                filteredByType = [];

            var filteredByType = _travels
            .filter(function(e) {
                    switch (commands.type) {
                        case "excursion":
                            return e.constructor.name === "Excursion";
                        case "vacation":
                            return e.constructor.name === "Vacation";
                        case "cruise":
                            return e.constructor.name === "Cruise";
                        case "all":
                            return true;
                        default:
                            return false;
                    }
                });
                var filteredTravels = filteredByType.filter(function(tr){
                  if (tr.getPrice() >= parseFloat(commands['price-min']) &&
                      tr.getPrice() <= parseFloat(commands['price-max'])){
                      return tr;
                  }
                });
                var dates = filteredTravels[0].getStartDate().split('-')
                filteredTravels.sort(function aa(a, b) {
                    //console.log(a.getName());
                    //console.log(b.getName());



                    var datesA = a.getStartDate().split('-'),
                        datesB = b.getStartDate().split('-'),
                        monthA, monthB;
                    monthA = convertMonthsToNumbers(datesA[1]);
                    monthB = convertMonthsToNumbers(datesB[1]);
                    if (parseInt(datesA[2]) < parseInt(datesB[2])) {
                        return -1;
                    } else if (parseInt(datesA[2]) > parseInt(datesB[2])){
                        return 1;
                    } else {
                        if (monthA < monthB){
                            return -1;
                        } else if (monthA > monthB){
                            return 1
                        } else {
                            if (parseInt(datesA[0]) < parseInt(datesB[0])){
                                return -1;
                            } else if (parseInt(datesA[0]) > parseInt(datesB[0])){
                                return 1
                            } else {
                                if (a.getName() < b.getName()){
                                    return -1
                                } else{
                                    return 1;
                                }
                            }
                        }
                    }
                });


                function convertMonthsToNumbers(month){
                    var convertedMonth;
                    switch (month){
                        case 'Jan':  convertedMonth = 1;break;
                        case 'Feb':  convertedMonth = 2;break;
                        case 'Mar':  convertedMonth = 3;break;
                        case 'Apr':  convertedMonth = 4;break;
                        case 'May':  convertedMonth = 5;break;
                        case 'Jun':  convertedMonth = 6;break;
                        case 'Jul':  convertedMonth = 7;break;
                        case 'Aug':  convertedMonth = 8;break;
                        case 'Sep':  convertedMonth = 9;break;
                        case 'Oct':  convertedMonth = 10;break;
                        case 'Nov':  convertedMonth = 11;break;
                        case 'Dec':  convertedMonth = 12;break;
                    }
                    return convertedMonth;
                }


                //filteredTravels.sort(function (a, b) {
                //    if (a.getName() < b.getName()) {
                //        return 1;
                //    }
                //});
                var resultAfterFiltering= ''
                for (var filteredCount = 0; filteredCount < filteredTravels.length; filteredCount+=1){
                    resultAfterFiltering = resultAfterFiltering + filteredTravels[filteredCount].toString()+'\n';
                }
                resultAfterFiltering = resultAfterFiltering.trim();
                return resultAfterFiltering;
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processAddDestinationCommand: processAddDestinationCommand,
                processRemoveDestinationCommand: processRemoveDestinationCommand,
                processFilterTravelsCommand:processFilterTravelsCommand
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
                case "add-destination":
                    output = CommandProcessor.processAddDestinationCommand(commandArgs);
                    break;
                case "remove-destination":
                    output = CommandProcessor.processRemoveDestinationCommand(commandArgs);
                    break;
                case "list":
                    output = CommandProcessor.processListCommand(commandArgs);
                    break;
                case "filter":
                    output = CommandProcessor.processFilterTravelsCommand(commandArgs);
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

    var parseDate = function (dateStr) {
        if (!dateStr) {
            return undefined;
        }
        var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
        var dateFormatted = formatDate(date);
        if (dateStr != dateFormatted) {
            throw new Error("Invalid date: " + dateStr);
        }
        return date;
    }

    var formatDate = function (date) {
        var day = date.getDate();
        var monthName = date.toString().split(' ')[1];
        var year = date.getFullYear();
        return day + '-' + monthName + '-' + year;
    }

    var output = "";
    TravellingManager.init();

    commands.forEach(function(cmd) {
        var result;
        if (cmd != "") {
            try {
                result = TravellingManager.executeCommands(cmd) + "\n";
            } catch (e) {
                result = "Invalid command." + "\n";
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
            console.log(processTravelAgencyCommands(arr));
        });
    }
})();