import axios from 'axios'
import APIS from './apis'

export default {
    paging(skip, take, category, tag) {
        return new Promise((resolve, reject) => {
            axios.get(`${APIS.ARTICLE.PAGING}?skip=${skip}&take=${take}&category=${category}&tag=${tag}`)
            .then(resp => {
                const d = resp.data;
                if (d.isSuccess) {
                    resolve(d.data.list)
                } else {
                    reject(d.error)
                }
            })
            .catch(reject)
        })
    },
    details(id) {
        return new Promise((resolve, reject) => {
            axios.get(`${APIS.ARTICLE.DETAILS}/${id}`)
            .then(resp => {
                const d = resp.data;
                if (d.isSuccess) {
                    resolve(d.data)
                } else {
                    reject(d.error)
                }
            })
            .catch(reject)
        })
    }
}