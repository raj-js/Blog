<template>
	<Editor :id="selector" :init="opts"></Editor>
</template>

<script>
import tinymce from "tinymce/tinymce";
import Editor from "@tinymce/tinymce-vue";
import "tinymce/themes/silver";

import "tinymce/plugins/image"; // 插入上传图片插件
import "tinymce/plugins/imagetools"; // 图片工具
import "tinymce/plugins/media"; // 插入视频插件
import "tinymce/plugins/table"; // 插入表格插件
import "tinymce/plugins/lists"; // 列表插件
import "tinymce/plugins/wordcount"; // 字数统计插件
import "tinymce/plugins/fullscreen"; // 全屏

export default {
	components: {
		Editor
	},
	props: {
		value: {
			type: String,
			default: ""
		},
		plugins: {
			type: [String, Array],
			default: "lists image imagetools media table wordcount fullscreen"
		},
		toolbars: {
			type: [String, Array],
			default:
				"undo redo | formatselect | " +
				" bold italic backcolor | alignleft aligncenter " +
				" alignright alignjustify | bullist numlist outdent indent |" +
				" removeformat | rotateleft rotateright | editimage imageoptions | fullscreen"
		}
	},
	data() {
		return {
			selector: `tinymce_${new Date().valueOf()}`,
			opts: {
				language_url: "/js/libs/tinymce/langs/zh_CN.js",
				language: "zh_CN",
				skin_url: `/js/libs/tinymce/skins/ui/oxide`,
				content_css:
					"/js/libs/tinymce/skins/content/default/content.css",
				height: 500,
				branding: false,
				menubar: false,
				plugins: this.plugins,
				toolbar: this.toolbars
			}
		};
	},
	mounted() {
		tinymce.init({});
	}
};
</script>
