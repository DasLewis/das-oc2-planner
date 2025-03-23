function downloadCsvFile(filename, content) {
    var element = document.createElement('a');
    element.setAttribute('href', 'data:text/csv;charset=utf-8,' + encodeURIComponent(content));
    element.setAttribute('download', filename);

    element.style.display = 'none';
    document.body.appendChild(element);

    element.click();

    document.body.removeChild(element);
}
function downloadJsonFile(filename, content) {
    var element = document.createElement('a');
    element.setAttribute('href', 'data:text/json;charset=utf-8,' + encodeURIComponent(content));
    element.setAttribute('download', filename);

    element.style.display = 'none';
    document.body.appendChild(element);

    element.click();

    document.body.removeChild(element);
}

function hideOptionExceptForSource(username, oldUsername, sourceOptionId) {
    const selectLists = document.querySelectorAll('select[id^=SELECT-USERS]');
    //option-@copyJ
    Array.prototype.forEach.call(selectLists, list => {
        //options are the options that have the value that is currently being set, so they should hide that entry
        var options = list.querySelectorAll('option[value^="' + username + '"]');
        //console.log(options);
        Array.prototype.forEach.call(options, option => {
            var optionId = option.id;
            //the selected option should of course not be hidden on the select that it was selected on aaaaaaa
            if (optionId != sourceOptionId) {
                console.log("hiding option - " + optionId);
                document.querySelector('option[id="' + optionId + '"]').style.visibility = 'hidden';
            }
        })
        //
        if (oldUsername != "") {
            var previousOptions = list.querySelectorAll('option[value^="' + oldUsername + '"]');
            Array.prototype.forEach.call(previousOptions, option => {
            //previousOptions.foreach(option => {
                var optionId = option.id;
                console.log("showing option - " + optionId);
                document.querySelector('option[id="' + optionId + '"]').style.visibility = 'visible';
            })
        }
    })
}
