<template>
	<a-breadcrumb style="margin: 16px 0">
		<a-breadcrumb-item v-for="(v, i) in routes" :key="i">{{v.title}}</a-breadcrumb-item>
	</a-breadcrumb>
</template>

<script>
export default {
	data() {
		return {
			routes: []
		};
	},
	methods: {
		calcRoutes() {
			let routes = this.$route.matched.filter(
				r => r.meta && r.meta.title
			);

			this.routes = routes.map((v, i, s) => {
				return {
					path: v.path,
					title: v.meta.title
				};
			});
		}
	},
	created() {
		this.calcRoutes();
	},
	watch: {
		$route(to, from) {
			this.calcRoutes();
		}
	}
};
</script>
