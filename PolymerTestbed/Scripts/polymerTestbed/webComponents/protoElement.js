polymerTestBed = polymerTestBed || {};

(function () {
    polymerTestBed.components = polymerTestBed.components || {};

    var protoElement = function () {
        Polymer({
            is: "proto-element",
            ready: function () {
                console.log('function called');
            }
        });
    };

    polymerTestBed.components.ProtoElement = protoElement;
})();