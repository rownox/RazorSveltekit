import Counter from "/svelteapp/public/build/bundle.js";

document.addEventListener("DOMContentLoaded", function() {
    const target = document.getElementById("svelte-component-counter");
    new Counter.default({
        target
    });
});
