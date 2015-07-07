function processRestaurantManagerCommands(commands) {
    'use strict';

    var RestaurantEngine = (function () {
        var _restaurants, _recipes;

        function initialize() {
            _restaurants = [];
            _recipes = [];
        }
        function validateName(value, parameter){
            if (!(value) || value === '') {
                throw new Error('The '+ parameter+' is required.')
            }
        }

        function validateNumeral(value, parameter){
            var parsedValue = parseFloat(value);
            if (isNaN(parsedValue ) || parsedValue <=0){
                throw new Error('The '+ parameter + ' must be positive.')
            }
        }

        var Restaurant = (function () {
            var Restaurant = {};
            Object.defineProperties(Restaurant,{
                init:{
                    value:function(name, location){
                        this.name = name;
                        this.location = location;
                        this._collectionOfRecipes = [];
                        return this;
                    }
                },
                name:{
                    get:function(){
                        return this._name;
                    },
                    set: function(value){
                        validateName(value, 'name');
                        this._name = value
                    }
                },
                location:{
                    get: function(){
                        return this._location;
                    },
                    set: function(value){
                        validateName(value, 'location');
                        this._location = value;
                    }
                },
                addRecipe:{
                    value:function(recipe){
                        this._collectionOfRecipes.push(recipe);
                    }
                },
                removeRecipe:{
                    value:function(recipe){
                        var lengthOfCollection = this._collectionOfRecipes.length,
                            recipesCounter;
                        if (lengthOfCollection > 0) {
                            for (recipesCounter = 0; recipesCounter < lengthOfCollection; recipesCounter += 1) {
                                if (this._collectionOfRecipes[recipesCounter].name === recipe.name &&
                                this._collectionOfRecipes[recipesCounter].location === recipe.location){
                                    this._collectionOfRecipes.splice(recipesCounter, 1);
                                    lengthOfCollection = lengthOfCollection -1;
                                }
                            }
                        }
                    }
                },
                printRestaurantMenu:{
                    value: function(){
                        var result = '', drinks = [],
                        result = '***** '+this.name + ' - '+ this.location+' *****\n'
                        if (this._collectionOfRecipes.length === 0){
                            result = result + 'No recipes... yet\n'
                        } else {
                            result = result +loopThroughRecipes('Drink','DRINKS', this);
                            result = result +loopThroughRecipes('Salad','SALADS', this);
                            result = result +loopThroughRecipes('MainCourse','MAIN COURSES', this);
                            result = result +loopThroughRecipes('Dessert', 'DESSERTS', this);
                        }
                        return result;
                    }
                }
            })
            function loopThroughRecipes(typeOfRecipe,  title, that){
                var filteredRecipes = [], resultOfLooping = '';
                filteredRecipes = that._collectionOfRecipes.filter(function(a){
                    if (a.objectType === typeOfRecipe){
                        return a;
                    }
                });
                if (filteredRecipes.length > 0){
                    resultOfLooping = resultOfLooping + '~~~~~ '+title+' ~~~~~\n'
                    for (var dr = 0; dr < filteredRecipes.length; dr +=1){
                        resultOfLooping = resultOfLooping +filteredRecipes[dr].toString();
                    }
                }

                return resultOfLooping;
            }

            return Restaurant;
        }())



        var Recipe = (function () {
            var Recipe = {};
            Object.defineProperties(Recipe, {
                init:{
                    value: function(name, price, calories, quantityPerServing, timeToPrepare, units, objectType){
                        this.name = name;
                        this.price = price;
                        this.calories = calories;
                        this.quantityPerServing = quantityPerServing;
                        this.timeToPrepare = timeToPrepare;
                        this.units = units;
                        this.objectType = objectType
                        return this;
                    }
                },
                name:{
                    get: function(){
                        return this._name;
                    },
                    set:function(value){
                        validateName(value, 'name');
                        this._name = value;
                    }
                },
                price:{
                    get: function(){
                        return this._price;
                    },
                    set: function(value){
                        validateNumeral(value, 'price');
                        this._price =  value.toFixed(2);
                    }
                },
                calories:{
                    get:function(){
                        return this._calories;
                    },
                    set: function(value){
                        validateNumeral(value , 'calories');
                        this._calories = value;
                    }
                },
                quantityPerServing:{
                    get: function(){
                        return this._quantityPerServing;
                    },
                    set: function(value){
                        validateNumeral(value, 'quantity per serving');
                        this._quantityPerServing = value;
                    }
                },
                timeToPrepare:{
                    get:function(){
                        return this._timeToPrepare;
                    },
                    set: function(value){
                        this._timeToPrepare = value;
                    }
                },
                units:{
                    get: function(){
                        return this._units;
                    },
                    set: function(value){
                        this._units = value;
                    }
                },
                objectType:{
                    get: function(){
                        return this._objectType;
                    },
                    set:function(value){
                        this._objectType = value ;
                    }
                },
                toString: {
                    value: function(){
                        var returnedString = '';
                        returnedString = '==  ' + this.name +' == $'+this.price +'\n'+
                                        'Per serving: ' + this.quantityPerServing + ' ' + this.units + ', ' + this.calories + ' kcal\n'+
                                        'Ready in '+this.timeToPrepare +' minutes';
                        return returnedString;
                    }
                }

            })
            return Recipe;
        }())

        var Drink = (function (parent) {
            var Drink = Object.create(parent);
            Object.defineProperties(Drink,{
                init:{
                    value:function(name, price, calories, quantity, timeToPrepare, isCarbonated) {
                        validateDrinkCalories(calories);
                        validateDrinkTimeToPrepare(timeToPrepare);
                        parent.init.call(this, name, price, calories, quantity, timeToPrepare, 'ml', 'Drink');
                        this.isCarbonated = isCarbonated;
                        return this;
                    }
                },
                isCarbonated:{
                    get: function(){
                        return this._isCarbonated;
                    },
                    set: function(value){
                        this._isCarbonated = value;
                    }
                },
                toString:{
                    value:function(){
                        var returnedDrinkString = '',
                            carbonatedAsString = this.isCarbonated === true ? 'yes' : 'no'
                        returnedDrinkString = parent.toString.call(this) + '\nCarbonated: '+ carbonatedAsString+'\n';
                        return returnedDrinkString
                    }
                }
            })

            function validateDrinkCalories(calories){
                var parsedCalories = parseFloat(calories);
                if (parsedCalories> 100){
                    throw new Error;
                }
            };

            function validateDrinkTimeToPrepare(timeToPrepare){
                var parsedDrinkTime = parseFloat(timeToPrepare);
                if (parsedDrinkTime> 20){
                    throw new Error;
                }
            };

            return Drink;
        }(Recipe))

        var Meal = (function (parent) {
            var Meal = Object.create(parent);
            Object.defineProperties(Meal, {
                init:{
                    value: function(name, price, calories, quantity, timeToPrepare, isVegan, objectType){
                        parent.init.call(this, name, price, calories, quantity, timeToPrepare, 'g', objectType)
                        this.isVegan = isVegan;
                        return this;
                    }
                },
                isVegan:{
                    get: function(){
                        return this._isVegan;
                    },
                    set: function(value){
                        this._isVegan = value;
                    }
                },
                toggleVegan:{
                    value: function(){
                        this.isVegan = this.isVegan === true ? false : true;
                    }
                },
                toString:{
                    value: function(){
                        var veganToString = this.isVegan === true ? '[VEGAN] ' : '';
                        return  veganToString +parent.toString.call(this) + '\n';
                    }
                }
            })

            return Meal;
        }(Recipe))

        var Dessert = (function (parent) {
            var Dessert = Object.create(parent);

            Object.defineProperties(Dessert, {
                init:{
                    value: function(name, price, calories, quantity, timeToPrepare, isVegan){
                        parent.init.call(this, name, price, calories, quantity, timeToPrepare, isVegan, 'Dessert')
                        this.withSugar = true;
                        return this;
                    }
                },
                withSugar:{
                    get:function(){
                        return this._withSugar;
                    },
                    set: function(value){
                        this._withSugar = value;
                    }
                },
                toggleSugar:{
                    value: function(){
                        this.withSugar = this.withSugar === true ? false : true;
                    }
                },
                toString:{
                    value: function(){
                        var sugarToString = this.withSugar === true ? '' : '[NO SUGAR] ';
                        return  sugarToString+ parent.toString.call(this);
                    }
                }
            })

            return Dessert;
        }(Meal));

        var MainCourse = (function (parent) {
            var MainCourse = Object.create(parent);
            Object.defineProperties(MainCourse, {
                init:{
                    value: function(name, price, calories, quantity, timeToPrepare, isVegan, type){
                        parent.init.call(this, name, price, calories, quantity, timeToPrepare, isVegan, 'MainCourse');
                        this.type = type;
                        return this;
                    }
                },
                type:{
                    get: function(){
                        return this._type;
                    },
                    set: function(value){
                        this._type = value;
                    }
                },
                toString:{
                    value: function(){
                        return parent.toString.call(this) + 'Type: ' + this.type +'\n';
                    }
                }
            });

            return MainCourse;
        }(Meal))

        var Salad = (function (parent) {
            var Salad = Object.create(parent);
            Object.defineProperties(Salad, {
                init:{
                    value: function(name, price, calories, quantity, timeToPrepare, containsPasta){
                        parent.init.call(this, name, price, calories, quantity, timeToPrepare,true, 'Salad');
                        this.containsPasta = containsPasta;
                        return this;
                    }
                },
                containsPasta:{
                    get: function(){
                        return this._containsPasta;
                    },
                    set: function(value){
                        this._containsPasta = value;
                    }
                },
                toString:{
                    value: function(){
                        var pastaToString = this.containsPasta === true ? 'yes' : 'no';
                        return parent.toString.call(this) + 'Contains pasta: ' + pastaToString+'\n';
                    }
                }
            })
            return Salad;
        }(Meal))

        var Command = (function () {

            function Command(commandLine) {
                this._params = new Array();
                this.translateCommand(commandLine);
            }

            Command.prototype.translateCommand = function (commandLine) {
                var self, paramsBeginning, name, parametersKeysAndValues;
                self = this;
                paramsBeginning = commandLine.indexOf("(");

                this._name = commandLine.substring(0, paramsBeginning);
                name = commandLine.substring(0, paramsBeginning);
                parametersKeysAndValues = commandLine
                    .substring(paramsBeginning + 1, commandLine.length - 1)
                    .split(";")
                    .filter(function (e) { return true });

                parametersKeysAndValues.forEach(function (p) {
                    var split = p
                        .split("=")
                        .filter(function (e) { return true; });
                    self._params[split[0]] = split[1];
                });
            }

            return Command;
        }());

        function createRestaurant(name, location) {
            _restaurants[name] = Object.create(Restaurant).init(name, location);
            return "Restaurant " + name + " created\n";
        }

        function createDrink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
            _recipes[name] = Object.create(Drink).init(name, price, calories, quantity, timeToPrepare, isCarbonated);
            return "Recipe " + name + " created\n";
        }

        function createSalad(name, price, calories, quantity, timeToPrepare, containsPasta) {
            _recipes[name] = Object.create(Salad).init(name, price, calories, quantity, timeToPrepare, containsPasta);
            return "Recipe " + name + " created\n";
        }

        function createMainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
            _recipes[name] = Object.create(MainCourse).init(name, price, calories, quantity, timeToPrepare, isVegan, type);
            return "Recipe " + name + " created\n";
        }

        function createDessert(name, price, calories, quantity, timeToPrepare, isVegan) {
            _recipes[name] = Object.create(Dessert).init(name, price, calories, quantity, timeToPrepare, isVegan);
            return "Recipe " + name + " created\n";
        }

        function toggleSugar(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }
            recipe = _recipes[name];

            if (recipe.objectType === 'Dessert') {
                recipe.toggleSugar();
                return "Command ToggleSugar executed successfully. New value: " + recipe._withSugar.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleSugar is not applicable to recipe " + name + "\n";
            }
        }

        function toggleVegan(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }

            recipe = _recipes[name];
            if (recipe.objectType === 'MainCourse' || recipe.objectType === 'Dessert' || recipe.objectType === 'Salad') {
                recipe.toggleVegan();
                return "Command ToggleVegan executed successfully. New value: " +
                    recipe._isVegan.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleVegan is not applicable to recipe " + name + "\n";
            }
        }

        function printRestaurantMenu(name) {
            var restaurant;

            if (!_restaurants.hasOwnProperty(name)) {
                throw new Error("The restaurant " + name + " does not exist");
            }

            restaurant = _restaurants[name];
            return restaurant.printRestaurantMenu();
        }

        function addRecipeToRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }
            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.addRecipe(recipe);
            return "Recipe " + recipeName + " successfully added to restaurant " + restaurantName + "\n";
        }

        function removeRecipeFromRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }
            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.removeRecipe(recipe);
            return "Recipe " + recipeName + " successfully removed from restaurant " + restaurantName + "\n";
        }

        function executeCommand(commandLine) {
            var cmd, params, result;
            cmd = new Command(commandLine);
            params = cmd._params;

            switch (cmd._name) {
                case 'CreateRestaurant':
                    result = createRestaurant(params["name"], params["location"]);
                    break;
                case 'CreateDrink':
                    result = createDrink(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["carbonated"]));
                    break;
                case 'CreateSalad':
                    result = createSalad(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["pasta"]));
                    break;
                case "CreateMainCourse":
                    result = createMainCourse(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]), params["type"]);
                    break;
                case "CreateDessert":
                    result = createDessert(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]));
                    break;
                case "ToggleSugar":
                    result = toggleSugar(params["name"]);
                    break;
                case "ToggleVegan":
                    result = toggleVegan(params["name"]);
                    break;
                case "AddRecipeToRestaurant":
                    result = addRecipeToRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "RemoveRecipeFromRestaurant":
                    result = removeRecipeFromRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "PrintRestaurantMenu":
                    result = printRestaurantMenu(params["name"]);
                    break;
                default:
                    throw new Error('Invalid command name: ' + cmdName);
            }

            return result;
        }

        function parseBoolean(value) {
            switch (value) {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    throw new Error("Invalid boolean value: " + value);
            }
        }

        return {
            initialize: initialize,
            executeCommand: executeCommand
        };
    }());


    // Process the input commands and return the results
    var results = '';
    RestaurantEngine.initialize();
    commands.forEach(function (cmd) {
        if (cmd != "") {
            try {
                var cmdResult = RestaurantEngine.executeCommand(cmd);
                results += cmdResult;
            } catch (err) {
                results += err.message + "\n";
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
            console.log(processRestaurantManagerCommands(arr));
        });
    }
})();
