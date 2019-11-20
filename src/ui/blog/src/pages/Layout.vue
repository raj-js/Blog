<template>
	<v-app>
		<NavBar></NavBar>

		<v-content fill-height>
			<v-container>
				<router-view></router-view>
			</v-container>
		</v-content>

		<Footer></Footer>
	</v-app>
</template>

<script>
	import { VApp, VContent, VContainer } from "vuetify/lib";
	import NavBar from "@/components/layout/NavBar";
	import Footer from "@/components/layout/Footer";

	export default {
		components: {
			VApp,
			VContent,
			VContainer,
			NavBar,
			Footer
		},
		methods: {}
	};
</script>