import React from 'react';
import BodyFatCalculator from '../components/Calculator/BodyFatCalculator';
import BmiCalculator from '../components/Calculator/BmiCalculator';
import CalorieCalculator from '../components/Calculator/CalorieCalculator';

import { Stack } from '@mui/material';

const Calculator = () => {
  return (
   <Stack  gap="60px"
   sx={{  p: "20px", alignItems: "center",justifyContent:"center" ,ml:{xs:1,lg:7}}} margin={7} >
       <BodyFatCalculator/>
       <BmiCalculator/>
       <CalorieCalculator/>     
   
   </Stack>

  )
}

export default Calculator