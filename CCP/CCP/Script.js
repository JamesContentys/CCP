$(document).ready(function () {
    FindCust();
});

function FindCust() {
    $.post("/GetData.ashx", {}, function (data) {
        if (data.indexOf("FindError") === 0) {
            alert("no data returned");
        }
        else if (data.indexOf("NoRecFound") == 0) {
            if (CustID > 0) {
                document.getElementById('FormMessage').innerHTML = "No active Customer Record found";
                Exit();
            }
        }
        else if (data.indexOf("RecFound") == 0) {
            var intCount = 0;
            intRecNo = data.split("^^")[1];

            if (intRecNo > 0) {
                var intPosition = (intCount * 20) + 1 + intCount;

                intCount = 0;
                strData = data;
                intCustomerID = parseInt(strData.split("^^")[6], 10);
                strCurrCode = strData.split("^^")[29];
                intAgentID = strData.split("^^")[28];
                saleOrReturn = parseInt(strData.split("^^")[32], 10);
                strCurrSymbol = strData.split("^^")[34];

                if (strData.split("^^")[intPosition + 17] === "1") {
                    document.getElementById('note').innerHTML = "On Watch List";
                    $("#onWatchListLabel").show();
                }
                else {
                    $("#onWatchListLabel").hide();
                }

                $("#Username").html(strData.split("^^")[intPosition + 1]);
                $("#Password").html(strData.split("^^")[intPosition + 2]);
                $("#LoginID").html(strData.split("^^")[intPosition + 3]);
                $("#CustType").html(strData.split("^^")[intPosition + 4]);
                $("#CustID").html(strData.split("^^")[intPosition + 5]);
                $("#CustomerName").html(strData.split("^^")[intPosition + 6]);
                $("#TradName").html(strData.split("^^")[intPosition + 7]);
                $("#BrandName").html(strData.split("^")[intPosition + 18]);
                $("#Email").html(strData.split("^^")[intPosition + 8]);
                $("#VAT").html(strData.split("^^")[intPosition + 9]);
                $("#Credit").html(strData.split("^^")[intPosition + 10]);
                $("#PaymentTerm").html(strData.split("^^")[intPosition + 11]);
                $("#SalesChannel").html(strData.split("^^")[intPosition + 15]);
                $("#SageAccount").html(strData.split("^^")[intPosition + 16]);
            }
        }
    });
}