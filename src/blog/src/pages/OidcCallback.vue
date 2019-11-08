<template>
    <div>跳转中...</div>
</template>

<script>
    import { mapActions } from 'vuex'

    export default {
        methods: {
            ...mapActions('oidcStore', [
                'oidcSignInCallback'
            ])
        },
        created() {
            this.oidcSignInCallback()
                .then(redirectUri => {
                    this.$router.push(redirectUri)
                })
                .catch(error => {
                    console.error(error)

                    this.$router.push('/signin-oidc-error')
                })
        }
    }
</script>