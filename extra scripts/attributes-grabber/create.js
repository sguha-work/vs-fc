/*

open "http://www.fusioncharts.com/dev/chart-attributes.html", go to console and run the following script, it will print a JSON in console.
*********************************************
var data = {};$("a[data-chartname]").each(function(){data[$(this).attr('data-alias')]=$(this).attr('data-examplefile'); });console.log(JSON.stringify(data, null, 4));
*********************************************

copy the json

*/
var fs,
	fileNamesArray,
	numberOfAttributeFiles,
	indexOfPresentFile,
	attributeDirectoryName,
	finalFilePath,
	readAndPrepareFileContent,
	finalJSON,
	interval,
	fileNameObject;

attributeDirectoryName = "attribute";
finalFilePath = "final/final.json"
fs = require("fs");
fileNamesArray = [];
finalJSON = {};
indexOfPresentFile = 0;

fs.readFile("data-file-name.js", function(error, data) {
	fileNameObject = JSON.parse(data);
});

// making the final file empty
fs.writeFile(finalFilePath, "", function(error, data) {

});

// preparing the attribute files list
fs.readdir(attributeDirectoryName, function(error, list) {
	list.forEach(function(file) {
		fileNamesArray.push(file);
	});
	numberOfAttributeFiles = fileNamesArray.length;	
});

// this function read a single attribute file and prepare the object from the data of the file
readAndPrepareFileContent = (function(fileName) {
	var keyName,
		jsonObject;

	keyName = fileName.split(".")[0].toLowerCase();
	jsonObject = {};

	console.log(fileName);
	fs.readFile(attributeDirectoryName+"/"+fileName, function(error, data) {
		var dataArray,
			typeIndex,
			category,
			attributes,
			attributeIndex;

		dataArray = JSON.parse(data);
		attributes = {};

		for(typeIndex in dataArray) {
			category = "";
			if(typeof dataArray[typeIndex].table != "undefined") {
				category = dataArray[typeIndex].table;
			}
			for(attributeIndex in dataArray[typeIndex].attrs) {
				dataArray[typeIndex].attrs[attributeIndex].category = category;
				switch (dataArray[typeIndex].attrs[attributeIndex].type.toLowerCase()) {
					
					case "number":
						if(typeof dataArray[typeIndex].attrs[attributeIndex].range != "undefined" && dataArray[typeIndex].attrs[attributeIndex].range.indexOf("-") != -1) {
							dataArray[typeIndex].attrs[attributeIndex].formElement = "TrackBar";
						} else {
							dataArray[typeIndex].attrs[attributeIndex].formElement = "NumericUpDown";
						}
					break;

					case "string":
						dataArray[typeIndex].attrs[attributeIndex].formElement = "TextBox";
					break;

					case "url":
						dataArray[typeIndex].attrs[attributeIndex].formElement = "TextBox";
					break;

					case "boolean":
						dataArray[typeIndex].attrs[attributeIndex].formElement = "CheckBox";
					break;

					case "color":
						dataArray[typeIndex].attrs[attributeIndex].formElement = "TextBox";
					break;

					default:
						dataArray[typeIndex].attrs[attributeIndex].formElement = "TextBox";
					break;
				}
				dataArray[typeIndex].attrs[attributeIndex].formElementId = keyName + "_" + dataArray[typeIndex].attrs[attributeIndex].name;
				attributes[attributeIndex] = dataArray[typeIndex].attrs[attributeIndex];
			}

		}
		
		fs.readFile("data/"+fileNameObject[keyName], function(error, data) {
			attributes["data"] = {};
			if(!error) {
				attributes["data"]["JSON"] = JSON.stringify(data, null, 4);
			} else {
				attributes["data"]["JSON"] = "";
			}
			finalJSON[keyName] = attributes;
		});
	});
});

interval = setInterval(function() {
	readAndPrepareFileContent(fileNamesArray[indexOfPresentFile]);
	indexOfPresentFile += 1;
	if(indexOfPresentFile > numberOfAttributeFiles || typeof fileNamesArray[indexOfPresentFile] == "undefined") {
		fs.writeFile(finalFilePath, JSON.stringify(finalJSON, null, 4), function(error, data) {
			console.log("done");
			clearInterval(interval);
		});
	}
}, 300);