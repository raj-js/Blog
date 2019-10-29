<template>
	<v-card :loading="loading" class="mx-auto">
		<v-list-item two-line align="center">
			<v-list-item-content>
				<v-list-item-title class="headline">{{article.title}}</v-list-item-title>
				<v-list-item-subtitle>
					分类: {{article.category}}
					<v-divider vertical class="mx-3"></v-divider>
					标签: {{article.tags && article.tags.join(',')}}
					<v-divider vertical class="mx-3"></v-divider>
					发布日期: {{article.publishTime | date_format('YYYY-MM-DD')}}
				</v-list-item-subtitle>
			</v-list-item-content>
		</v-list-item>

		<v-divider></v-divider>

		<v-card-text v-html="article.content"></v-card-text>

		<v-divider></v-divider>

		<v-card-actions>
			<v-list-item>
				<v-btn text>PREVIOUS</v-btn>
				<v-spacer></v-spacer>
				<v-btn text>NEXT</v-btn>
			</v-list-item>
		</v-card-actions>
	</v-card>
</template>

<script lang="js">
	import date_format from "../filters/date-format";
	import articleService from "@/services/articleService";

	export default {
		data() {
			return {
				loading: true,
				id: null,
                article: {},
			};
		},
		filters: {
			date_format
		},
		mounted() {
			this.id = this.$route.params.id;

			articleService
				.details(this.id)
				.then(article => {
					this.loading = false;
                    this.article = article;
				})
				.catch(error => {
					this.loading = false;
					console.log(error);
				});
		}
	};
</script>