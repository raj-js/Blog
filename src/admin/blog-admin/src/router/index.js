import Vue from "vue";
import VueRouter from "vue-router";

import Layout from "../layout";

Vue.use(VueRouter);

const routes = [
	{
		path: "/layout",
		component: Layout,
		children: [
			{
				path: "",
				name: "articles",
				meta: {
					title: "文章管理"
				},
				component: () => import("@/views/Articles")
			},
			{
				path: "article/:id?",
				name: "article",
				meta: {
					title: "文章详情"
				},
				component: () => import("@/views/Article")
			},
			{
				path: "categories",
				name: "categories",
				meta: {
					title: "分类管理"
				},
				component: () => import("@/views/Categories")
			},
			{
				path: "tags",
				name: "tags",
				meta: {
					title: "标签管理"
				},
				component: () => import("@/views/Tags")
			},
			{
				path: "containers",
				name: "container",
				meta: {
					title: "内容库"
				},
				component: () => import("@/views/Containers")
			},
			{
				path: "*",
				name: "others",
				component: () => import("@/views/Articles")
			}
		]
	},
	{
		path: "/auth",
		component: () => import("@/layout/Auth"),
		children: [
			{
				path: "/login",
				name: "login",
				component: () => import("@/views/Login")
			}
		]
	},
	{
		path: "/editor",
		component: () => import("@/components/Markdown")
	}
];

const router = new VueRouter({
	mode: "history",
	base: process.env.BASE_URL,
	routes
});

export default router;
