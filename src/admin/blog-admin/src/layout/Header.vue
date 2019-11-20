<template>
	<el-header class="header">
		<el-row>
			<el-col span="4">
				<img class="logo" src="../assets/logo.png">
				<h1>123</h1>
			</el-col>
			<el-col span="20">123</el-col>
		</el-row>
	</el-header>
</template>

<style lang="scss" scoped>
.header {
	width: 100%;
	margin: 0;
	padding: 5px 10px;
	position: fixed;
	top: 0;
	left: 0;
	z-index: 999;
	overflow: hidden;
	border-bottom: 1px solid rgb(220, 223, 230);
}

.logo {
	width: 50px;
	height: 50px;
}
</style>
