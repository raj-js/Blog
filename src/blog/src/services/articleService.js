import axios from 'axios'
import APIS from './apis'

export default {
    paging(pageIndex, pageSize, category, tag) {
        return new Promise((resolve, reject) => {
            axios.get(`${APIS.ARTICLE.PAGING}?pageIndex=${pageIndex}&pageSize=${pageSize}&category=${category}&tag=${tag}`)
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