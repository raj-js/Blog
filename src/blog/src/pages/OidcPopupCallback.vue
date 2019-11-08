<template>
    <div>已注销</div>
</template>

<script>
    import { mapActions } from 'vuex'

    export default {
        methods: {
            ...mapActions('oidcStore', [
                'oidcSignInPopupCallback'
            ])
        },
        created() {
            this.oidcSignInPopupCallback()
                .then(any => {
                    console.log(any)
                    
                    this.$router.push('/')
                })
                .catch(console.error)
        }
    } 
</script>
