import axios from "axios";
import { simplifyResponse } from "./Simplify";

const simplify = simplifyResponse;

class CategoryService {
	async all() {
		const response = await axios.get("/api/Category/all");
		return simplify(response);
	}

	async get(id) {
		const response = await axios.get(`/api/Category/${id}`);
		return simplify(response);
	}

	async addOrUpdate(category) {
		const response = category.id
			? await axios.put("/api/Category", category)
			: await axios.post("/api/Category", category);

		return simplify(response);
	}

	async delete(id) {
		const response = await axios.delete(`/api/Category/${id}`);
		return simplify(response);
	}

	async getAllEnabled() {
		const response = await axios.get("/api/Category/all/enabled");

		return simplify(response);
	}
}

const singleton = new CategoryService();

export default singleton;
