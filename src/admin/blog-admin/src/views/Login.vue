<template>
	<a-card>
		<a-form :form="form" class="login-form" @submit="handleSubmit">
			<a-form-item>
				<a-input
					v-decorator="[
						'userName',
						{
							rules: [
								{
									required: true,
									message: '请输入账号！'
								}
							]
						}
					]"
					placeholder="请输入账号..."
				>
					<a-icon
						slot="prefix"
						type="user"
						style="color: rgba(0,0,0,.25)"
					/>
				</a-input>
			</a-form-item>
			<a-form-item>
				<a-input
					v-decorator="[
						'password',
						{
							rules: [
								{
									required: true,
									message: '请输入密码！'
								}
							]
						}
					]"
					type="password"
					placeholder="请输入密码..."
				>
					<a-icon
						slot="prefix"
						type="lock"
						style="color: rgba(0,0,0,.25)"
					/>
				</a-input>
			</a-form-item>
			<a-form-item>
				<a-checkbox
					v-decorator="[
						'remember',
						{
							valuePropName: 'checked',
							initialValue: true
						}
					]"
				>
					记住账号
				</a-checkbox>
				<router-link class="login-form-forgot" to="/auth/forget"
					>忘记密码？</router-link
				>
				<a-button
					type="primary"
					html-type="submit"
					class="login-form-button"
				>
					登 录
				</a-button>
			</a-form-item>
		</a-form>
	</a-card>
</template>

<script>
export default {
	beforeCreate() {
		this.form = this.$form.createForm(this, { name: "login" });
	},
	methods: {
		handleSubmit(e) {
			e.preventDefault();
			this.form.validateFields((err, values) => {
				if (!err) {
					console.log("Received values of form: ", values);
				}
			});
		}
	}
};
</script>
<style scoped>
.login-form-forgot {
	float: right;
}
.login-form-button {
	width: 100%;
}
</style>
