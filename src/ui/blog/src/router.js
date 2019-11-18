import Vue from 'vue'
import VueRouter from 'vue-router'
import goTo from 'vuetify/es5/services/goto'

Vue.use(VueRouter)

const Layout = () => import ('@/pages/Layout')
const Articles = () => import ('@/pages/Articles')
const Categories = () => import ('@/pages/Categories')

const Auth = () => import ('@/pages/Auth')
const SignIn = () => import ('@/components/auth/SignIn')
const SignUp = () => import ('@/components/auth/SignUp')

export default new VueRouter({
    scrollBehavior: (to, from, savedPosition) => {
        let scrollTo = 0
    
        if (to.hash) {
          scrollTo = to.hash
        } else if (savedPosition) {
          scrollTo = savedPosition.y
        }
    
        return goTo(scrollTo)
      },
    routes: [
        {
            path: '/',
            component: Layout,
            children: [
                {
                    path: 'articles',
                    component: Articles
                },
                {
                    path: 'categories',
                    component: Categories
                }
            ]
        },
        {
            path: '/auth',
            component: Auth,
            children: [
                {
                    path: 'sign-in',
                    component: SignIn
                },
                {
                    path: 'sign-up',
                    component: SignUp
                }
            ]
        }
    ]
})