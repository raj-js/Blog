<template>
	<v-container>
		<v-row dense>
			<v-col>
				<v-card tile class="mb-3" :to="`article/${v.id}`" v-for="v in data" :key="v.id">
					<v-img
						v-if="v.cover"
						class="white--text align-end"
						gradient="to bottom, rgba(0,0,0,.1), rgba(0,0,0,.5)"
						height="200px"
						:src="v.cover"
					>
						<v-card-title v-text="v.title"></v-card-title>
					</v-img>

					<v-card-title v-if="!v.cover" v-text="v.title"></v-card-title>

					<v-card-text class="subheading" v-text="v.digest"></v-card-text>

					<v-card-actions>
						<v-list-item class="grow">
							<v-row align="center" justify="start">
								<v-icon class="mr-1">mdi-heart</v-icon>
								<span class="subheading mr-2" v-text="v.likes"></span>
								<span class="mr-1">·</span>
								<v-icon class="mr-1">mdi-share-variant</v-icon>
								<span class="subheading" v-text="v.views"></span>
								<span class="mr-1">·</span>
								<v-icon class="mr-1">mdi-calendar</v-icon>
								<span class="subheading" v-text="v.creation"></span>
							</v-row>
							<v-row align="center" justify="end">
								<v-btn text :to="`article/${v.id}`">READ MORE ></v-btn>
							</v-row>
						</v-list-item>
					</v-card-actions>
				</v-card>
			</v-col>
		</v-row>
		<v-row dense>
			<v-col>
				<v-pagination circle :length="6"></v-pagination>
			</v-col>
		</v-row>
	</v-container>
</template>

<script>
	import {
		VRow,
		VCol,
		VCard,
		VCardTitle,
		VCardText,
		VCardActions,
		VListItem,
		VBtn,
		VImg,
		VIcon,
		VPagination
	} from "vuetify/lib";

	export default {
		components: {
			VRow,
			VCol,
			VCard,
			VCardTitle,
			VCardText,
			VCardActions,
			VListItem,
			VBtn,
			VImg,
			VIcon,
			VPagination
		},
		data: () => {
			return {
				data: []
			};
		},
		created() {
			for (let i = 0; i < 10; i++) {
				this.data.push(
					{
						id: i * 2,
						title: "Top 10 Australian beaches",
						cover: "https://cdn.vuetifyjs.com/images/cards/docks.jpg",
						digest: `
											                            该指南的目的是为了给读者心有个大概的轮廓。如果你对接下来要学习的内容感到困惑，这张路线图将指导你，而不是鼓励你选择时髦的东西。
														                你应该逐渐理解为什么一种工具比另一种工具更适合某些场景，并且记住时髦和新颖的东西并不总是意味着最适合这个工作。
											                        `,
						likes: 256,
						views: 1024,
						creation: "2019-10-24"
					},
					{
						id: i * 2 + 1,
						title: "Top 10 Australian beaches",
						cover: null,
						digest: `
											                            该指南的目的是为了给读者心有个大概的轮廓。如果你对接下来要学习的内容感到困惑，这张路线图将指导你，而不是鼓励你选择时髦的东西。
														                你应该逐渐理解为什么一种工具比另一种工具更适合某些场景，并且记住时髦和新颖的东西并不总是意味着最适合这个工作。
											                        `,
						likes: 256,
						views: 1024,
						creation: "2019-10-24"
					}
				);
			}
		}
	};
</script>
