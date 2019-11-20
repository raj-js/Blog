<template>
	<el-container direction="vertical" class="app-wrapper">
		<Header></Header>
		<el-container class="ctt-wrapper">
			<Aside class="nav-wrapper"></Aside>
			<el-main class="main-wrapper">main</el-main>
		</el-container>
		<Footer></Footer>
	</el-container>
</template>

<script>
import Header from "@/layout/Header";
import Aside from "@/layout/Aside";
import Footer from "@/layout/Footer";

export default {
	components: {
		Header,
		Aside,
		Footer
	}
};
</script>

<style lang="scss" scoped>
.app-wrapper {
	position: relative;
	width: 100%;
	height: 100%;
	clear: both;
	margin: 0;
	padding: 0;
}

.ctt-wrapper {
	margin-top: 60px;
	padding: 0px;
	height: calc(100% - 80px);
	width: 100%;
	overflow-y: hidden;
	position: relative;
	border: 1px solid red;
}

.nav-wrapper {
	margin: 5px;
	border: 1px solid black;
}

.main-wrapper {
	width: 100%;
	height: 1500px;
	margin: 5px;
	overflow-y: scroll;
	border: 1px solid black;
	z-index: 999;
}
</style>
