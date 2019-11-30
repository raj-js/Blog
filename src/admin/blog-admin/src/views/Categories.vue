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
							@click="select(item)"
						>
							<a-list-item-meta :description="item.description">
								<template v-slot:avatar>
									<a-avatar
										shape="square"
										:src="item.cover"
									/>
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
					<a-form v-bind="formLayout" :form="form">
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
								:showUploadList="false"
								name="cover"
								listType="picture-card"
								class="avatar-uploader"
								action="https://www.mocky.io/v2/5cc8019d300000980a055e76"
								accept=".jpg,.jpeg,.png"
								@change="handleChange"
							>
								<img
									height="102"
									width="102"
									v-if="category.cover"
									:src="category.cover"
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
								v-model="category.description"
								:autosize="{ minRows: 2, maxRows: 3 }"
							></a-textarea>
						</a-form-item>
						<a-form-item label="启用">
							<a-switch
								defaultChecked
								v-model="category.enable"
							/>
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
import { getBase64 } from "../shared/UploadUtil";
import categoryService from "../services/CategoryService";
import { reject } from "../shared/AxiosHelper";

export default {
	data() {
		return {
			formLayout: {
				labelCol: { span: 4 },
				wrapperCol: { span: 16 }
			},
			accept: ["image/jpg", "image/jpeg", "image/png"],
			loading: false,
			categories: [],
			category: {}
		};
	},
	beforeCreate() {
		this.form = this.$form.createForm(this, { name: "category" });
	},
	mounted() {
		this.load();
	},
	methods: {
		load() {
			const _this = this;

			categoryService
				.all()
				.then(resp => {
					_this.categories = resp.data;
				})
				.catch(error => reject(_this, error));
		},
		select(category) {
			this.category = { ...category };
		},
		save() {
			const _this = this;
			const _form = this.form;
			_form.validateFields((error, values) => {
				if (error) {
					return;
				}
				categoryService
					.addOrUpdate(_this.category)
					.then(resp => {
						_this.category = resp.data;
						this.load();
						_this.$message.success("操作成功！");
					})
					.catch(error => reject(_this, error));

				_form.resetFields();
			});
		},
		reset() {
			this.category = {};
		},
		handleChange(info) {
			if (info.file.status === "uploading") {
				this.loading = true;
			} else if (info.file.status === "done") {
				// Get this url from response in real world.
				getBase64(info.file.originFileObj, cover => {
					this.category = {
						...this.category,
						cover
					};
					this.loading = false;
				});
			}
		}
	}
};
</script>

<style scoped>
.ant-list-item:hover {
	cursor: pointer;
}
</style>
