<template>
	<a-layout class="fill-height">
		<a-row class="height-35p" type="flex" align="bottom" justify="center">
			<a-col :xs="8" :sm="4" :md="4" :lg="2">
				<img src="../assets/logo.png" class="logo" />
			</a-col>
		</a-row>
		<a-row class="height-65p" type="flex" align="top" justify="center">
			<a-col :xs="20" :sm="16" :md="16" :lg="8">
				<router-view></router-view>
			</a-col>
		</a-row>
	</a-layout>
</template>

<style scoped>
.logo {
	width: 100%;
	max-width: 200px;
	min-width: 100px;
}

.fill-height {
	height: 100vh;
}
.height-35p {
	height: 35vh;
}
.height-65p {
	height: 65vh;
}
</style>
