<template>
	<div class="editorWrapper">
		<template v-if="mode === 'RICHTEXT'">
			<RichText></RichText>
		</template>
		<template v-else-if="mode === 'MARKDOWN'">
			<Markdown></Markdown>
		</template>
	</div>
</template>

<script>
import RichText from "./RichText";
import Markdown from "./Markdown";

export default {
	components: {
		RichText,
		Markdown
	},
	props: {
		mode: {
			type: String,
			default: "RICHTEXT",
			validator: value => {
				return ["RICHTEXT", "MARKDOWN"].indexOf(value) !== -1;
			}
		}
	},
	data() {
		return {};
	}
};
</script>

<style></style>
