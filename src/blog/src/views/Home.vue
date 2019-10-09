<template>
  <Layout>
    <a-row :gutter="16" type="flex" justify="start">
      <a-col class="left" :span="4" :offset="2">
         <a-row class="item">
           <Introduce />
         </a-row>
         <a-row class="item">
           <Category />
         </a-row>
         <a-row class="item">
           <Archive />
         </a-row>
      </a-col>
      <a-col :span="16">
        <PostList />
      </a-col>
    </a-row>
  </Layout>
</template>

<script>
import Layout from '@/components/layout/Layout.vue'
import Introduce from '@/components/Introduce.vue'
import PostList from '@/components/PostList.vue'
import Category from '@/components/Category.vue'
import Archive from '@/components/Archive.vue'

export default {
  name: 'Home',
  components: {
    Layout,
    Introduce,
    PostList,
    Category,
    Archive
  }
}
</script>

<style>
.left {
  border-right: 1px #eef2e8 solid;
}

.left .item {
  margin-bottom: 10px;
}

</style>