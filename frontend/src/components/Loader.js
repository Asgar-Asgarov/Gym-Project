import React from 'react';
import {Stack} from '@mui/material';
import {ThreeCircles} from 'react-loader-spinner';

const Loader = () => {
  return (
    <Stack direction="row" justifyContent="center" alignItems="center" width="
    100%">
    <ThreeCircles sx={{color:'#FF2625'}}/>
    </Stack>
  )
}

export default Loader