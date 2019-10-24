import axios from 'axios'
import APIS from './apis'

export default {
    paging(skip, take, category, tag) {
        return new Promise((resolve, reject) => {
            axios.get(`${APIS.ARTICLE.PAGING}?skip=${skip}&take=${take}&category=${category}&tag=${tag}`)
            .then(resp => {
                resolve(resp.data)
            })
            .catch(reject)
        })
    },
    details(id) {
        return new Promise((resolve, reject) => {
            axios.get(`${APIS.ARTICLE.DETAILS}/${id}`)
            .then(resp => {
                resolve(resp.data)
            })
            .catch(reject)
        })
    }
}