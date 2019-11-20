<template>
	<el-container direction="vertical">
		<Header></Header>
		<el-container>
			<Aside></Aside>
			<el-main>main</el-main>
		</el-container>
		<Footer></Footer>
	</el-container>
</template>

<script>
    import Header from '@/layout/Header'
    import Aside from '@/layout/Aside'
    import Footer from '@/layout/Footer'

	export default {
        components: {
            Header,
            Aside,
            Footer
        }
    };
</script>