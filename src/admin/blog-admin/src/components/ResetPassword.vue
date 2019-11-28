<template>
	<a-form v-bind="formLayout" :form="form">
		<a-form-item label="旧密码">
			<a-input
				type="password"
				v-decorator="['oldPassword', { rules: rules }]"
			></a-input>
		</a-form-item>
		<a-form-item label="新密码">
			<a-input
				type="password"
				v-decorator="['newPassword', { rules: rules }]"
			></a-input>
		</a-form-item>
		<a-form-item label="确认密码">
			<a-input
				type="password"
				v-decorator="['confirmPassword', { rules: rules }]"
			></a-input>
		</a-form-item>
	</a-form>
</template>

<script>
const VALIDATING_FORM_STATE = "validating-form-state";

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
			}
		};
	},
	computed: {
		rules() {
			return [
				{ required: true, message: "此项必填" },
				{
					pattern: /^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z]{6,20}$/,
					message: "密码必须包含字母与数字，且长度为6-20位"
				}
			];
		}
	},
	beforeCreate() {
		this.form = this.$form.createForm(this, { name: "reset-password" });
	},
	methods: {
		save() {
			const _form = this.form;

			_form.validateFields((error, values) => {
				if (error) {
					this.$emit(VALIDATING_FORM_STATE, false);
					return;
				}

				_form.resetFields();
			});
		},
		cancel() {
			this.form.resetFields();
		}
	}
};
</script>

<style></style>
