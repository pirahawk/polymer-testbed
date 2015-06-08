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
                    observer: 'nameChanged',
                    reflectToAttribute: true,
                },

                lastName: {
                    type: String,
                    observer: 'nameChanged',
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

            nameChanged: function (newValue, oldValue) {
                console.log('Name: ' + this.fullName);
                this.$.fullName.textContent = this.fullName;
            },

        });
    };
    polymerTestBed.components.NameCollector = protoElement;
})();