import axios from "axios";
import { simplifyResponse } from "./Simplify";

const simplity = simplifyResponse;

class TagService {
	async getAllTags() {
		const response = await axios.get("/api/Tag/all");

		return simplity(response);
	}

	async addOrUpdateTag(tag) {
		const response = tag.id
			? await axios.put("/api/Tag", tag)
			: await axios.post("/api/Tag", tag);

		return simplity(response);
	}
}

const singleton = new TagService();

export default singleton;
