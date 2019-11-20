import Vue from 'vue'
import VueRouter from 'vue-router'
import goTo from 'vuetify/es5/services/goto'

Vue.use(VueRouter)

const Layout = () => import ('@/pages/Layout')
const Articles = () => import ('@/pages/Articles')
const Article = () => import ('@/pages/Article')

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
                    path: '/',
                    redirect: 'articles'
                },
                {
                    path: 'articles',
                    component: Articles
                },
                {
                    path: 'article/:id',
                    component: Article
                }
            ]
        }
    ]
})