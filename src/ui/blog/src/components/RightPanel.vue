<template>
	<v-card tile>
		<v-list-item class="grow">
			<v-row align="center" justify="center" class="profile">
				<v-avatar class="avatar" size="120">
					<v-img src="https://www.cnblogs.com/images/cnblogs_com/rajesh/1441222/o_joey.png"></v-img>
				</v-avatar>
			</v-row>
		</v-list-item>

		<v-divider></v-divider>

		<v-card-text class="text--primary blockquote">
			一只正在进化的程序猿...
		</v-card-text>
	</v-card>
</template>

<script>
	import { VCard, VAvatar, VImg, VListItem, VRow, VCardText, VDivider } from "vuetify/lib";

	export default {
		components: {
			VCard,
			VAvatar,
			VImg,
			VListItem,
			VRow,
			VCardText,
			VDivider
		}
	};
</script>

<style>
.profile {
	height: 200px;
}

.profile .avatar {
	position: relative;
	top: -15px;
}
</style>