import "./css/site.css";
import "bootstrap";
import Vue from 'vue';
import VueRouter from 'vue-router';
Vue.use(VueRouter);

const routes = [    
    { path: '/'             , component: require('./components/products/products.vue.html').default },
    { path: '/product/:id'  , component: require('./components/product/product.vue.html').default }
];

new Vue({
    el: '#app-root',
    router: new VueRouter({ mode: 'history', routes: routes }),
    render: h => h(require('./components/app/app.vue.html').default)
});
