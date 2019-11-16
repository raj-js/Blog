<template>
	<v-app class="overflow-hidden">
		<v-app-bar app clipped-left dense>
			<v-toolbar-title class="ml-0 pl-4 mr-5 align-center" style="width: 300px">
				<span class="title">Blog</span>
			</v-toolbar-title>

			<v-text-field 
                placeholder="Search..." 
                single-line 
                hide-details>
            </v-text-field>

			<v-spacer></v-spacer>

			<v-toolbar-items>
				<v-btn text>HOME</v-btn>

				<v-menu open-on-hover bottom offset-y>
					<template v-slot:activator="{on}">
						<v-btn text v-on="on">CATEGORY</v-btn>
					</template>

					<v-list dense>
						<v-list-item v-for="(v, i) in 3" :key="i" @click="openCategory(v)">
							<v-list-item-title>Category {{v}}</v-list-item-title>
						</v-list-item>
					</v-list>
				</v-menu>

				<v-btn text>ARCHIVE</v-btn>
				<v-btn text>ABOUT ME</v-btn>
			</v-toolbar-items>
		</v-app-bar>

		<v-content fill-height>
			<v-container fluid>
				<router-view></router-view>
			</v-container>
		</v-content>

		<v-footer app>footer</v-footer>
	</v-app>
</template>

<script>
	export default {
		methods: {
			openCategory(category) {
				alert(`open category ${category}`);
			}
		}
	};
</script>