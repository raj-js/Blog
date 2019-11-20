<template>
	<v-row>
		<v-col>
			<v-card tile>
				<v-img
					v-if="article.cover"
					class="white--text align-end"
					gradient="to bottom, rgba(0,0,0,.1), rgba(0,0,0,.5)"
					:src="article.cover"
					max-height="300"
				>
					<v-container>
						<v-row>
							<v-col align="center" justify="center">
								<h1 v-text="article.title"></h1>
							</v-col>
						</v-row>
						<v-row>
							<v-col align="center" justify="center">
								<v-icon color="white" class="mr-1">mdi-thumb-up</v-icon>
								<span class="subheading mr-2" v-text="article.likes"></span>
								<span class="mr-1">·</span>
								<v-icon color="white" class="mr-1">mdi-eye</v-icon>
								<span class="subheading" v-text="article.views"></span>
								<span class="mr-1">·</span>
								<v-icon color="white" class="mr-1">mdi-calendar</v-icon>
								<span class="subheading" v-text="article.creation"></span>
							</v-col>
						</v-row>
					</v-container>
				</v-img>
				<v-container v-else>
					<v-row>
						<v-col align="center" justify="center">
							<h1 v-text="article.title"></h1>
						</v-col>
					</v-row>
					<v-row>
						<v-col align="center" justify="center">
							<v-icon class="mr-1">mdi-thumb-up</v-icon>
							<span class="subheading mr-2" v-text="article.likes"></span>
							<span class="mr-1">·</span>
							<v-icon class="mr-1">mdi-eye</v-icon>
							<span class="subheading" v-text="article.views"></span>
							<span class="mr-1">·</span>
							<v-icon class="mr-1">mdi-calendar</v-icon>
							<span class="subheading" v-text="article.creation"></span>
						</v-col>
					</v-row>
				</v-container>

				<v-card-text class="text--primary" v-html="article.content"></v-card-text>
			</v-card>
		</v-col>
	</v-row>
</template>

<script>
	import {
		VRow,
		VCol,
		VCard,
		VCardText,
		VContainer,
		VImg,
		VIcon
	} from "vuetify/lib";

	export default {
		data: () => {
			return {
				article: {
					id: 1,
					title: "Top 10 Australian beaches",
					cover: "https://cdn.vuetifyjs.com/images/cards/docks.jpg",
					likes: 256,
					views: 1024,
					creation: "2019-10-24",
					content: `
									                <p>在 Swarm 集群中， 创建服务时可以通过设置 <code>--replicas</code>  参数来指定此服务在工作节点上运行的任务数。</p>

									<h3>示例</h3>

									<p>这里我们来创建一个 nginx 服务作为示例：</p>

									<p><code></code>\`yaml
									version: &#39;3&#39;</p>

									<p>services: 
									  nginx:
									    image: nginx:latest
									    deploy:
									      replicas: 3
									    ports: 
									      - &quot;80:80&quot;
									    networks: 
									      - net
									  visualizer:
									    image: dockersamples/visualizer:stable
									    ports: 
									      - &quot;8080:8080&quot;
									    volumes: 
									      - &quot;/var/run/docker.sock:/var/run/docker.sock&quot;
									    deploy:
									      placement:
									        constraints: [node.role == manager]
									    networks: 
									      - net</p>

									<p>networks: 
									  net:
									<code></code>\`</p>

									<p>在文件所在目录执行 <code>docker stack deploy -c docker-compose.yml nginx</code>  来创建服务，由于我这里只准备了一台 Docker 主机， 所以在这个 Swarm 集群中情况如图所示：</p>

									<p><img alt="nginx示例服务visualizer" src="http://images.cnblogs.com/cnblogs_com/rajesh/1441570/o_nginx%E7%A4%BA%E4%BE%8B%E6%9C%8D%E5%8A%A1visualizer.png"/></p>

									<p>可以看到我们的 nginx 服务创建了 3个 nginx_nginx 任务， 1个visualizer 服务。</p>

									<p><code>docker ps</code>  查看所有容器</p>

									<p><code>docker exec -it &lt;container id&gt; /bin/bash</code> 依次进入到3个 nginx_nginx 任务所对应的容器中</p>

									<p><code>cd /usr/share/nginx/html</code> 找到 index.html 文件</p>

									<p>将3个容器中 index.html 的内容分别改为 nginx.1, nginx.2, nginx.3</p>

									<p><code>echo nginx.1 &gt; index.html</code></p>

									<p>...</p>

									<p>然后我们访问 http://127.0.0.1 ， 即可看到相对应的修改页面。 这里我们多尝试几次，会发现，有时候出现的是 nginx.1, 也会出现 nginx.2,  nginx.3 。 这就是 Docker Swarm 集群模式中自带的负载均衡带来的效果。</p>

									<p>下面，我们来收缩或者拓展在一台工作节点上执行的任务量：</p>

									<p>收缩：</p>

									<p><code>docker service scale nginx_nginx=2</code> </p>

									<p>拓展</p>

									<p><code>docker service scale nginx_nginx=5</code></p>

									<p>可通过 <code>docker service ls</code> 来查看服务概况。</p>

									<h3>总结</h3>

									<p> 服务的部署模式有两种：</p>

									<ul><li>global : 每个工作节点上都会运行一个服务</li><li>replicated: 每个工作节点会运行 replicas  个服务</li></ul>

									<p>Docker Swarm 集群内置的负载均衡，在同一个工作节点上， 多个相同的任务（容器）会由 Swarm 集群的负载均衡来命中。</p>
									                `
				}
			};
		},
		components: {
			VRow,
			VCol,
			VCard,
			VCardText,
			VContainer,
			VImg,
			VIcon
		},
		created() {
			console.log(this.$route.params.id);
		}
	};
</script>