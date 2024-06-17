import App from './App.svelte';
import Counter from './Counter.svelte';

function initializeSvelteComponents() {

    if (document.getElementById('svelte-component-counter')) {
        new Counter({
            target: document.getElementById('svelte-component-counter')
        });
    }

    if (document.getElementById('svelte-component-app')) {
        new App({
            target: document.getElementById('svelte-component-app'),
            props: {
                name: 'world'
            }
        });
    }
}

initializeSvelteComponents();
