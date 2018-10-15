import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import Product from "../models/Product";

@Component
export default class ProductsComponent extends Vue {
    products: Product[] = [];
    mounted() {
        fetch('api/Products')
            .then(response => response.json() as Promise<Product[]>)
            .then(data => {
                this.products = data;
                
            });
    }
}
