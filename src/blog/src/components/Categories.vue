<template>
  <v-container fluid>
    <v-row>
      <v-col cols="2" v-for="(item, i) in items" :key="i">
        <v-card class="mx-auto" max-width="300">
          <v-img :src="item.cover" height="200px"></v-img>
          <v-card-title v-text="item.title"></v-card-title>
          <v-card-subtitle v-text="item.description"></v-card-subtitle>
          <v-card-actions>
            <v-list-item class="grow">
              <v-row>
                <v-icon class="mr-1">mdi-eye</v-icon>
                <span class="subheading mr-2">{{item.reads}}</span>
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
export default {
  data() {
    return {
      items: [
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        },
        {
          cover: "https://cdn.vuetifyjs.com/images/cards/sunshine.jpg",
          title: "Asp.Net Core",
          description:
            "ASP.NET Core is an open-source and cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.",
          reads: 300,
          articles: 3
        }
      ]
    };
  }
};
</script>