// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {

    const revealElements = document.querySelectorAll(
        ".reveal-left, .reveal-right, .reveal-up"
    );

    const observer = new IntersectionObserver((entries) => {

        entries.forEach((entry) => {

            if (entry.isIntersecting) {
                entry.target.classList.add("active");
                observer.unobserve(entry.target);
            }

        });

    }, {
        threshold: 0.15
    });

    revealElements.forEach((element) => {
        observer.observe(element);
    });

});
