<template>
	<a-modal
		:visible="visible"
		title="修改密码"
		@ok="handleOk"
		@cancel="handleCancel"
		okText="保存"
		cancelText="取消"
	>
		<ResetPassword
			ref="resetPassword"
			@validating-form-state="handleValidating"
		></ResetPassword>
	</a-modal>
</template>

<script>
import ResetPassword from "@/components/ResetPassword";

export default {
	components: {
		ResetPassword
	},
	data() {
		return {
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
			this.$refs.resetPassword.save();
		},
		handleCancel() {
			this.$refs.resetPassword.cancel();
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

<style></style>
