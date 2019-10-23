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
			<v-list shaped class="grey lighten-4">
				<v-list-item-group v-model="menu" color="primary">
					<template v-for="(item, i) in menus">
						<v-list-item :key="i">
							<v-list-item-action>
								<v-icon>{{ item.icon }}</v-icon>
							</v-list-item-action>
							<v-list-item-content>
								<v-list-item-title class="grey-text">{{ item.text }}</v-list-item-title>
							</v-list-item-content>
						</v-list-item>
					</template>
				</v-list-item-group>
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
			menu: 1,
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
