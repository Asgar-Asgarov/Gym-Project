import React, { useEffect,useState } from 'react';
import Catalog from './catalog/Catalog';


const ProductFetch = () => {
  const [products, setProducts] = useState([])
useEffect(() => {
fetch('http://localhost:5261/api/product')
.then(response=>response.json())
.then(data=>setProducts(data))
}, [])

 function addProduct(){
setProducts(prevState=>[...prevState,
{
  id:prevState.length + 101,
  name:'product' + (prevState.length + 1),
  price:(prevState.length * 100)+100,
  imageUrl: ''
}])
}

  return (
    <div>
      <h1>Product fetch</h1>
      <Catalog products={products} addProduct={addProduct}/>
    </div>
  )
}

export default ProductFetch