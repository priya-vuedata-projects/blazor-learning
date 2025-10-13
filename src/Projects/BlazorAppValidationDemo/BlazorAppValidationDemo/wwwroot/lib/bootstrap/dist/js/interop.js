window.interopFunctions = {
    showAlert: function (message) {
        alert(message);
    },
    logToConsole: function (data) {
        console.log("Blazor Log:", data);
    },
    triggerDotNet: function (dotNetRef) {
        dotNetRef.invokeMethodAsync("FromJavaScript");
    }
};
