﻿const dotnet = {
    getStaticMethod: (expression, index = 0) => {
        const parts = expression.split(":");
        const namespace = parts[0];
        const type = parts[1];
        const method = parts[2];

        const finalMethod = function (...args) {
            const callStaticMethodBinding = _$internalBinding["InteropInternalCallStaticMethod"];

            return callStaticMethodBinding(namespace, type, method, index, [...args]);
        }

        return finalMethod;
    },
    getStaticProperty: (expression) => {
        const parts = expression.split(":");
        const namespace = parts[0];
        const type = parts[1];
        const property = parts[2];

        const callStaticPropertyBinding = _$internalBinding["InteropInternalGetStaticProperty"];
        const internalStaticProperty = callStaticPropertyBinding(namespace, type, property);

        return internalStaticProperty;
    }
}