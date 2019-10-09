<template>
    <a-list
        itemLayout="vertical"
        size="large"
        split="true"
        :dataSource="source"
        >
            <a-list-item slot="renderItem" slot-scope="item" key="item.title">
                <template slot="actions" v-for="{ type, text } in actions">
                    <span :key="type">
                        <a-icon :type="type" style="margin-right: 8px;"/> {{ text }}
                    </span>
                </template>

                <a-list-item-meta 
                    :description="item.description">
                    <a slot="title" :href="item.href">{{ item.title }}</a>
                </a-list-item-meta>

                {{ item.content }}
            </a-list-item>
        </a-list>
</template>

<script>
const source = []

for (let i = 0; i < 5; i++) {
  source.push({
    href: 'https://vue.ant.design/',
    title: `ant design vue part ${i}`,
    avatar: 'https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png',
    description: 'Ant Design, a design language for background applications, is refined by Ant UED Team.',
    content: 'We supply a series of design principles, practical patterns and high quality design resources (Sketch and Axure), to help people create their product prototypes beautifully and efficiently.',
  })
}

export default {
    data () {
        return {
            source,
            actions: [
                { type: 'star-o', text: '156' },
                { type: 'like-o', text: '156' },
                { type: 'message', text: '2' },
            ]
        }        
    }
}

</script>