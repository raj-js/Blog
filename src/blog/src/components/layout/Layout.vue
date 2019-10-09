<template>
    <div>
        <Header />
        <el-row>
            <slot></slot>
        </el-row>
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