var downloadApplicationsItemList = [
    {"SNO": 1, "NAME": "Sri Vaikhanasa Maha Mandali Vivaha Paricheya Vedika Matrimony Application Form (Telugu)", "FILE":  "<a class='cursorPointer' href='docs/vaikhanasa_marriage_application_telugu.pdf' download><img src='images\\mysite\\common\\pdf_download.jpg'/></a>"},
    {"SNO": 2, "NAME": "Sri Vaikhanasa Maha Mandali Vivaha Paricheya Vedika Matrimony Application Form (English)", "FILE":  "<a class='cursorPointer' href='docs/vaikhanasa_marriage_application_english.pdf' download><img src='images\\mysite\\common\\pdf_download.jpg'/></a>"}
];

var downloadOthersItemList = [
    {"SNO": 1, "NAME": "Vaikhanasa Pooja Vidhanam", "FILE":  "<a class='cursorPointer' href='docs/PoojaVidhanam/Kalyaano_pdf_1.pdf' download><img src='images\\mysite\\common\\pdf_download.jpg'/></a>"}
];

$(document).ready(function () {
	drawTable(downloadApplicationsItemList, "#downloadApplicationsTable");	     
    drawTable(downloadOthersItemList, "#downloadOthersTable");
});

function drawTable(data, tableId) {
    for (var i = 0; i < data.length; i++) {
        drawRow(data[i], tableId);
    }
}

function drawRow(rowData, tableId) {	
    var row = $("<tr />")
    $(tableId).append(row); //this will append tr element to table... keep its reference for a while since we will add cels into it
    row.append($("<td class='dataColumnStyle textCenter'>" + rowData.SNO + "</td>"));
    row.append($("<td class='dataColumnStyle'>" + rowData.NAME + "</td>"));
    row.append($("<td class='dataColumnStyle textCenter tdDownloadImageColumn'>" + rowData.FILE + "</td>"));
}