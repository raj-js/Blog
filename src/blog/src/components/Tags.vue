<template>
	<v-container fluid>
		<v-row justify="center">
			<v-col cols="6">
				<v-text-field label="filter tags" v-model="filter" @input="filtering" clearable>
					<v-icon slot="append" color="red">mdi-filter</v-icon>
				</v-text-field>
			</v-col>
		</v-row>
		<v-row justify="center">
			<v-col cols="8">
				<v-fade-transition mode="out-in" group>
					<v-chip
						v-show="showChip(item.name)"
						text-color="white"
						v-for="(item, i) in items"
						:key="i"
						:to="`/?tag=${item.id}`"
					>
						<v-avatar left>
							<v-icon>mdi-label</v-icon>
						</v-avatar>
						{{item.name}}
					</v-chip>
				</v-fade-transition>
			</v-col>
		</v-row>
	</v-container>
</template>

<script>
	import tagService from '@/services/tagService'

	export default {
		data: () => ({
			filter: "",
			items: []
		}),
		mounted() {
			this.loadTags()
		},
		methods: {
			filtering(e) {
				console.log(this.filter, e);
			},
			random(min, max) {
				return Math.floor(Math.random() * (max - min) + min);
			},
			showChip(text) {
				return (
					!this.filter ||
					this.filter.trim() == "" ||
					text.indexOf(this.filter) != -1
				);
			},
			loadTags() {
				tagService
					.all()
					.then(data => {
						this.items = [...this.items, ...data]
					})
					.catch(console.log)
					.finally(()=> {
						console.log('finally')
					})
			}
		}
	};
</script>