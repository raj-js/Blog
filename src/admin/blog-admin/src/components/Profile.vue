<template>
	<a-form v-bind="formLayout" :form="form">
		<a-form-item label="昵称">
			<a-input
				v-decorator="[
					'nickName',
					{ rules: [{ required: true, message: '昵称必填！' }] }
				]"
			></a-input>
		</a-form-item>
		<a-form-item label="头像">
			<a-upload
				name="covor"
				listType="picture-card"
				:showUploadList="false"
				action="#"
			>
				<!-- <img
					height="64"
					width="64"
					v-if="category.covor"
					:src="category.covor"
					alt="封面"
				/> -->
				<div>
					<a-icon :type="loading ? 'loading' : 'plus'" />
					<div class="ant-upload-text">上传</div>
				</div>
			</a-upload>
		</a-form-item>
		<a-form-item label="签名">
			<a-textarea></a-textarea>
		</a-form-item>
	</a-form>
</template>

<script>
const VALIDATE_FORM_STATE = "validating-form-state";

export default {
	data() {
		return {
			formLayout: {
				labelCol: {
					span: 4
				},
				wrapperCol: {
					span: 18
				}
			},
			loading: false
		};
	},
	beforeCreate() {
		this.form = this.$form.createForm(this, { name: "profile" });
	},
	methods: {
		save() {
			const _form = this.form;

			_form.validateFields((error, values) => {
				if (error) {
					this.$emit(VALIDATE_FORM_STATE, false);
					return;
				}

				_form.resetFields();

				this.$emit(VALIDATE_FORM_STATE, true);
			});
		},
		cancel() {
			this.form.resetFields();
		}
	}
};
</script>

<style></style>
