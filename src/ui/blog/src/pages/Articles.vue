<template>
	<v-row style="height:1500px;">
		<v-col md="9">
			<ArticleList></ArticleList>
		</v-col>
		<v-col md="3">
			<RightPanel></RightPanel>
		</v-col>
	</v-row>
</template>

<script>
	import {
		VRow,
		VCol,
	} from 'vuetify/lib'

	import ArticleList from '@/components/ArticleList';
	import RightPanel from "@/components/RightPanel";

	export default {
		components: {
			VRow,
			VCol,
			ArticleList,
			RightPanel
		}
	};
</script>