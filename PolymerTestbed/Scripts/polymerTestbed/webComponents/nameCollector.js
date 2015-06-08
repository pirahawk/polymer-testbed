polymerTestBed = polymerTestBed || {};

(function () {
    polymerTestBed.components = polymerTestBed.components || {};
    var protoElement = function () {
        Polymer({
            is: "name-collector",

            properties: {

                id: String,

                firstName: {
                    type: String,
                    observer: 'printName',
                    reflectToAttribute: true,
                },

                lastName: {
                    type: String,
                    observer: 'printName',
                    reflectToAttribute: true
                },

                fullName: {
                    type: String,
                    computed: 'computeFullName(firstName, lastName)',
                }
            },

            computeFullName: function(fName, lName) {
                return fName + ' ' + lName;
            },

            printName: function (newValue, oldValue) {
                console.log('Name: ' + this.fullName);
            },

        });
    };
    polymerTestBed.components.NameCollector = protoElement;
})();