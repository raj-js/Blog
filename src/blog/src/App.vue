<template>
	<v-app id="app">
		<v-app-bar app clipped-left color="primary">
			<v-app-bar-nav-icon @click="drawer = !drawer"></v-app-bar-nav-icon>
			<span class="title ml-3 mr-5">
				Raj's&nbsp;
				<span class="fontweight-light">Blog</span>
			</span>
			<v-text-field solo-inverted flat hide-details label="search" prepend-inner-icon="mdi-search"></v-text-field>
			<v-spacer></v-spacer>
		</v-app-bar>

		<v-navigation-drawer v-model="drawer" app clipped color="grey lighten-4">
			<v-img :aspect-ratio="16/9" src="https://cdn.vuetifyjs.com/images/parallax/material.jpg">
				<v-row align="end" class="lightbox white--text pa-2 fill-height">
					<v-col>
						<div class="subheading">Mr. Raj</div>
						<div class="body-1">rajesh.js@live.cn</div>
					</v-col>
				</v-row>
			</v-img>

			<v-list class="grey lighten-4">
				<v-list-item-group v-model="menu" color="primary">
					<template v-for="(item, i) in menus">
						<v-list-item :key="i" :to="item.link">
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

		<v-content class="grey lighten-4">
			<v-container fluid class="fill-height">
				<v-fade-transition mode="out-in">
					<router-view></router-view>
				</v-fade-transition>
			</v-container>
		</v-content>
	</v-app>
</template>

<script>
	export default {
		name: "App",
		data: () => ({
			drawer: null,
			menu: 1,
			menus: [
				{ icon: "mdi-home", text: "HOME", link: "/" },
				{ icon: "mdi-apps", text: "CATEGORY", link: "/categories" },
				{ icon: "mdi-tag", text: "TAG", link: "/tags" },
				{ icon: "mdi-calendar", text: "TIMELINE", link: "/timeline" }
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