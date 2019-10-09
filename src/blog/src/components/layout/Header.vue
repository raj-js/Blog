<template>
    <el-row class="header fixed" :type="flex" :justify="center">
        <el-col :span="15" :push="3">
            <h1 class="title">
                Raj's Blog
                <span class="signature">做到极致，便是大师</span>
            </h1>
        </el-col>
        <el-col class="nav" :span="6">
            <el-menu default-active="article" mode="horizontal" router="true">
                <el-menu-item index="article">文章</el-menu-item>
                <el-menu-item index="live">生活</el-menu-item>
            </el-menu>
        </el-col>
    </el-row>
</template>

<style scoped>
.header {
    height: 60px;
    background: #fff;
    border-bottom: 1px #eef2e8 solid;
    margin: 0 auto;
    overflow: hidden;
}

.header .title {
    clear: both;
    line-height: 20px;
}

.header .title .signature {
    font-size: 15px;
    font-weight: 100;
}

</style>
