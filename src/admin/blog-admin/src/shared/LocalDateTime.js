import LocaleCalendar from "ant-design-vue/lib/vc-calendar/src/locale/zh_CN";
import LocaleTimePicker from "ant-design-vue/lib/time-picker/locale/zh_CN";

export default {
	lang: {
		placeholder: "请选择日期",
		rangePlaceholder: ["开始日期", "结束日期"],
		...LocaleCalendar
	},
	timePickerLocale: {
		...LocaleTimePicker
	}
};
