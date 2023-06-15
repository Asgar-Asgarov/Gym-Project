import React from 'react';
import ProductList from './ProductList';

const Catalog = (products) => {
  return (
   <div>
    <ProductList products={products.products}/>   
   </div>
  )
}

export default Catalog