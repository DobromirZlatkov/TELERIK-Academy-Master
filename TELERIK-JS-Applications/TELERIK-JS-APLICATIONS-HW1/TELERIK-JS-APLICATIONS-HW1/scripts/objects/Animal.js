define([], function () {
    var Animal = (function () {
        function Animal(species,name, numberOfLegs) {
            this.species = species;
            this.name = name;
            this.numberOfLegs = numberOfLegs;
        }

        Animal.prototype.toString = function () {
            return this.species + '__' + this.numberOfLegs;
        }

        return Animal;
    }());
    return Animal;
});
