import axios from 'axios'
import APIS from './apis'

export default {
    all() {
        return new Promise((resolve, reject) => {
            axios.get(APIS.CATEGORY.ALL)
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