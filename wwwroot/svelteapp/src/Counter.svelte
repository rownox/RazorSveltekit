<script>
    import { onMount } from 'svelte';
    let showing = false;

    function toggleComponent() {
        showing = !showing;
    }

    function clickButton() {
        const pContent = document.querySelector('#svelte-component-counter p').textContent;
        const event = new CustomEvent('updateButtonText', { detail: pContent });
        document.dispatchEvent(event);
    }

    onMount(() => {
        window.updateButtonText = function(newText) {
            const event = new CustomEvent('updateButtonText', { detail: newText });
            document.dispatchEvent(event);
        };
    });
</script>

<main>
    <button on:click={toggleComponent}>Component</button>

    {#if showing}
        <div id="svelte-component-counter">
            <p>hi</p>
            <button on:click={clickButton}>Click</button>
        </div>
    {/if}
</main>

<style>
    #svelte-component-counter {
        display: flex;
        flex-direction: column;
        border: 1px solid red;
        padding: 20px;
    }
</style>
