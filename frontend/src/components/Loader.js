import React from 'react';
import {Stack} from '@mui/material';
import {Dna} from 'react-loader-spinner';

const Loader = () => {
  return (
    <Stack direction="row" justifyContent="center" alignItems="center" width="
    100%">
    <Dna/>
    </Stack>
  )
}

export default Loader