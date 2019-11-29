import axios from "axios";
import { simplifyResponse } from "./Simplify";

const simplify = simplifyResponse;

class CategoryService {
	async getAllCategories() {
		const response = await axios.get("/api/Category/all");
		return simplify(response);
	}

	async getCategory(id) {
		const response = await axios.get(`/api/Category/${id}`);
		return simplify(response);
	}

	async addOrUpdateCategory(category) {
		const response = category.id
			? await axios.put("/api/Category", category)
			: await axios.post("/api/Category", category);

		return simplify(response);
	}

	async deleteCategory(id) {
		const response = await axios.delete(`/api/Category/${id}`);
		return simplify(response);
	}
}

const singleton = new CategoryService();

export default singleton;
