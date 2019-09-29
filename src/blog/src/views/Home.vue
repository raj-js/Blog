<template>
    <div>
        <Header />
        <a-row class="body" type="flex" justify="center">
            <a-col :xs="0" :sm="0" :md="2" :lg="2" :xl="2">
                <SideMenu></SideMenu>
            </a-col>
            <a-col class="body-left" :xs="24" :sm="24" :md="10" :lg="16" :xl="12">
                <a-list
                        bordered
                        itemLayout="vertical"
                        size="large"
                        :pagination="pagination"
                        :dataSource="listData"
                >
                    <div slot="footer"><b>ant design vue</b> footer part</div>
                    <a-list-item slot="renderItem" slot-scope="item" key="item.title">
                        <template slot="actions" v-for="{type, text} in actions">
                            <span :key="type">
                              <a-icon :type="type" style="margin-right: 8px" />
                              {{text}}
                            </span>
                        </template>
                        <img slot="extra" width="272" alt="logo" src="https://gw.alipayobjects.com/zos/rmsportal/mqaQswcyDLcXyDKnZfES.png" />
                        <a-list-item-meta
                                :description="item.description"
                        >
                            <a slot="title" :href="item.href">{{item.title}}</a>
                            <a-avatar slot="avatar" :src="item.avatar" />
                        </a-list-item-meta>
                        {{item.content}}
                    </a-list-item>
                </a-list>
            </a-col>
            <a-col class="body-right" :xs="0" :sm="0" :md="12" :lg="6" :xl="4">
                <Profile />
            </a-col>
        </a-row>
    </div>
</template>

<script>
    import Header from '@/components/layout/Header.vue'
    import SideMenu from "@/components/layout/SideMenu"
    import Profile from "@/components/Profile"

    const listData = []
    for (let i = 0; i < 23; i++) {
        listData.push({
            href: 'https://vue.ant.design/',
            title: `ant design vue part ${i}`,
            avatar: 'https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png',
            description: 'Ant Design, a design language for background applications, is refined by Ant UED Team.',
            content: 'We supply a series of design principles, practical patterns and high quality design resources (Sketch and Axure), to help people create their product prototypes beautifully and efficiently.',
        })
    }
    export default {
        name: 'Home',
        data () {
            return {
                listData,
                pagination: {
                    onChange: () => {
                        //
                    },
                    pageSize: 10,
                },
                actions: [
                    { type: 'star-o', text: '156' },
                    { type: 'like-o', text: '156' },
                    { type: 'message', text: '2' },
                ],
            }
        },
        components: {
            Header,
            SideMenu,
            Profile
        }
    }
</script>

<style scoped>
    body{
        background-color: #f6f6f6;
    }

    .body {
        margin-top: .5rem;
    }

    .body-left{
        background-color: #FFF;
        padding:.3rem;
        border-radius: .3rem;
        border-bottom:1px solid #eee;
    }

    .body-right{
        background-color: #FFF;
        margin-left: .5rem;
        padding:.3rem;
        border-radius: .3rem;
        border-bottom:1px solid #eee;
    }

    .demo-loading {
        position: absolute;
        bottom: 40px;
        width: 100%;
        text-align: center;
    }
</style>