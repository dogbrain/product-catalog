import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import Product from "../models/Product";

@Component
export default class ProductComponent extends Vue {
    product!: Product;

    isLoaded: boolean = false;
    mounted() {
        fetch('api/Products/' + this.$route.params.id) 
            .then(response => response.json() as Promise<Product>)
            .then(data => {
                this.product = data;
                this.isLoaded = true;
            });
       

    }
}
