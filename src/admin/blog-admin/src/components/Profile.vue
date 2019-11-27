<template>
	<a-modal
		:visible="visible"
		title="个人信息"
		@ok="handleOk"
		@cancel="handleCancel"
		:confirmLoading="loading"
	>
		<p>content</p>
	</a-modal>
</template>

<script>
export default {
	props: {
		visible: {
			type: Boolean,
			default: false
		}
	},
	data() {
		return {
			loading: false
		};
	},
	methods: {
		close() {
			this.$emit("close");
		},
		handleOk() {
			this.close();
		},
		handleCancel() {
			this.close();
		}
	}
};
</script>
