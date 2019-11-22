import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "./plugins/antd";
import MavonEditor from "mavon-editor";
import "mavon-editor/dist/css/index.css";

Vue.use(MavonEditor);

Vue.config.productionTip = false;

new Vue({
	router,
	store,
	render: h => h(App)
}).$mount("#app");
