<template>
	<a-card>
		<template>
			<h2>标签管理</h2>
		</template>

		<a-row :gutter="8">
			<a-col span="12">
				<a-list>
					<a-list-item
						v-for="item in tags"
						:key="item.id"
						@click="select(item)"
					>
						<a-list-item-meta>
							<template v-slot:avatar>
								<a-avatar
									shape="square"
									size="large"
									:style="{ 'background-color': item.color }"
								></a-avatar>
							</template>
							<template v-slot:title>
								{{ item.name }}
							</template>
						</a-list-item-meta>

						<template v-slot:actions>
							<a-tag color="green" v-if="item.enable">启用</a-tag>
							<a-tag color="red" v-else>禁用</a-tag>
						</template>
					</a-list-item>
				</a-list>
			</a-col>
			<a-col span="12">
				<a-card>
					<a-form
						v-bind="{
							labelCol: { span: 4 },
							wrapperCol: { span: 16 }
						}"
						:form="form"
					>
						<a-form-item label="编号">
							<span class="ant-form-text" v-text="tag.id"></span>
						</a-form-item>
						<a-form-item label="名称">
							<a-input v-model="tag.name"></a-input>
						</a-form-item>
						<a-form-item label="颜色">
							<a-input
								v-model="tag.color"
								type="color"
								style="width:100px;"
							></a-input>
						</a-form-item>
						<a-form-item label="启用">
							<a-switch defaultChecked v-model="tag.enable" />
						</a-form-item>
						<a-form-item :wrapperCol="{ span: 16, offset: 4 }">
							<a-row>
								<a-button type="primary" @click="save">
									保存
								</a-button>
								&nbsp;
								<a-button type="default" @click="reset">
									重置
								</a-button>
							</a-row>
						</a-form-item>
					</a-form>
				</a-card>
			</a-col>
		</a-row>
	</a-card>
</template>

<script>
import { simplifyReject } from "../services/Simplify";
import tagService from "../services/TagService";

export default {
	data() {
		return {
			tags: [],
			tag: {},
			form: this.$form.createForm(this, { name: "tag" })
		};
	},
	mounted() {
		this.load();
	},
	methods: {
		load() {
			const _this = this;

			tagService
				.getAllTags()
				.then(resp => {
					this.tags = resp.data;
				})
				.catch(_this.reject);
		},
		select(tag) {
			this.tag = { ...tag };
		},
		save() {
			console.log(this.tag);
			const _this = this;
			const _form = this.form;

			_form.validateFields((error, values) => {
				if (error) {
					return;
				}

				tagService
					.addOrUpdateTag(_this.tag)
					.then(resp => {
						_this.tag = resp.data;
						_this.load();
						_this.$message.success("操作成功");
					})
					.catch(_this.reject);

				_form.resetFields();
			});
		},
		reset() {
			this.tag = {};
		},
		reject(error) {
			const _this = this;
			simplifyReject(
				error,
				() => _this.$message.error(`请求失败，状态码：${error}`),
				() => _this.$message.error(`请求失败，错误信息：${error}`),
				() => _this.$message.error(`请求失败，未知错误：${error}`)
			);
		}
	}
};
</script>

<style scoped>
.ant-list-item {
	cursor: pointer;
}
</style>
