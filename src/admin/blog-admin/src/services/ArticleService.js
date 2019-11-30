import axios from "axios";
import { simplifyResponse } from "./Simplify";

const simplify = simplifyResponse;

class ArticleService {
	async paging(index, size) {
		const response = await axios.get(
			`/api/Article/paging?PageIndex=${index}&PageSize=${size}`
		);
		return simplify(response);
	}

	async get(id) {
		const response = await axios.get(`/api/Article/${id}`);
		return simplify(response);
	}

	async addOrUpdate(article) {
		const response = article.id
			? await axios.put("/api/Article", article)
			: await axios.post("/api/Article", article);

		return simplify(response);
	}

	async delete(id) {
		const response = await axios.delete(`/api/Article/${id}`);

		return simplify(response);
	}
}

const singleton = new ArticleService();

export default singleton;
