<template>
	<a-modal
		:visible="visible"
		title="个人信息"
		@ok="handleOk"
		@cancel="handleCancel"
		:confirmLoading="loading"
		okText="保存"
		cancelText="取消"
	>
		<Profile
			ref="profile"
			@validating-form-state="handleValidating"
		></Profile>
	</a-modal>
</template>

<script>
import Profile from "@/components/Profile";

export default {
	components: {
		Profile
	},
	data() {
		return {
			loading: false,
			visible: false
		};
	},
	methods: {
		open() {
			this.visible = true;
		},
		close() {
			this.visible = false;
		},
		handleOk() {
			this.$refs.profile.save();
		},
		handleCancel() {
			this.$refs.profile.cancel();
			this.close();
		},
		handleValidating(state) {
			if (state) {
				this.close();
			}
		}
	}
};
</script>
