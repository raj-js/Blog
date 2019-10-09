<template>
    <a-card class="archive">
        <dl>
            <dt> 归档</dt>
            <dd v-bind:key="archive" v-for="archive in archives">
                {{ archive }}
            </dd>
        </dl>
    </a-card>
</template>

<script>
const archives = [
    '2019-09',
    '2019-08',
    '2019-07',
    '2019-06',
    '2019-05',
    '2019-04'
]

export default {
    data () {
        return {
            archives
        }
    }
}

</script>

<style>
.archive {
    
}
</style>