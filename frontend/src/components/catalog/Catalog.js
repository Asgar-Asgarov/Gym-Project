import React from 'react'

const Catalog = ({products,addProduct}) => {
  return (
   <>
   <ul>
    {products.map(product=>(
    <li key={product.id}>{product.name}-{product.price}</li>       
      ))}
   </ul>
   <button onClick={addProduct}>Add product</button>
   </>
  )
}

export default Catalog