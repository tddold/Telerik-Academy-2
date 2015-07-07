function processEstatesAgencyCommands(commands) {

    'use strict';


    var Estate = (function() {
        var parsedValue;
        var Estate = {};
            Object.defineProperties(Estate, {
                init:{
                    value: function(name, area, location, isFurnitured, objectType){
                        this.name = name;
                        this.area = area;
                        this.location = location;
                        this.isFurnitured = isFurnitured;
                        this.objectType = objectType;
                        return this;
                    }
                },
                name:{
                    get: function(){
                        return this._name;
                    },
                    set: function(value){
                        if (!value || value ===''){
                            throw new Error;
                        }
                        this._name = value;
                    }
                },
                area:{
                    get: function(){
                        return this._area;
                    },
                    set: function(value){
                        parsedValue = parseInt(value);
                        if (parsedValue !== value ||isNaN(parsedValue) || parsedValue < 1 || parsedValue > 10000){
                            throw new Error
                        }
                        this._area = parsedValue;
                    }
                },
                location: {
                    get: function(){
                        return this._location;
                    },
                    set: function(value){
                        if (!value || value ===''){
                            throw new Error;
                        }
                        this._location = value;
                    }
                },
                isFurnitured: {
                    get: function(){
                        return this._isFurnitured;
                    },
                    set: function(value){
                        if (value !== true && value!== false){
                            throw new Error;
                        }
                        this._isFurnitured = value;
                    }
                },
                toString:{
                    value: function(){
                        var furnituredAsString = this.isFurnitured === true ? 'Yes' : 'No';
                        return this.objectType+': Name = '+this.name+', Area = '+this.area+', Location = '+this.location+', Furnitured = ' + furnituredAsString
                    }
                }

            });
        return Estate;
    }());


    var BuildingEstate = (function(parent) {
        var parsedValueRooms;
        var BuildingEstate = Object.create(parent);
        Object.defineProperties(BuildingEstate, {
            init:{
                value: function(name, area, location, isFurnitured, rooms, hasElevator, objectType){
                    parent.init.call(this, name, area, location, isFurnitured, objectType);
                    this.rooms = rooms;
                    this.hasElevator = hasElevator;
                    return this;
                }
            },
            rooms :{
                get: function(){
                    return this._rooms;
                },
                set: function(value){
                    parsedValueRooms = parseInt(value);
                    if (isNaN(parsedValueRooms)|| parsedValueRooms < 0 || parsedValueRooms > 100){
                        throw new Error
                    }
                    this._rooms = parsedValueRooms;
                }
            },
            hasElevator:{
                get: function(){
                    return this._hasElevator;
                },
                set: function(value){
                    if (value !== true && value !== false){
                        throw new Error;
                    }
                    this._hasElevator = value;
                }
            },
            toString:{
                value: function(){
                    var elevatorAsString = this.hasElevator === true ? 'Yes' : 'No';
                    return parent.toString.call(this) + ', Rooms: ' + this.rooms + ', Elevator: ' + elevatorAsString
                }
            }
        })
        return BuildingEstate;
    }(Estate));


    var Apartment = (function(parent) {
        var Apartment = Object.create(parent);
        Object.defineProperties(Apartment, {
            init:{
                value:function(name, area, location, isFurnitured, rooms, hasElevator){
                    parent.init.call(this,name, area, location, isFurnitured, rooms, hasElevator, 'Apartment');
                    return this;
                }
            },
            toString:{
                value: function(){
                    return parent.toString.call(this)
                }
            }
        })
        return Apartment
    }(BuildingEstate));


    var Office = (function(parent) {
        var Office = Object.create(parent);
        Object.defineProperties(Office,{
            init:{
                value: function(name, area, location, isFurnitured, rooms, hasElevator){
                    parent.init.call(this,name, area, location, isFurnitured, rooms, hasElevator, 'Office')
                    return this;
                }
            },
            toString:{
                value: function(){
                    return parent.toString.call(this)
                }
            }
        })
        return Office;
    }(BuildingEstate));


    var House = (function(parent) {
        var House = Object.create(parent),
            parsedValueFloors;
        Object.defineProperties(House,{
            init:{
                value: function(name, area, location, isFurnitured, floors){
                    parent.init.call(this, name, area, location, isFurnitured, 'House');
                    this.floors = floors;
                    return this;
                }
            },
            floors:{
                get: function(){
                    return this._floors
                },
                set: function(value){
                    parsedValueFloors = parseInt(value);
                    if (isNaN(parsedValueFloors) || parsedValueFloors <1 || parsedValueFloors >10 ){
                        throw new Error;
                    }
                    this._floors = parsedValueFloors
                }
            },
            toString:{
                value: function(){
                    return parent.toString.call(this) + ', Floors: ' + this.floors
                }
            }
        });
        return House;
    }(Estate));


    var Garage = (function(parent) {
        var Garage = Object.create((parent)),
            parsedValueWidth,
            parsedValueHeight;
        Object.defineProperties(Garage, {
            init: {
                value: function (name, area, location, isFurnitured, width, height) {
                    parent.init.call(this, name, area, location, isFurnitured, 'Garage');
                    this.width = width;
                    this.height = height;
                    return this;
                }
            },
            width: {
                get: function () {
                    return this._width;
                },
                set: function (value) {
                    parsedValueWidth = parseInt(value);
                    if (isNaN(parsedValueWidth) || parsedValueWidth < 1 || parsedValueWidth > 500) {
                        throw new Error;
                    }

                    this._width = parsedValueWidth;
                }
            },
            height:{
                get: function(){
                    return this._height
                },
                set: function(value) {
                    parsedValueHeight = parseInt(value);
                    if (isNaN(parsedValueHeight) || parsedValueHeight < 1 || parsedValueHeight > 500) {
                        throw new Error;
                    }

                    this._height = parsedValueHeight;
                }
            },
            toString:{
                value: function(){
                    return parent.toString.call(this) + ', Width: '+this.width +', Height: ' +this.height;
                }
            }
        });
        return Garage
    }(Estate));


    var Offer = (function() {
        var Offer = {}, parsedPrice;
        Object.defineProperties(Offer,{
            init:{
                value:function(estate, price, offerType){
                    this.estate = estate;
                    this.price = price;
                    this.offerType = offerType
                    return this;
                }
            },
            estate:{
                get: function(){
                    return this._estate;
                },
                set: function(value){
                    if (value === undefined){
                        throw new Error;
                    }
                    this._estate = value
                }
            },
            price: {
                get: function(){
                    return this._price;
                },
                set: function(value){
                    parsedPrice = parseInt(value);
                    if (isNaN(parsedPrice) || parsedPrice < 1 || parsedPrice !== value){
                        throw new Error;
                    }
                    this._price = parsedPrice;
                }
            },
            toString:{
                value: function(){
                    return this.offerType + ': Estate = '+ this.estate.name + ', Location = ' + this.estate.location + ', Price = ' + this.price
                }
            }
        });

        return Offer;
    }());


    var RentOffer = (function(parent) {
        var RentOffer = Object.create(parent);
        Object.defineProperties(RentOffer,{
            init: {
                value: function (estate, price) {
                    parent.init.call(this,estate, price, 'Rent');
                    return this;
                }
            },
            toString:{
                value: function(){
                    return parent.toString.call(this);
                }
            }
        });
        return RentOffer;
    }(Offer));


    var SaleOffer = (function(parent) {
        var SaleOffer = Object.create(parent);
        Object.defineProperties(SaleOffer, {
            init:{
                value: function (estate, price) {
                    parent.init.call(this,estate, price, 'Sale');
                    return this;
                }
            },
            toString:{
                value: function(){
                    return parent.toString.call(this);
                }
            }
        });
        return SaleOffer;
    }(Offer));


    var EstatesEngine = (function() {
        var _estates;
        var _uniqueEstateNames;
        var _offers;

        function initialize() {
            _estates = [];
            _uniqueEstateNames = {};
            _offers = [];
        }

        function executeCommand(command) {
            var cmdParts = command.split(' ');
            var cmdName = cmdParts[0];
            var cmdArgs = cmdParts.splice(1);
            switch (cmdName) {
            case 'create':
                return executeCreateCommand(cmdArgs);
            case 'status':
                return executeStatusCommand();
            case 'find-sales-by-location':
                return executeFindSalesByLocationCommand(cmdArgs[0]);
            case 'find-rents-by-location':
                return executeFindRentsByLocationCommand(cmdArgs[0]);
            case 'find-rents-by-price':
                return executeFindRentsByPriceCommand(cmdArgs[0], cmdArgs[1]);
            default:
                throw new Error('Unknown command: ' + cmdName);
            }
        }

        function executeCreateCommand(cmdArgs) {
            var objType = cmdArgs[0];
            switch (objType) {
            case 'Apartment':
                var apartment = Object.create(Apartment).init(cmdArgs[1], Number(cmdArgs[2]), cmdArgs[3],
                    parseBoolean(cmdArgs[4]), Number(cmdArgs[5]), parseBoolean(cmdArgs[6]));
                addEstate(apartment);
                break;
            case 'Office':
                var office = Object.create(Office).init(cmdArgs[1], Number(cmdArgs[2]), cmdArgs[3],
                    parseBoolean(cmdArgs[4]), Number(cmdArgs[5]), parseBoolean(cmdArgs[6]));
                addEstate(office);
                break;
            case 'House':
                var house = Object.create(House).init(cmdArgs[1], Number(cmdArgs[2]), cmdArgs[3],
                    parseBoolean(cmdArgs[4]), Number(cmdArgs[5]));
                addEstate(house);
                break;
            case 'Garage':
                var garage = Object.create(Garage).init(cmdArgs[1], Number(cmdArgs[2]), cmdArgs[3],
                    parseBoolean(cmdArgs[4]), Number(cmdArgs[5]), Number(cmdArgs[6]));
                addEstate(garage);
                break;
            case 'RentOffer':
                var estate = findEstateByName(cmdArgs[1]);
                var rentOffer = Object.create(RentOffer).init(estate, Number(cmdArgs[2]));
                addOffer(rentOffer);
                break;
            case 'SaleOffer':
                estate = findEstateByName(cmdArgs[1]);
                var saleOffer = Object.create(SaleOffer).init(estate, Number(cmdArgs[2]));
                addOffer(saleOffer);
                break;
            default:
                throw new Error('Unknown object to create: ' + objType);
            }
            return objType + ' created.';
        }

        function parseBoolean(value) {
            switch (value) {
            case "true":
                return true;
            case "false":
                return false;
            default:
                throw new Error("Invalid boolean value: " + value);
            }
        }

        function findEstateByName(estateName) {
            for (var i = 0; i < _estates.length; i++) {
                if (_estates[i].name == estateName) {
                    return _estates[i];
                }
            }
            return undefined;
        }

        function addEstate(estate) {
            if (_uniqueEstateNames[estate.name]) {
                throw new Error('Duplicated estate name: ' + estate.name);
            }
            _uniqueEstateNames[estate.name] = true;
            _estates.push(estate);
        }

        function addOffer(offer) {
            _offers.push(offer);
        }

        function executeStatusCommand() {
            var result = '', i;
            if (_estates.length > 0) {
                result += 'Estates:\n';
                for (i = 0; i < _estates.length; i++) {
                    result += "  " + _estates[i].toString() + '\n';
                }
            } else {
                result += 'No estates\n';
            }

            if (_offers.length > 0) {
                result += 'Offers:\n';
                for (i = 0; i < _offers.length; i++) {
                    result += "  " + _offers[i].toString() + '\n';
                }
            } else {
                result += 'No offers\n';
            }

            return result.trim();
        }

        function executeFindRentsByPriceCommand(minPrice, maxPrice){
            if (!minPrice || !maxPrice){
                throw new Error;
            }
            if (minPrice.indexOf('.')> -1 || maxPrice.indexOf('.')> -1){
                throw new Error;
            }
            var parsedMinPrice = parseInt(minPrice),parsedMaxPrice = parseInt(maxPrice);
            if (isNaN(parsedMinPrice) || isNaN(parsedMaxPrice)){
                throw new Error;
            }

            var selectedOffersByPrice = _offers.filter(function(offer) {
                return offer.price >= parsedMinPrice && offer.price <= parsedMaxPrice &&
                    offer.offerType === 'Rent';
            });
            selectedOffersByPrice.sort(function(a, b) {
                if (a.price > b.price){
                    return 1;
                } else if (a.price < b.price){
                    return -1;
                } else {
                    if (a.estate.name > b.estate.name) {
                        return 1;
                    } else if (a.estate.name < b.estate.name) {
                        return -1;
                    }
                }
            });
            return formatQueryResults(selectedOffersByPrice);

        }
        function executeFindSalesByLocationCommand(location) {
            if (!location) {
                throw new Error("Location cannot be empty.");
            }
            var selectedOffers = _offers.filter(function(offer) {
                return offer.estate.location === location &&
                     offer.offerType === 'Sale';
            });
            selectedOffers.sort(function(a, b) {
                return a.estate.name.localeCompare(b.estate.name);
            });
            return formatQueryResults(selectedOffers);
        }

        function executeFindRentsByLocationCommand(location){
            if (!location) {
                throw new Error("Location cannot be empty.");
            }
            var selectedOffers = _offers.filter(function(offer) {
                return offer.estate.location === location &&
                    offer.offerType === 'Rent';
            });
            selectedOffers.sort(function(a, b) {
                return a.estate.name.localeCompare(b.estate.name);
            });
            return formatQueryResults(selectedOffers);
        }

        function formatQueryResults(offers) {
            var result = '';
            if (offers.length == 0) {
                result += 'No Results\n';
            } else {
                result += 'Query Results:\n';
                for (var i = 0; i < offers.length; i++) {
                    var offer = offers[i];
                    result += '  [Estate: ' + offer.estate.name +
                        ', Location: ' + offer.estate.location +
                        ', Price: ' + offer.price + ']\n';
                }
            }
            return result.trim();
        }

        return {
            initialize: initialize,
            executeCommand: executeCommand
        };
    }());


    // Process the input commands and return the results
    var results = '';
    EstatesEngine.initialize();
    commands.forEach(function(cmd) {
        if (cmd != '') {
            try {
                var cmdResult = EstatesEngine.executeCommand(cmd);
                results += cmdResult + '\n';
            } catch (err) {
                //console.log(err);
                results += 'Invalid command.\n';
            }
        }
    });
    return results.trim();

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
            console.log(processEstatesAgencyCommands(arr));
        });
    }
})();
