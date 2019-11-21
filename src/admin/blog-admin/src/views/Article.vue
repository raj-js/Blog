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
				<a-radio-group>
					<a-radio-button value="0">
						草稿
					</a-radio-button>
					<a-radio-button value="1">
						发布
					</a-radio-button>
					<a-radio-button value="2">
						删除
					</a-radio-button>
				</a-radio-group>
			</a-form-item>
			<a-form-item label="发布时间">
				<a-date-picker
					show-time
					format="YYYY-MM-DD HH:mm:ss"
				/>
			</a-form-item>
			<a-form-item label="内容"></a-form-item>
		</a-form>
	</a-card>
</template>

<script>
const ADD = "ADD";
const UPDATE = "UPDATE";

export default {
	data() {
		return {
			id: null,
			formItemLayout: {
				labelCol: { span: 6 },
				wrapperCol: { span: 14 }
			}
		};
	},
	computed: {
		mode() {
			return this.id ? UPDATE : ADD;
		}
	},
	created() {
		this.id = this.$route.params.id;
		console.log(this.mode);
	}
};
</script>
