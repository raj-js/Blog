<template>
	<a-layout-header id="app-header">
		<a-button type="primary" @click="toggleCollapsed" class="aside-toggle">
			<a-icon :type="collapsed ? 'menu-unfold' : 'menu-fold'"></a-icon>
		</a-button>
		<a-dropdown class="header-menu" placement="bottomCenter">
			<a class="ant-dropdown-link" href="#">
				<a-avatar
					src="https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png"
				/>
				<span>raj</span>
			</a>
			<template v-slot:overlay>
				<a-menu>
					<a-menu-item key="1">
						<a-icon type="user" /> 个人信息
					</a-menu-item>
					<a-menu-item key="2">
						<a-icon type="key" /> 修改密码
					</a-menu-item>
					<a-menu-item key="3">
						<a-icon type="logout" /> 注销
					</a-menu-item>
				</a-menu>
			</template>
		</a-dropdown>
	</a-layout-header>
</template>

<script>
import { mapState, mapMutations } from "vuex";

export default {
	computed: {
		...mapState("layout", ['collapsed'])
	},
	methods: {
		...mapMutations('layout', [
			'toggleCollapsed'
		])
	}
};
</script>

<style scoped>
#app-header {
	background: #fff;
	padding: 0;
}

#app-header .header-menu {
	float: right;
	margin-right: calc(2.5%);
}

#app-header .aside-toggle {
	margin-left: calc(1%);
}
</style>
