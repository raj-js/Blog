/**
 * 简化 axios response
 * @param {[AxiosResponse<any>]} response [axios 请求响应]
 * @returns {[Promise<any>]} [简化后的响应内容]
 */
export function simplifyResponse(response) {
	if (response.status === 200) {
		if (response.data) {
			return response.data.isSuccess
				? Promise.resolve(response.data)
				: Promise.reject(response.data.msg);
		}
	}
	return Promise.reject(response.status);
}

/**
 * 简化 axios response 在使用 simplifyResponse 简化之后产生的 Promise.reject 内容
 * @param {[Number|Array|Unknow]} error [Promise.reject 的实参]
 * @param {[function:void(){}]} onStatusCodeError [状态码错误（请求层面）]
 * @param {[function:void(){}]} onResponseContentError [响应内容错误（业务层面）]
 * @param {[function:void(){}]} onUnknowError [未知错误]
 * @returns {[void]}
*/
export function simplifyReject(
	error,
	onStatusCodeError,
	onResponseContentError,
	onUnknowError
) {
	if (error instanceof Number) {
		if (onStatusCodeError) onStatusCodeError();
	} else if (error instanceof String) {
		if (onResponseContentError) onResponseContentError();
	} else {
		if (onUnknowError) onUnknowError();
	}
}
