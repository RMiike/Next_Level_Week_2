import axios from 'axios'

const api = axios.create({
  baseURL: 'http://localhost:58804/v1'
})

export default api;