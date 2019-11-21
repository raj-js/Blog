const module = {
	namespaced: true,
	state: {
		collapsed: false
	},
	mutations: {
		toggleCollapsed(state) {
			state.collapsed = !state.collapsed
		}
	}
}

export default module
