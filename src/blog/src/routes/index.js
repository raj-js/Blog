import React from 'react'
import { Redirect } from 'react-router-dom'

import Home from '../core/home/Home'
import Posts from '../core/posts/Posts'

export default [
    {
        path: "/",
        component: Home,
        routes: [
            {
                path: '/',
                exact: true,
                render: () => (
                    <Redirect to={"/posts"} />
                )    
            },
            {
                path: '/posts',
                component: Posts
            }
        ]
    }
]