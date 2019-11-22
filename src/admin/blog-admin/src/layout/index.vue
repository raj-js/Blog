<template>
	<a-layout id="app-wrapper">
		<Aside></Aside>
		<a-layout>
			<Header></Header>
			<a-layout-content style="margin: 0px 16px 60px 16px; padding:10px 0;">
				<div id="app-content-wrapper">
					<router-view />
				</div>
			</a-layout-content>
			<Footer></Footer>
		</a-layout>
	</a-layout>
</template>

<script>
import Aside from "./Aside";
import Header from "./Header";
import Footer from "./Footer";

export default {
	components: {
		Aside,
		Header,
		Footer
	}
};
</script>

<style lang="scss">
#app-wrapper {
	min-height: 100vh;
}

#app-wrapper .logo {
	height: 32px;
	background: rgba(255, 255, 255, 0.2);
	margin: 16px;
}

#app-content-wrapper {
	padding: 10px;
	min-height: 100%;
	overflow-y: scroll;
	overflow-x: hidden;
}
</style>
