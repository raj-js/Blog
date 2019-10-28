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
                <span class="subheading">{{article.creation}}</span>
              </v-row>
            </v-list-item>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script lang="js">
import articleService from '../services/articleService'

export default {
  data: () => ({
    skip: 0,
    take: 10,
    tag: null,
    category: null,
    articles: []
  }),
  mounted() {
    let query = this.$route.query

    this.category = query.category
    this.tag = query.tag

    articleService
      .paging(this.skip, this.take, this.category || '', this.tag || '')
      .then(articles => {
        this.articles = [...this.articles, ...articles];
      })
      .catch(error => {
        console.error(error);
      });
  }
};
</script>
