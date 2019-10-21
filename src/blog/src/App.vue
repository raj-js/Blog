<template>
	<v-app>
		<div app>
			<v-toolbar>
				<v-container mx-auto py-0>
					<v-layout>
						<v-img
							:src="require('@/assets/logo.png')"
							class="mr-5"
							contain
							height="48"
							width="48"
							max-width="48"
						/>

						<v-btn
							v-for="(item, i) in menus"
							:key="i"
							class="ml-0 hidden-sm-and-down"
							text
						>{{ item.text }}</v-btn>

						<v-spacer></v-spacer>

						<v-text-field
							append-icon="mdi-magnify"
							flat
							hide-details
							solo-inverted
							style="max-width: 300px;"
						/>
					</v-layout>
				</v-container>
			</v-toolbar>
		</div>

		<v-content app>
			<Articles />
		</v-content>

		<!-- <v-footer app>
			<v-bottom-navigation>
				<v-btn value="recent">
					<span>Recent</span>
					<v-icon>mdi-history</v-icon>
				</v-btn>

				<v-btn value="favorites">
					<span>Favorites</span>
					<v-icon>mdi-heart</v-icon>
				</v-btn>

				<v-btn value="nearby">
					<span>Nearby</span>
					<v-icon>mdi-map-marker</v-icon>
				</v-btn>
			</v-bottom-navigation>
		</v-footer> -->
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
			menus: [
				{ text: "HOME" },
				{ text: "CATEGORY" },
				{ text: "TAG" },
				{ text: "TIMELINE" }
			]
		})
	};
</script>

<style>
	html {
		overflow-y: auto !important;
	}
</style>
