import { Component, OnInit } from '@angular/core';
import { CategoriesService } from '../../services/categories.service';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
    categories: any[];
    category: any = {};
    subcategories: any[];

    constructor(private categoriesService: CategoriesService) { }

    ngOnInit() {
        this.categoriesService.getProducts().subscribe(categories =>
            this.categories = categories);
    }

    onCategoryChange() {
        var selectedCategory = this.categories.find(c => c.id == this.category);
        this.subcategories = selectedCategory ? selectedCategory.subcategories : [];
    }
}
