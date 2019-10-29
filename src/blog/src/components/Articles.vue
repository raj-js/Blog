<template>
	<v-container fluid>
		<v-row justify="center" v-for="(article, i) in articles" :key="i">
			<v-col>
				<v-card>
					<v-list-item three-line :to="`/article/${article.id}`">
						<v-list-item-content>
							<v-list-item-title class="headline mb-1">{{article.title}}</v-list-item-title>
							<v-list-item-subtitle>{{article.digest}}</v-list-item-subtitle>
						</v-list-item-content>
					</v-list-item>

					<v-card-actions>
						<v-list-item class="grow">
							<v-row>
								<v-icon class="mr-1">mdi-eye</v-icon>
								<span class="subheading mr-2">{{article.reads}}</span>
								<span class="mr-1">·</span>
								<v-icon class="mr-1">mdi-thumb-up</v-icon>
								<span class="subheading mr-2">{{article.likes}}</span>
								<span class="mr-1">·</span>
								<v-icon class="mr-1">mdi-calendar</v-icon>
								<span class="subheading">{{article.creation | date_format('YYYY-MM-DD')}}</span>
							</v-row>
						</v-list-item>
					</v-card-actions>
				</v-card>
			</v-col>
		</v-row>
		<v-row justify="center" v-if="hasMore">
			<v-col class="text-center" cols="12">
				<v-btn class="ma-2" :loading="loading" @click="loadMore">加载更多...</v-btn>
			</v-col>
		</v-row>
	</v-container>
</template>

<script lang="js">
import date_format from '../filters/date-format'
import articleService from '../services/articleService'

export default {
  data() {
    return {
      pageIndex: 1,
      pageSize: 10,
      tag: null,
      category: null,
      articles: [],
      loading: true,
      hasMore: true
    }
  },
  filters: {
      date_format
  },
  mounted() {
    let query = this.$route.query

    this.category = query.category
    this.tag = query.tag

    this.loadMore()
  },
  methods: {
    loadMore() {
      if (!this.hasMore) return

      this.loading = true
      articleService
        .paging(this.pageIndex, this.pageSize, this.category || '', this.tag || '')
        .then(data => {
          let { list, total } = data
          console.log(total)

          if (list.length > 0) {
            this.pageIndex++
            this.hasMore = list.length == this.pageSize
          }
          this.articles = [...this.articles, ...list];
        })
        .catch(error => {
          console.error(error);
        })
        .finally(()=> {
          this.loading = false
        });
    }
  }
};
</script>
