import axios from "axios";

class ArticleService {
	getArticles() {
		console.log("ArticleService output");
	}

	async getArticle(id) {
		let response = await axios.get("", {});
		return response;
	}
}

const singleton = new ArticleService();

export default singleton;
