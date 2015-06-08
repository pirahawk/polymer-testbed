polymerTestBed = polymerTestBed || {};

(function () {
    polymerTestBed.components = polymerTestBed.components || {};

    var protoElement = Polymer({
        is: "proto-element",
        ready: function () {
            //...
        }
    });
    polymerTestBed.components.ProtoElement = protoElement;
})();