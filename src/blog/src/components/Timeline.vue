<template>
    <v-container fluid>
        <v-row justify="center">
            <v-col cols="12">
                <v-timeline dense>
                    <v-timeline-item v-for="(item, i) in items" :key="i" small>
                        <v-card>
                            <v-list-item three-line>
                                <v-list-item-content>
                                    <v-list-item-title class="headline mb-1">{{item.title}}</v-list-item-title>
                                    <v-list-item-subtitle>{{item.digest}}</v-list-item-subtitle>
                                </v-list-item-content>
                            </v-list-item>

                            <v-card-actions>
                                <v-list-item class="grow">
                                    <v-row>
                                        <v-icon class="mr-1">mdi-eye</v-icon>
                                        <span class="subheading mr-2">{{item.reads}}</span>
                                        <span class="mr-1">·</span>
                                        <v-icon class="mr-1">mdi-thumb-up</v-icon>
                                        <span class="subheading mr-2">{{item.likes}}</span>
                                        <span class="mr-1">·</span>
                                        <v-icon class="mr-1">mdi-calendar</v-icon>
                                        <span class="subheading">{{item.creation}}</span>
                                    </v-row>
                                </v-list-item>
                            </v-card-actions>
                        </v-card>
                    </v-timeline-item>
                </v-timeline>
            </v-col>
        </v-row>
    </v-container>
</template>

<script>
    export default {
        data() {
            return {
                items: []
            }
        },
        mounted() {
            this.items = []

            for (let i = 0; i < 100; i++) {
                this.items.push({
                    title: "Abp 源码研读 - 依赖注入",
                    digest:
                        '摘要：Abp 框架对于依赖注入的实现主要是依赖 ，实际上这一篇更应该归类于 的应用， 若对 知识不了解的， 可以先去学习下： "Castle.Core" 。下面来分析下比较重要的接口/类： 核心接口 IIocManager 定义了对 Ioc 对象， 服务注册，服务解析，服务注册与否的判断，以及对解析对象的',
                    reads: 100,
                    likes: 200,
                    creation: "2019-10-20 23:59:59"
                })
            }
        },
        methods: {
            random(min, max) {
                return Math.floor(Math.random() * (max - min) + min)
            }
        }
    }
</script>