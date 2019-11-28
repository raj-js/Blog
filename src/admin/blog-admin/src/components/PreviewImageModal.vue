<template>
	<a-modal :visible="visible" :footer="null" @cancel="handleClose">
		<img style="width: 100%" :src="src" />
	</a-modal>
</template>

<script>
export default {
	props: {
		src: {
			type: String,
			required: true
		}
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
		handleClose() {
			this.visible = false;
		}
	}
};
</script>

<style></style>
