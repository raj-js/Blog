<template>
	<v-app>
		<v-app-bar app clipped-left color="amber">
			<v-app-bar-nav-icon @click="drawer = !drawer"></v-app-bar-nav-icon>
			<span class="title ml-3 mr-5">
				Raj's&nbsp;
				<span class="fontweight-light">Blog</span>
			</span>
			<v-text-field solo-inverted flat hide-details label="search" prepend-inner-icon="mdi-search"></v-text-field>
			<v-spacer></v-spacer>
		</v-app-bar>

		<v-navigation-drawer v-model="drawer" app clipped color="grey lighten-4">
			<v-list dense class="grey lighten-4">
				<template v-for="(item, i) in menus">
					<v-row v-if="item.heading" :key="i" align="center">
						<v-col cols="6">
							<v-subheader v-if="item.heading">{{ item.heading }}</v-subheader>
						</v-col>
						<v-col cols="6" class="text-right">
							<v-btn small text>edit</v-btn>
						</v-col>
					</v-row>
					<v-divider v-else-if="item.divider" :key="i" dark class="my-4"></v-divider>
					<v-list-item v-else :key="i">
						<v-list-item-action>
							<v-icon>{{ item.icon }}</v-icon>
						</v-list-item-action>
						<v-list-item-content>
							<v-list-item-title class="grey--text">{{ item.text }}</v-list-item-title>
						</v-list-item-content>
					</v-list-item>
				</template>
			</v-list>
		</v-navigation-drawer>

		<v-content>
			<v-container fluid class="grey lighten-4 fill-height">
				<Articles />
			</v-container>
		</v-content>
	</v-app>
</template>

<script>
	import Articles from "./components/Articles.vue";

	export default {
		name: "App",
		components: {
			Articles
		},
		data: () => ({
			drawer: null,
			menus: [
				{ icon: "mdi-home", text: "HOME" },
				{ icon: "mdi-apps", text: "CATEGORY" },
				{ icon: "mdi-tag", text: "TAG" },
				{ icon: "mdi-calendar", text: "TIMELINE" }
			]
		})
	};
</script>

<style>
	html {
		overflow-y: auto !important;
	}

	.v-application {
		overflow-y: auto !important;
		font-family: Source Code Pro, Lato, "PingFang SC", "Microsoft YaHei",
			sans-serif !important;
	}
</style>
