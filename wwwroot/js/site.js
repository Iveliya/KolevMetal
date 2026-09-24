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
// ==========================================
// KOLEV METAL - NUMBER COUNTERS
// ==========================================

const counters = document.querySelectorAll(".counter");

const counterObserver = new IntersectionObserver((entries, observer) => {

    entries.forEach(entry => {

        if (!entry.isIntersecting) {
            return;
        }

        const counter = entry.target;
        const target = Number(counter.dataset.target);

        let current = 0;

        const duration = 1200;
        const steps = 40;
        const increment = target / steps;

        const timer = setInterval(() => {

            current += increment;

            if (current >= target) {
                counter.textContent = target;
                clearInterval(timer);
            }
            else {
                counter.textContent = Math.floor(current);
            }

        }, duration / steps);

        observer.unobserve(counter);

    });

}, {
    threshold: 0.5
});

counters.forEach(counter => {
    counterObserver.observe(counter);
});