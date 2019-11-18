import '@mdi/font/css/materialdesignicons.css'
import Vue from 'vue'
import Vuetify, { 
    VLayout
} from 'vuetify/lib'

Vue.use(Vuetify, {
    componments: {
        VLayout
    }
})

const opt = {
    icons: {
        iconfont: 'mdi'
    }
}

export default new Vuetify(opt)