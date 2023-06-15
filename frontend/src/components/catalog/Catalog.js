import React from 'react';

const Catalog = (products) => {
  return (
   <div>
   <ul>
   {Array.isArray(products.products) ? (products.products.map((product) => (
         <li key={product.id}>{product.name}-{product.price}</li>
        )
        )):(<div>No products found.</div>)
      }
         </ul>
   {/* <button onClick={addProduct}>Add product</button> */}
   
   </div>
  )
}

export default Catalog