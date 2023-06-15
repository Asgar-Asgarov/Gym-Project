import React from "react";
import {
  List,
  ListItem,
  ListItemAvatar,
  Avatar,
  ListItemText,
} from "@mui/material";

const ProductList = (products) => {
  return (
    <List>
      {Array.isArray(products.products) ? (
        products.products.map((product) => 
        <ListItem key={product.id}>
          <ListItemAvatar>
              <Avatar src={product.imageurl}/>
          </ListItemAvatar>
          <ListItemText>
           {product.name} - {product.price}
          </ListItemText>
        </ListItem>
        )) : (
          
        <div>No products found.{console.log("Products:"+products)}</div>
      )}
    </List>
  );
};

export default ProductList;
