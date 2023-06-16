import React from 'react';
import {Box,Typography,Stack} from  '@mui/material';

import Logo from '../assets/images/Logo.png'

const Footer = () => {
  return (
    <Box mt="80px" bgcolor="#fff3f4">
   <Stack gap="40px" alignItems="center" px="40px" pt="24px">
    <img src={Logo} alt="logo" width="48px" height="48px" />
    <Typography variant="h5" pb="40px" mt="20px">
      Made By Asgar
    </Typography>
   </Stack>
    </Box>
  )
}

export default Footer