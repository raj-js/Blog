import Vue from 'vue'
import moment from 'moment'

const filters = Vue.filter('date-format', function(value, format) {
    console.log(value, format)
    if (value && moment(value).isValid()) {
        return moment(value).format(format)
    }
    return ''
})

export default filters