import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
    products: any[];

    constructor(private productService: ProductService) { }

    ngOnInit() {
        this.productService.getProducts().subscribe(products => {
            this.products = products;
            console.log("PRODUCTS", products);
        });
  }

}
