import axios from "axios";
import { simplifyResponse } from "./Simplify";

const simplify = simplifyResponse;

class TagService {
	async all() {
		const response = await axios.get("/api/Tag/all");

		return simplify(response);
	}

	async addOrUpdate(tag) {
		const response = tag.id
			? await axios.put("/api/Tag", tag)
			: await axios.post("/api/Tag", tag);

		return simplify(response);
	}

	async getAllEnabled() {
		const response = await axios.get("/api/Tag/all/enabled");

		return simplify(response);
	}
}

const singleton = new TagService();

export default singleton;
