const BASE_URL = 'http://127.0.0.1:5000'

export default {
    ARTICLE: {
        PAGING: `${BASE_URL}/api/article/paging`,
        DETAILS: `${BASE_URL}/api/article`
    },
    CATEGORY: {
        ALL: `${BASE_URL}/api/category/all`
    },
    TAG: {
        ALL: `${BASE_URL}/api/tag/all`
    }
}