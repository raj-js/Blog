<template>
	<a-layout-sider v-model="collapsed">
		<div class="logo" />
		<a-menu theme="dark" :defaultSelectedKeys="['1']" mode="inline">
			<a-menu-item key="1">
				<router-link to="/">
					<a-icon type="read" />
					<span>文章管理</span>
				</router-link>
			</a-menu-item>
			<a-menu-item key="2">
				<router-link to="/categories">
					<a-icon type="appstore" />
					<span>分类管理</span>
				</router-link>
			</a-menu-item>
			<a-menu-item key="3">
				<router-link to="/tags">
					<a-icon type="tag" />
					<span>标签管理</span>
				</router-link>
			</a-menu-item>
			<a-menu-item key="4">
				<router-link to="/containers">
					<a-icon type="file" />
					<span>内容库</span>
				</router-link>
			</a-menu-item>
		</a-menu>
	</a-layout-sider>
</template>

<script>
import { mapState } from "vuex";

export default {
	computed: mapState("layout", ["collapsed"])
};
</script>
