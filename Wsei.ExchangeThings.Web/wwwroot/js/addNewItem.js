﻿(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        // 1. read data from the form
        const url = "/api/company"
        const requestData = JSON.stringify({
            Name: formElement.querySelector('input[name="Name"]').value,
            Description: formElement.querySelector('input[name="Description"]').value,
            isVisible: formElement.querySelector('input[name="IsVisible"]').checked
        });
        
        const jsonConfig = {
            method: "POST",
            headers: {
                "Content-type": "application/json"
            },
            body: requestData,
        };
        // 2. call the application server using fetch method
        const response = await fetch(url, jsonConfig);
        const responseJson = await response.json();

        if (response.status === 200 && responseJson) {
            // 3 un-hide the alertElement when the request has been successful
            alertElement.style.display = "block";
        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();