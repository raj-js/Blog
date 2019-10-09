<template>
    <a-card class="introduce">
        <a-avatar shape="square" src="../assets/o_joey.png" :size="196" />
        <a-card-meta title="Mr·Raj">
            <template slot="description">
                <span class="text">一只正在进化中的程序猿</span>
            </template>
        </a-card-meta>
    </a-card>
</template>

<style>
.introduce {
    align-content: center;
    text-align: center;
    vertical-align: middle;
    margin: 5px;
    padding: 5px;   
}

.introduce .avatar {
    width: 100%;
    display: block;
    border-radius: 5px;
}

.introduce span.text {
    margin-top: 12px;
    width: 100%;
    text-align: center;
    font-size: 12px;
}
</style>