$(".basket").hide();

var clicks = 0;

function addToBasket() {
    setTimeout(function () {
        $('.basket').show(300);
    }, 100);

    if ($(".add").click === true) {
        clicks++;
    }
    console.log(clicks.toString());
}


$(document).ready(function () {
    $(".add").click(function () {
        clicks++;
        $(".basket-content").append("<tr>");
        $(".basket-content").append("<td>" + clicks.toString() + "</td>");
        $(".basket-content").append("<td>Product nr. 3</td>");
        $(".basket-content").append('<td class="cristi">145.00 kr.</td>');
        $(".basket-content").append("</tr>");
    });
});
