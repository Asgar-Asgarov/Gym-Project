import React from 'react';
import ProductList from './ProductList';
import { Stack } from '@mui/material';

const Catalog = (products) => {
  return (
   <Stack mt={4} sx={{ml:{xs:4,lg:10}}}>
    <ProductList products={products.products}/>   
   </Stack>
  )
}

export default Catalog