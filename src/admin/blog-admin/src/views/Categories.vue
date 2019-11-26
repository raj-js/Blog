<template>
	<a-card>
		<template v-slot:title>
			<h2>分类管理</h2>
		</template>

		<a-row :gutter="8">
			<a-col :span="12">
				<a-card>
					<a-list>
						<a-list-item
							v-for="item in categories"
							:key="item.id"
							@click="editCategory(item)"
						>
							<a-list-item-meta :description="item.description">
								<template v-slot:avatar>
									<a-avatar :src="item.covor" />
								</template>
								<template v-slot:title>
									{{ item.name }}
								</template>
							</a-list-item-meta>

							<template v-slot:actions>
								<a-tag color="green" v-if="item.enable"
									>启用</a-tag
								>
								<a-tag color="red" v-else>禁用</a-tag>
							</template>
						</a-list-item>
					</a-list>
				</a-card>
			</a-col>
			<a-col :span="12">
				<a-card>
					<a-form v-bind="formLayout">
						<a-form-item label="编号">
							<span
								class="ant-form-text"
								v-text="category.id"
							></span>
						</a-form-item>
						<a-form-item label="名称">
							<a-input v-model="category.name"></a-input>
						</a-form-item>
						<a-form-item label="封面">
							<a-upload
								name="covor"
								listType="picture-card"
								class="avatar-uploader"
								:showUploadList="false"
								action="#"
							>
								<img
									height="102"
									width="102"
									v-if="category.covor"
									:src="category.covor"
									alt="封面"
								/>
								<div v-else>
									<a-icon
										:type="loading ? 'loading' : 'plus'"
									/>
									<div class="ant-upload-text">上传</div>
								</div>
							</a-upload>
						</a-form-item>
						<a-form-item label="描述">
							<a-textarea
								:value="category.description"
								:autosize="{ minRows: 2, maxRows: 3 }"
							></a-textarea>
						</a-form-item>
						<a-form-item label="启用">
							<a-switch
								defaultChecked
								:checked="category.enable"
							/>
						</a-form-item>
						<a-form-item :wrapperCol="{ span: 16, offset: 4 }">
							<a-row>
								<a-button type="primary" htmlType="submit">
									保存
								</a-button>
								&nbsp;
								<a-button type="default" htmlType="reset">
									新增
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
export default {
	data() {
		return {
			formLayout: {
				labelCol: { span: 4 },
				wrapperCol: { span: 16 }
			},
			loading: false,
			categories: [],
			category: {}
		};
	},
	created() {
		for (let i = 0; i < 5; i++) {
			this.categories.push({
				id: i,
				name: "Asp.Net Core",
				covor:
					"https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png",
				description:
					"Ant Design, a design language for background applications, is refined by Ant UED Team",
				enable: i % 2 === 0
			});
		}
	},
	methods: {
		editCategory(category) {
			this.category = { ...category };
		}
	}
};
</script>

<style scoped>
.ant-list-item:hover {
	cursor: pointer;
}
</style>
