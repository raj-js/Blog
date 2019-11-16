import Vue from 'vue'
import VueRouter from 'vue-router'
import { vuexOidcCreateRouterMiddleware } from 'vuex-oidc'
import store from '@/stores/index'

const Articles = () => import ('@/components/Articles')
const Categories = () => import ('@/components/Categories')
const Tags = () => import ('@/components/Tags')
const Timeline = () => import ('@/components/Timeline')
const Article = () => import ('@/components/Article')
const OidcCallback = () => import ('@/pages/OidcCallback')
const OidcPopupCallback = () => import ('@/pages/OidcPopupCallback')
const OidcCallbackError = () => import ('@/pages/OidcCallbackError')
const demo = () => import ('@/components/ArticleListItem')

Vue.use(VueRouter)

const router = new VueRouter({
    mode: 'history',
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
            path: '/oidc-callback',
            name: 'oidcCallback',
            component: OidcCallback
        },
        {
            path: '/oidc-popup-callback',
            name: 'oidcPopupCallback',
            component: OidcPopupCallback
        },
        {
            path: '/oidc-callback-error',
            name: 'oidcCallbackError',
            component: OidcCallbackError
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
            path: '/demo',
            name: 'demo',
            component: demo
        },
        {
            path: '*',
            redirect: '/'
        }
    ]
})

router.beforeEach(vuexOidcCreateRouterMiddleware(store, 'oidcStore'))

export default router