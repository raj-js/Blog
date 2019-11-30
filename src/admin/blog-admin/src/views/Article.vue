<template>
	<a-card>
		<template v-slot:title>
			<h2>{{ mode === "ADD" ? "新增" : "编辑" }}文章</h2>
		</template>

		<a-form layout="horizontal" v-bind="formItemLayout">
			<a-form-item label="标题">
				<a-input v-model="article.title"></a-input>
			</a-form-item>
			<a-form-item label="摘要">
				<a-textarea :autosize="{ minRows: 2, maxRows: 6 }"></a-textarea>
			</a-form-item>
			<a-form-item label="编辑器">
				<a-radio-group name="status" v-model="article.editorType">
					<a-radio-button :value="'MARKDOWN'">
						Markdown
					</a-radio-button>
					<a-radio-button :value="'RICHTEXT'">
						富文本
					</a-radio-button>
				</a-radio-group>
			</a-form-item>
			<a-form-item label="内容">
				<EditorWrapper :mode="article.editorType"></EditorWrapper>
			</a-form-item>
			<a-form-item label="分类">
				<a-select>
					<a-select-option
						v-for="item in categories"
						:key="item.id"
						v-text="item.name"
						:value="item.id"
					></a-select-option>
				</a-select>
			</a-form-item>
			<a-form-item label="标签">
				<a-select mode="multiple" v-model="categories.tags">
					<a-select-option
						v-for="item in tags"
						:key="item.id"
						:value="item.id"
						v-text="item.name"
					></a-select-option>
				</a-select>
			</a-form-item>
			<a-form-item label="访问量">
				<a-input-number :min="0" :defaultValue="0" />
			</a-form-item>
			<a-form-item label="点赞量">
				<a-input-number :min="0" :defaultValue="0" />
			</a-form-item>
			<a-form-item label="状态">
				<a-radio-group name="status" :defaultValue="0">
					<a-radio :value="0">
						草稿
					</a-radio>
					<a-radio :value="1">
						发布
					</a-radio>
					<a-radio v-if="isUpdate" :value="2">
						删除
					</a-radio>
				</a-radio-group>
			</a-form-item>
			<a-form-item label="置顶">
				<a-switch> </a-switch>
			</a-form-item>
			<a-form-item v-if="isUpdate" label="发布时间">
				<a-date-picker
					:locale="locale.date_picker"
					show-time
					format="YYYY-MM-DD HH:mm:ss"
				/>
			</a-form-item>
			<a-form-item :wrapperCol="{ span: 16, offset: 4 }">
				<a-button type="primary" htmlType="submit">
					保存
				</a-button>
			</a-form-item>
		</a-form>
	</a-card>
</template>

<script>
import caregoryService from "../services/CategoryService";
import tagService from "../services/TagService";
import articleService from "../services/ArticleService";
import { reject } from "../shared/AxiosHelper";
import EditorWrapper from "@/components/EditorWrapper";
import LocaleDateTime from "@/shared/LocalDateTime";

const ADD = "ADD";
const UPDATE = "UPDATE";

export default {
	components: {
		EditorWrapper
	},
	data() {
		return {
			locale: {
				date_picker: LocaleDateTime
			},
			formItemLayout: {
				labelCol: { span: 4 },
				wrapperCol: { span: 18 }
			},
			article: {
				editorType: "MARKDOWN"
			},
			categories: [],
			tags: [],
			id: this.$route.params.id,
			form: this.$form.createForm(this, { name: "article" })
		};
	},
	computed: {
		mode() {
			return this.article.id ? UPDATE : ADD;
		},
		isAdd() {
			return this.mode === ADD;
		},
		isUpdate() {
			return this.mode === UPDATE;
		}
	},
	created() {
		this.initialize();
		this.load();
	},
	methods: {
		initialize() {
			const _this = this;

			caregoryService
				.getAllEnabled()
				.then(resp => {
					_this.categories = resp.data;
				})
				.catch(console.error);

			tagService
				.getAllEnabled()
				.then(resp => {
					_this.tags = resp.data;
				})
				.catch(console.error);
		},
		load() {
			const _this = this;

			if (_this.id) {
				articleService
					.get(_this.id)
					.then(resp => {
						_this.article = resp.data;
					})
					.catch(error => reject(_this, error));
			}
		},
		save() {
			const _this = this;
			const _form = this.form;

			_form.validateFields((error, values) => {
				if (error) {
					return;
				}

				articleService
					.addOrUpdate(_this.article)
					.then(resp => {
						_this.article = resp.data;
						_this.id = _this.article.id;
						_this.load();
					})
					.catch(error => reject(_this, error));
			});
		}
	}
};
</script>
