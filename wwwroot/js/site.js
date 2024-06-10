// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var swiper = new Swiper(".slide-content",
    {
        slidesPerView: 4,
        spaceBetween: 30, 
        loop: true,
        centerSlide: 'true',
        fade:'true',
        grabCursor:'true',
        pagination: {
            el: ".swiper-pagination",
            clickable: true,
            dynamicBullets:true,
        },
        navigation: {
            nextEl: ".swiper-button-next",
            prevEl: ".swiper-button-prev",
        },
    }); 

     
document.getElementById("gonderButton").addEventListener("click", function() {
    var adsoyad = document.getElementById("adsoyad").value;
    var email = document.getElementById("email").value;
    var mesaj = document.getElementById("mesaj").value;

    var subject = "Geri Bildirim"; // E-posta konusu

    // E-posta içeriği oluştur
    var body = "Merhaba,\n\nAd Soyad: " + adsoyad + "\nE-posta: " + email + "\n\nKonu: " + mesaj + "\n";

    // E-posta bağlantısını oluştur
    var mailtoLink = "mailto:destek@example.com?subject=" + encodeURIComponent(subject) + "&body=" + encodeURIComponent(body);

    // E-posta bağlantısını aç
    window.location.href = mailtoLink;
});