<template>
    <a-card class="category">
        <dl>
            <dt> 分类</dt>
            <dd v-bind:key="category" v-for="category in categories">
                {{ category }}
            </dd>
        </dl>
    </a-card>
</template>

<script>
const categories = [
    '.Net Core',
    'Docker',
    'Linux',
    'Node.js',
    'Python',
    'React'
]

export default {
    data () {
        return {
            categories
        }
    }
}

</script>

<style>
.category {
    
}
</style>