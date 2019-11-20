<template>
	<v-app-bar app clipped-left>
		<v-toolbar-title class="ml-0 pl-4 mr-5 align-center" style="width: 300px">
			<v-icon>Blog</v-icon>
		</v-toolbar-title>

		<v-text-field placeholder="Search..." single-line hide-details></v-text-field>

		<v-spacer></v-spacer>

		<v-toolbar-items>
			<v-btn text to="/">
				<v-icon>HOME</v-icon>
			</v-btn>

			<v-menu open-on-hover bottom offset-y flat>
				<template v-slot:activator="{on}">
					<v-btn v-on="on" text>
						<v-icon>CATEGORY</v-icon>
					</v-btn>
				</template>

				<v-list>
					<v-list-item v-for="(v, i) in 3" :key="i" @click="openCategory(v)">
						<v-list-item-title>Category {{v}}</v-list-item-title>
					</v-list-item>
				</v-list>
			</v-menu>

			<v-btn text>
				<v-icon>ARCHIVE</v-icon>
			</v-btn>
			<v-btn text>
				<v-icon>ABOUT ME</v-icon>
			</v-btn>
		</v-toolbar-items>
	</v-app-bar>
</template>

<script>
	import {
		VAppBar,
		VToolbarTitle,
		VIcon,
		VTextField,
		VSpacer,
		VToolbarItems,
		VBtn,
		VMenu,
		VList,
		VListItem,
		VListItemTitle
	} from "vuetify/lib";

	export default {
		components: {
			VAppBar,
			VToolbarTitle,
			VIcon,
			VTextField,
			VSpacer,
			VToolbarItems,
			VBtn,
			VMenu,
			VList,
			VListItem,
			VListItemTitle
		},
		methods: {
			openCategory(category) {
				alert(`open category ${category}`);
			}
		}
	};
</script>