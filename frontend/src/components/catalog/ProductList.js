import React from "react";
import { Grid } from "@mui/material";
import ProductCard from "./ProductCard";

const ProductList = (products) => {
  return (
    <Grid container spacing={2}>
      {Array.isArray(products.products) ? (
        products.products.map((product) => (
          <Grid item xs={5} key={product.id}>
            <ProductCard product={product} />
          </Grid>
        ))
      ) : (
        <div>No products found.{console.log("Products:" + products)}</div>
      )}
    </Grid>
  );
};

export default ProductList;
