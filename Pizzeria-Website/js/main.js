//Skrypt jQuery odpowiadający za wysuwane menu
$(document).ready(function () {
    //Pojawianie si� submenu przy najechaniu myszk�
   $('[data-trigger="dropdown"]').on("mouseenter", function(){
    var submenu = $(this).parent().find(".submenu");
       submenu.addClass("active");

    //Znikanie submenu
    $('.navigation ul ').on('mouseleave', function(){
      submenu.removeClass('active');
    });
  });

});
//Odsłanianie opinii co określoną ilość czasu
function unhideOpinions(){
  var childDivs = document.getElementById('opinions-list').getElementsByTagName('article');
  var i = 0;

  var opinionsInterval = setInterval(function()
    {
      if (i == (childDivs.length - 1)) {
        clearInterval(opinionsInterval);
      }
      childDivs[i].classList.add("unhide");
      childDivs[i].style.opacity = 1;
      i++;

    }, 3000);

}
