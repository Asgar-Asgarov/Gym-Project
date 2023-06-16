import React from 'react';
import {
  Card,
  CardMedia,
  CardContent,
  Typography,
  CardActions,
  Button,
  CardHeader,
  Avatar
} from "@mui/material";
import {Link} from 'react-router-dom';

const ProductCard = (product) => {
  return (
    <Card >
      {/* <CardHeader
      avatar={
        <Avatar sx={{backgroundColor:'#FF2625'}}>
          {product.product.name.charAt(0).toUpperCase()}
        </Avatar>
      }
      title={product.product.name}
      /> */}
    <CardMedia
      sx={{ height: 140, backgroundSize:'contain',bgcolor:'#fff' }}
      image={product.product.imageUrl}
      title={product.product.name}
    />
    <CardContent>
      <Typography gutterBottom variant="h5" >
      {product.product.name}
          
      </Typography>
      <Typography variant="body2" color="text.secondary">
      ${(product.product.price/100).toFixed(2)} 
      </Typography>
    </CardContent>
    <CardActions>
      <Button sx={{color:'#fff',background:'#ffa9a9',
            fontSize:'14px',
            borderRadius:'20px',
            textTransform:'capitalize'
           }}>Add to Cart</Button>
      <Button component={Link} to={`/catalog/${product.product.id}`} sx={{ml:'21px',color:'#fff',background:'#fcc757',
            fontSize:'14px',
            borderRadius:'20px',
            textTransform:'capitalize'
           }}>View</Button>
            </CardActions>
  </Card>
  )
}

export default ProductCard