import React, { useEffect,useState } from 'react';
import Catalog from './Catalog';
import Loader from '../Loader'


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


if (isLoading) {
  return <Loader/>;
}


  return (
    <div>
        <Catalog products={products.items}  />
    </div>
  )
}

export default ProductFetch