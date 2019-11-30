import { simplifyReject } from "../services/Simplify";

export function reject(_this, error) {
	simplifyReject(
		error,
		() => _this.$message.error(`请求失败，状态码：${error}`),
		() => _this.$message.error(`请求失败，错误信息：${error}`),
		() => _this.$message.error(`请求失败，未知错误：${error}`)
	);
}
