/* global $ */

function calculateLeftConversion() {
    var currencyDdlVal = $('#Currencies').val();
    var sandwichDdlVal = $('#Sandwiches').val();
    var leftInputVal = $('#left-input').val();
    var middleModVal = (Math.max(currencyDdlVal, sandwichDdlVal) - Math.min(currencyDdlVal, sandwichDdlVal)) / 2;
    var convertedValue = middleModVal * leftInputVal;
    $('#sandwich-input').val(convertedValue.toFixed(2));
}

function calculateSandwichConversion() {
    var currencyDdlVal = $('#Currencies').val();
    var sandwichDdlVal = $('#Sandwiches').val();
    var sandwichInputVal = $('#sandwich-input').val();
    var middleModVal = (Math.max(currencyDdlVal, sandwichDdlVal) - Math.min(currencyDdlVal, sandwichDdlVal)) / 2;
    var convertedValue = middleModVal * sandwichInputVal;
    $('#left-input').val(convertedValue.toFixed(2));
}

$(document).ready(function () {
	$(document).on('keyup', '#left-input', function (){
		calculateLeftConversion();
	});

	$(document).on('keyup', '#sandwich-input', function (){
		calculateSandwichConversion();
	});

	$(document).on('change', '#Currencies', function () {
	    calculateLeftConversion();
	});

	$(document).on('change', '#Sandwiches', function () {
	    calculateSandwichConversion();
	});

});