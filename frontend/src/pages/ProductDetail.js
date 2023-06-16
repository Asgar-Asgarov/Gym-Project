import React, {useEffect,useState} from 'react';
import {useParams} from 'react-router-dom';
import Loader from '../components/Loader';
import { Grid,Typography,Divider,TableContainer,Table,TableCell,TableRow, TableBody } from '@mui/material';

const ProductDetail = () => {
  const {id} = useParams();
  const [product, setProduct] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(`http://localhost:5261/api/product/${id}`);
        const jsonData = await response.json();
        setProduct(jsonData);
        setIsLoading(false);
        } catch (error) {
        console.log(error);
      }
    };
    fetchData();
  }, [id])

  if (isLoading) {
    return <Loader/>;
  }

  if (!product) {
    return <h3>Product not found</h3>
  }


    return (
   <Grid mt={2} container spacing={6}>
    <Grid item xs={6}>
     <img src={product.imageUrl} alt={product.name} style={{width:'100%'}}/>
    </Grid>
    <Grid item xs={6}>
     <Typography variant='h3'>
       {product.name} 
     </Typography>
     <Divider sx={{mb:2}}/>
     <Typography variant='h4' color='secondary'>${(product.price/100).toFixed(2)}</Typography>
     <TableContainer>
      <Table>
        <TableBody>
          <TableRow>
            <TableCell>Name</TableCell>
            <TableCell>{product.name}</TableCell>
          </TableRow>
          <TableRow>
            <TableCell>Price</TableCell>
            <TableCell>${(product.price/100).toFixed(2)}</TableCell>
          </TableRow>
        </TableBody>
      </Table>
     </TableContainer>
    </Grid>
   </Grid>
  )
}

export default ProductDetail