PolymerTestBed = PolymerTestBed || {};

(function() {
    var register = [];


    PolymerTestBed.registerWebComponent = function (polymerComponent) {
        if (!polymerComponent || !polymerComponent.is) {
            return;
        }
        
        var registeredComponent = _.find(register, function(component) {
            return component.is === polymerComponent.is;
        });

        var component = registeredComponent || { is: polymerComponent.is };
        //component.creator = Polymer.Class(polymerComponent);
        component.creator = Polymer(polymerComponent);

        if (!registeredComponent) {
            register.push(component);
        }
    };
})();