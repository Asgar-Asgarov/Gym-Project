import React from "react";
import {
  List, ListItem
} from "@mui/material";
import ProductCard from "./ProductCard";

const ProductList = (products) => {
  return (
    <List>
      {Array.isArray(products.products) ? (
        products.products.map((product) => (
          <ProductCard key={product.id} product={product} />     
           
        ))) : (
          
        <div>No products found.{console.log("Products:"+products)}</div>
      )}
    </List>
  );
};

export default ProductList;
