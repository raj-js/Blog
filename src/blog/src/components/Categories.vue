<template>
  <v-container fluid>
    <v-row>
      <v-col cols="3" v-for="(item, i) in items" :key="i">
        <v-card class="mx-auto" max-width="300" :to="`/?category=${item.id}`">
          <v-img :src="getCover(item.id)" height="200px"></v-img>
          <v-card-title v-text="item.name"></v-card-title>
          <v-card-subtitle v-text="item.description"></v-card-subtitle>
          <v-card-actions>
            <v-list-item class="grow">
              <v-row>
                <v-icon class="mr-1">mdi-fire</v-icon>
                <span class="subheading mr-2">{{item.temperature}}</span>
                <span class="mr-1">·</span>
                <v-icon class="mr-1">mdi-book-open</v-icon>
                <span class="subheading mr-2">{{item.articles}}</span>
              </v-row>
            </v-list-item>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import APIS from '@/services/apis'
import categoryService from '@/services/categoryService'

export default {
  data() {
    return {
      loading: true,
      items: []
    };
  },
  mounted() {
    this.load();
  },
  methods: {
    load() {
      this.loading = true;

      categoryService
        .all()
        .then(data => {
          this.items = [...this.items, ...data];
        })
        .catch(error => {
          console.log(`load category error: ${JSON.stringify(error)}`)
        })
        .finally(() => {
          this.loading = false;
        });
    },
    getCover(id) {
      return `${APIS.CATEGORY.COVER}/${id}`
    } 
  }
};
</script>