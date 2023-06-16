import React from 'react';
import BodyFatCalculator from '../components/Calculator/BodyFatCalculator';
import BmiCalculator from '../components/Calculator/BmiCalculator';

import { Stack } from '@mui/material';

const Calculator = () => {
  return (
   <Stack  gap="60px"
   sx={{  p: "20px", alignItems: "center",justifyContent:"center" }} margin={5}>
       <BodyFatCalculator/>
       <BmiCalculator/>
       
   
   </Stack>

  )
}

export default Calculator