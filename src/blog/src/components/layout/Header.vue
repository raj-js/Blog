<template>
    <a-row class="header" type="flex" justify="center">
        <a-col :xs="24" :sm="24" :md="10" :lg="16" :xl="12">
            <span class="header-logo">小刀编程</span>
            <span class="header-signature">做到极致，便是大师</span>
        </a-col>
        <a-col class="header-nav" :xs="0" :sm="0" :md="14" :lg="8" :xl="6">
            <a-menu mode="horizontal" :defaultSelectedKeys="['home']">
                <a-menu-item key="home">
                    <a-icon type="home" /> 文章
                </a-menu-item>
                <a-menu-item key="smile">
                    <a-icon type="smile" /> 生活
                </a-menu-item>
            </a-menu>
        </a-col>
    </a-row>
</template>

<script>
export default {
    name: "Header"
}
</script>

<style scoped>
.header {
    background-color: #fff;

    padding: .4rem;
    overflow: hidden;
    height: 2.8rem;
    border-bottom:1px solid #ccc;
}

    .header .header-logo {
        color:#1e90ff;
        font-size: 1.4rem;
        text-align: left;
        font-weight: 600;
    }

    .header .header-signature {
        font-size: 0.6rem;
        color: #999;
        display: inline-block;
        padding-left: 0.3rem;
    }

.ant-meu{
    line-height: 2.8rem;
}

.ant-menu-item{
    font-size:1rem !important;
    padding-left:1rem;
    padding-right:1rem;
}

</style>