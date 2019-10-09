<template>
    <div>
        <Header />
        <div class="main">
            <slot></slot>
        </div>
        <Footer />
    </div>
</template>

<script>
import Header from './Header.vue'
import Footer from './Footer.vue'

export default {
    name: 'Layout',
    components: {
        Header,
        Footer
    }
}
</script>

<style>
.main {
    margin: 0px;
    padding: 15px;
}
</style>