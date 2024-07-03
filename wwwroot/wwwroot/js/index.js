// wwwroot/js/index.ts
import Counter from '/svelteapp/public/build/bundle.js'; // Adjust path relative to wwwroot/js
document.addEventListener('DOMContentLoaded', function () {
    const target = document.getElementById('svelte-component-counter');
    new Counter.default({
        target,
        props: {
        // props here if needed
        }
    });
});
//# sourceMappingURL=index.js.map