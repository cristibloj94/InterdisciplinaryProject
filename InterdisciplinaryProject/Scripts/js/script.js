$(".basket").hide();

var clicks = 0;
var arrayOfLineItems = [];
var quantity = 1;
var totalPrice = 0;

//function getSpecificLineItem(id)
//{
//    console.log(id);
//    return $.ajax({
//        url: 'lineitems/Details',
//        type: 'GET',
//        datatype: 'json',
//        data: { id: id },
//        success: function (data) {
//            console.log(data[0]);
//        },
//        error: function () {
//            alert("Something went wrong");
//        }
//    });
//    console.log(data);
//}
function HandleResponseJSON(data) {
    var result = data;
    addToBasket(result);
}

function calculateTotalPrice(newPrice) {
    totalPrice += newPrice;
    $(".total-price").text("Total: " + totalPrice.toFixed(2));
}

function addToBasket(item) {
    if ($.inArray(item.Id, arrayOfLineItems) == -1) {
        quantity = 1;
        arrayOfLineItems.push(item.Id);
        $(".basket-content").append("<tr class=row" + item.Id + ">");
        $(".basket-content").append("<td class=quantity" + item.Id + ">" + quantity + "</td>");
        $(".basket-content").append("<td>" + item.Name + "</td>");
        $(".basket-content").append('<td>' + item.Price + '</td>');
        $(".basket-content").append("</tr>");
        setTimeout(function () {
            $('.basket').show(300);
        }, 100);
    } else {
        quantity++;
        $(".quantity" + item.Id).text(quantity);
    }
    calculateTotalPrice(item.Price);
}


$(document).ready(function () {

});
