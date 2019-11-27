<template>
	<a-card>
		<template v-slot:title>
			<h2>文章管理</h2>
		</template>

		<a-row class="toolbar">
			<a-col>
				<a-button type="primary">
					<router-link :to="`/article`">
						<a-icon type="plus"></a-icon> 新增
					</router-link>
				</a-button>
			</a-col>
		</a-row>

		<a-table
			:columns="cols"
			:locale="local"
			:dataSource="dataSource"
			:rowKey="v => v.id"
		>
			<template v-slot:row_title="title">
				{{ title }}
			</template>

			<template v-slot:row_tags="tags">
				<a-tag v-for="(v, i) in tags" :key="i">{{ v }}</a-tag>
			</template>

			<template v-slot:row_ops="id">
				<router-link :to="`/article/${id}`">详情</router-link>
			</template>
		</a-table>
	</a-card>
</template>

<script>
import articleService from "@/services/ArticleService";

articleService.getArticles();

export default {
	data() {
		return {
			local: {
				filterConfirm: "确定",
				filterReset: "重置",
				emptyText: "暂无数据..."
			},
			cols: [
				{
					title: "标题",
					dataIndex: "title",
					scopedSlots: { customRender: "row_title" }
				},
				{
					title: "分类",
					dataIndex: "category"
				},
				{
					title: "标签",
					dataIndex: "tags",
					scopedSlots: { customRender: "row_tags" }
				},
				{
					title: "访问量",
					dataIndex: "views"
				},
				{
					title: "点赞量",
					dataIndex: "likes"
				},
				{
					title: "状态",
					dataIndex: "status"
				},
				{
					title: "发布日期",
					dataIndex: "creation"
				},
				{
					title: "操作",
					dataIndex: "id",
					key: "ops",
					scopedSlots: { customRender: "row_ops" }
				}
			],
			dataSource: [
				{
					id: 1,
					title: "ASP.NET Core开发者成长路线图",
					category: "Asp.Net Core",
					tags: ["编程", ".Net Core"],
					views: 1024,
					likes: 512,
					status: "已发布",
					creation: "2019-09-09"
				}
			]
		};
	}
};
</script>

<style lang="scss" scoped>
.ant-form-item {
	display: flex;
}

.ant-form-item-control-wrapper {
	flex: 1;
}

.ant-form {
	max-width: none;
}

.toolbar {
	margin: 5px;
	padding: 5px;
}
</style>
