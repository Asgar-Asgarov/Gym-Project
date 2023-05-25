import React from 'react';
import {Box,Button,Stack,TextField,Typography} from '@mui/material';

const SearchExercises = () => {
  return (
    <Stack
     alignItems="center" mt="37px">
      <Typography 
          fontWeight={700}
          sx={{
            fontSize:{lg:'44px',xs:'30px'}
          }}
      >
        Awesome Exercises You <br/>
        Should Know
      </Typography>

    </Stack>
  )
}

export default SearchExercises