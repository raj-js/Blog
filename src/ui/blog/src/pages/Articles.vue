<template>
	<v-row>
		<v-col>
			<ArticleList></ArticleList>
		</v-col>
	</v-row>
</template>

<script>
	import { VRow, VCol } from "vuetify/lib";

	import ArticleList from "@/components/ArticleList";
	// import RightPanel from "@/components/RightPanel";

	export default {
		components: {
			VRow,
			VCol,
			ArticleList
			// RightPanel
		}
	};
</script>