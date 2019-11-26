<template>
	<a-card>
		<template v-slot:title>
			<h2>{{ mode === "ADD" ? "新增" : "编辑" }}文章</h2>
		</template>

		<a-form layout="horizontal" v-bind="formItemLayout">
			<a-form-item label="标题">
				<a-input></a-input>
			</a-form-item>
			<a-form-item label="摘要">
				<a-textarea :autosize="{ minRows: 2, maxRows: 6 }"></a-textarea>
			</a-form-item>
			<a-form-item label="编辑器" hasFeedback>
				<a-radio-group name="status" v-model="editorType">
					<a-radio-button :value="'MARKDOWN'">
						Markdown
					</a-radio-button>
					<a-radio-button :value="'RICHTEXT'">
						富文本
					</a-radio-button>
				</a-radio-group>
			</a-form-item>
			<a-form-item label="内容">
				<EditorWrapper :mode="editorType"></EditorWrapper>
			</a-form-item>
			<a-form-item label="分类" hasFeedback>
				<a-select>
					<a-select-option value=".Net">.Net</a-select-option>
					<a-select-option value=".Net Core"
						>.Net Core</a-select-option
					>
				</a-select>
			</a-form-item>
			<a-form-item label="标签">
				<a-select mode="multiple" :defaultValue="['a1', 'b2']">
					<a-select-option
						v-for="i in 25"
						:key="(i + 9).toString(36) + i"
						>{{ (i + 9).toString(36) + i }}</a-select-option
					>
				</a-select>
			</a-form-item>
			<a-form-item label="访问量">
				<a-input-number :min="0" :defaultValue="0" />
			</a-form-item>
			<a-form-item label="点赞量">
				<a-input-number :min="0" :defaultValue="0" />
			</a-form-item>
			<a-form-item label="状态" hasFeedback>
				<a-radio-group name="status" :defaultValue="0">
					<a-radio :value="0">
						草稿
					</a-radio>
					<a-radio :value="1">
						发布
					</a-radio>
					<a-radio v-if="IsUpdate" :value="2">
						删除
					</a-radio>
				</a-radio-group>
			</a-form-item>
			<a-form-item v-if="IsUpdate" label="发布时间">
				<a-date-picker
					:locale="locale.date_picker"
					show-time
					format="YYYY-MM-DD HH:mm:ss"
				/>
			</a-form-item>
			<a-form-item
				label=""
				:labelCol="{ span: 4 }"
				:wrapperCol="{ span: 4, offset: 4 }"
			>
				<a-button type="primary" htmlType="submit">
					提交
				</a-button>
			</a-form-item>
		</a-form>
	</a-card>
</template>

<script>
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
			id: null,
			editorType: "MARKDOWN"
		};
	},
	computed: {
		mode() {
			return this.id ? UPDATE : ADD;
		},
		IsAdd() {
			return this.mode === ADD;
		},
		IsUpdate() {
			return this.mode === UPDATE;
		}
	},
	created() {
		this.id = this.$route.params.id;
		console.log(this.mode);
	}
};
</script>
