import Vue from 'vue'
import VueRouter from 'vue-router'

const Articles = () => import ('@/components/Articles')
const Categories = () => import ('@/components/Categories')
const Tags = () => import ('@/components/Tags')
const Timeline = () => import ('@/components/Timeline')
const Article = () => import ('@/components/Article')

Vue.use(VueRouter)

const router = new VueRouter({
    routes: [
        {
            path: '/', 
            name: 'Articles',
            component: Articles,
            props: route => ({
                category: route.query.category,
                tag: route.query.tag
            })
        },
        {
            path: '/article/:id',
            name: 'Article',
            component: Article
        },
        {
            path: '/categories',
            name: 'Categroies',
            component: Categories
        },
        {
            path: '/tags',
            name: 'Tags',
            component: Tags
        },
        {
            path: '/timeline',
            name: 'Timeline',
            component: Timeline
        },
        {
            path: '*',
            redirect: '/'
        }
    ]
})

export default router