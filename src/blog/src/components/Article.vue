<template>
    <v-container fluid>
        article
    </v-container>
</template>

<script>
    export default {
        data() {
            return {
                id: null
            }
        },
        mounted(){
            this.id = this.$route.params.id

            console.log(this.id)
        }
    }
</script>