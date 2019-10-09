<template>
    <a-row class="header" type="flex" justify="start" align="top">
        <a-col class="title" :span="18" :push="2">
            <h1>
                Raj's Blog
                <span class="signature">做到极致，便是大师</span>
            </h1>
        </a-col>
        <a-col class="nav" :span="3">
            <a-menu :defaultSelectedKeys="['home']" mode="horizontal" >
                <a-menu-item key="home">
                    首页
                </a-menu-item>
                <a-menu-item key="article">
                    文章
                </a-menu-item>
                <a-menu-item key="live">
                    生活
                </a-menu-item>
            </a-menu>
        </a-col>
    </a-row>
</template>

<style scoped>
.header {
    height: 50px;
    background: #fff;
    border-bottom: 1px #eef2e8 solid;
    margin: 0 auto;
    overflow: hidden;
    position: relative;
}

.header .title {
    clear: both;
    line-height: 50px;
    vertical-align: middle;
}

.header .title .signature {
    font-size: 15px;
    font-weight: 100;
}

</style>
