$('.nav__sf a').click(function() {
    if ( !$(this).parent().hasClass('dropdown')) {
       $('.navbar-collapse').collapse('hide'); 
    }
 });


// const bgNav =  document.querySelector("nav")

// window.addEventListener("scroll", function(){
//   if (pageYOffset >= 200) {
//     bgNav.classList.remove("bg-transparent")
//     bgNav.classList.add("nav__sf-bg")
//   }
//   if (pageYOffset < 200){
//     bgNav.classList.add("bg-transparent")
//     bgNav.classList.remove("nav__sf-bg")
//   } 
// })
