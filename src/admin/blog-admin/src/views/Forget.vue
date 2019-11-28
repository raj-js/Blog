<template>
	<a-card>
		<a-row>
			<a-col>
				<a-steps :current="current" class="steps-title">
					<a-step title="填写邮箱">
						<template v-slot:icon>
							<a-icon type="mail"></a-icon>
						</template>
					</a-step>
					<a-step title="填写验证码">
						<template v-slot:icon>
							<a-icon type="number"></a-icon>
						</template>
					</a-step>
					<a-step title="设置密码">
						<template v-slot:icon>
							<a-icon type="key"></a-icon>
						</template>
					</a-step>
				</a-steps>

				<div class="steps-content">
					<a-form v-show="step_verify_email">
						<a-form-item>
							<a-row :gutter="8">
								<a-col :span="20" :offset="1">
									<a-input placeholder="请输入注册邮箱...">
										<template v-slot:prefix>
											<a-icon
												type="mail"
												style="color: rgba(0,0,0,.25)"
											/>
										</template>
									</a-input>
								</a-col>
								<a-col :span="2">
									<a-button type="primary" @click="next_step"
										>发送</a-button
									>
								</a-col>
							</a-row>
						</a-form-item>
					</a-form>

					<a-form v-show="step_verify_code">
						<a-form-item>
							<a-row :gutter="8">
								<a-col :span="2" :offset="1">
									<a-button
										type="default"
										@click="previous_step"
									>
										<a-icon type="arrow-left"></a-icon>
									</a-button>
								</a-col>
								<a-col :span="18">
									<a-input placeholder="请输入验证码...">
										<template v-slot:prefix>
											<a-icon type="number"></a-icon>
										</template>
									</a-input>
								</a-col>
								<a-col :span="2">
									<a-button type="primary" @click="next_step"
										>校验</a-button
									>
								</a-col>
							</a-row>
						</a-form-item>
					</a-form>

					<a-form
						v-show="step_set_password"
						v-bind="{ wrapperCol: { span: 20, offset: 2 } }"
					>
						<a-form-item>
							<a-input placeholder="请输入新密码...">
								<template v-slot:prefix>
									<a-icon type="key"></a-icon>
								</template>
							</a-input>
						</a-form-item>
						<a-form-item>
							<a-input placeholder="请再次输入密码...">
								<template v-slot:prefix>
									<a-icon type="key"></a-icon>
								</template>
							</a-input>
						</a-form-item>
						<a-form-item>
							<a-button
								type="primary"
								htmlType="submit"
								class="step_set_password_button"
							>
								提交
							</a-button>
						</a-form-item>
					</a-form>
				</div>
			</a-col>
		</a-row>
	</a-card>
</template>

<script>
export default {
	data() {
		return {
			current: 0
		};
	},
	computed: {
		step_verify_email() {
			return this.current === 0;
		},
		step_verify_code() {
			return this.current === 1;
		},
		step_set_password() {
			return this.current === 2;
		}
	},
	methods: {
		next_step() {
			this.current = ++this.current > 2 ? 0 : this.current;
		},
		previous_step() {
			this.current = --this.current < 0 ? 0 : this.current;
		}
	}
};
</script>

<style scoped>
.steps-title {
	margin-top: 10px;
}
.steps-content {
	margin-top: 25px;
}
.step_set_password_button {
	width: 100%;
}
</style>
