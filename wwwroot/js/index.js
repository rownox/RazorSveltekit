document.addEventListener('DOMContentLoaded', function () {
    const target = document.getElementById('svelte-component-counter');
    new Counter({
        target,
        props: {
            // props here if needed
        }
    });
});
