<template>
    <a-affix :offsetTop="this.top">
        <a-list
                size="small"
                bordered
                :dataSource="data"
        >
            <a-list-item slot="renderItem" slot-scope="item">
                <a href="#">{{item}}</a>
            </a-list-item>
        </a-list>
    </a-affix>
</template>

<script>
    const data = [
        '最新发布',
        '.Net Core',
        'Python',
        'Node.js',
        'Vue.js',
    ]

    export default {
        name: "SideMenu",
        data: () => {
            return {
                top: 30,
                data
            }
        }
    }
</script>

<style scoped>

</style>