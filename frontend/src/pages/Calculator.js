import React from 'react';
import BodyFatCalculator from '../components/Calculator/BodyFatCalculator';
import { Stack } from '@mui/material';

const Calculator = () => {
  return (
   <Stack  gap="60px"
   sx={{  flexDirection: { lg: "row" },p: "20px", alignItems: "center",justifyContent:"center" }}>
       <BodyFatCalculator/>
   </Stack>

  )
}

export default Calculator