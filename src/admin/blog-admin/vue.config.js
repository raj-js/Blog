const path = require("path");

module.exports = {
	configureWebpack: {
		devServer: {
			port: 3000,
			proxy: {
				"/api": {
					target: "http://localhost:5000"
				}
			}
		},
		resolve: {
			alias: {
				"@": path.resolve(__dirname, "src/")
			}
		}
	}
};
