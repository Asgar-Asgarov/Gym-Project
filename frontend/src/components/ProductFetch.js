import React, { useEffect } from 'react';
import Catalog from './catalog/Catalog';

const [products, setProducts] = useState([])
useEffect(() => {
fetch('')
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

const ProductFetch = () => {
  return (
    <div>
      <h1>Product fetch</h1>
      <Catalog products={products} addProduct={addProduct}/>
    </div>
  )
}

export default ProductFetch