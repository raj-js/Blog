<template>
	<a-layout-header id="app-header" fixed>
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
					<a-menu-item key="1" @click="openProfileModal">
						<a-icon type="user" /> 个人信息
					</a-menu-item>
					<a-menu-item key="2" @click="openPasswordModal">
						<a-icon type="key" /> 修改密码
					</a-menu-item>
					<a-menu-item key="3" @click="logout">
						<a-icon type="logout" /> 注销
					</a-menu-item>
				</a-menu>
			</template>
		</a-dropdown>
		<ProfileModal ref="profile"></ProfileModal>
		<ResetPasswordModal ref="resetPassword"></ResetPasswordModal>
	</a-layout-header>
</template>

<script>
import { mapState, mapMutations } from "vuex";
import ProfileModal from "@/components/ProfileModal";
import ResetPasswordModal from "@/components/ResetPasswordModal";

export default {
	data() {
		return {
			profileModal: false,
			passwordModal: false
		};
	},
	components: {
		ProfileModal,
		ResetPasswordModal
	},
	computed: {
		...mapState("layout", ["collapsed"])
	},
	methods: {
		...mapMutations("layout", ["toggleCollapsed"]),
		openProfileModal() {
			this.$refs.profile.open();
		},
		openPasswordModal() {
			this.$refs.resetPassword.open();
		},
		logout() {
			const _this = this;

			this.$confirm({
				title: "注销",
				content: "确定注销当前账号吗？",
				okText: "确定",
				okType: "primary",
				cancelText: "取消",
				onOk() {
					_this.$router.push("/auth");
				},
				onCancel() {
					console.log("logout cancel");
				}
			});
		}
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
