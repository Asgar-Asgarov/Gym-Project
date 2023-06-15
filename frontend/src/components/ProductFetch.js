import React, { useEffect,useState } from 'react';
import Catalog from './catalog/Catalog';
import Loader from './Loader'


const ProductFetch = () => {
  const [products, setProducts] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
useEffect(() => {
  const fetchData = async () => {
    try {
      const response = await fetch('http://localhost:5261/api/product');
      const jsonData = await response.json();
      setProducts(jsonData);
      setIsLoading(false);
    } catch (error) {
      console.log(error);
    }
  };
  fetchData();
}, [])

//  function addProduct(){
// setProducts(prevState=>[...prevState,
// {
//   id:prevState.length + 101,
//   name:'product' + (prevState.length + 1),
//   price:(prevState.length * 100)+100,
//   imageUrl: ''
// }])
// }

if (isLoading) {
  return <Loader/>;
}


  return (
    <div>
      <h1>Product fetch</h1>
      <Catalog products={products.items}  />
    </div>
  )
}

export default ProductFetch