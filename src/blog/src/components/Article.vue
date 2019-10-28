<template>
    <v-container fluid>
        {{JSON.stringify(article)}}
    </v-container>
</template>

<script>
import articleService from '@/services/articleService'

    export default {
        data() {
            return {
                id: null,
                article: null
            }
        },
        mounted(){
            this.id = this.$route.params.id

            articleService
                .details(this.id)
                .then(article => {
                    console.log(article)
                    this.article = article
                })
                .catch(error => {
                    console.error(error)
                })
        }
    }
</script>