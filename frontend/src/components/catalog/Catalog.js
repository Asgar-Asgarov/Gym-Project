import React from 'react';
import ProductList from './ProductList';
import { Box } from '@mui/material';

const Catalog = (products) => {
  return (
   <Box ml={4} mt={4}>
    <ProductList products={products.products}/>   
   </Box>
  )
}

export default Catalog