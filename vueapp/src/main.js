import { createApp } from 'vue'
import App from './App.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import { createRouter, createWebHashHistory } from 'vue-router'

import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'
import { aliases, mdi } from 'vuetify/iconsets/mdi'

import InitialScreen from './pages/InitialScreen'
import AdminPage from './pages/AdminPage'

const routes = [
    { path: '/', component: InitialScreen },
    { path: '/admin', component: AdminPage },
]

const vuetify = createVuetify({
    icons: {
        defaultSet: 'mdi',
        aliases,
        sets: {
            mdi,
        },
    },
    components,
    directives,
})

const router = createRouter({
    history: createWebHashHistory(),
    routes,
})

createApp(App)
    .use(vuetify)
    .use(VueAxios, axios)
    .use(router)
    .mount('#app')
