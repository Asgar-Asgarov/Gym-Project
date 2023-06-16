import React, { useState } from 'react';
import { Typography,Box,Stack } from '@mui/material';

const BodyFatCalculator = () => {
  const [weight, setWeight] = useState('');
  const [waist, setWaist] = useState('');
  const [neck, setNeck] = useState('');
  const [bodyFatPercentage, setBodyFatPercentage] = useState(0);

  const calculateBodyFatPercentage = () => {

    const bodyFat = (parseInt(waist) + parseInt(neck) - parseInt(weight)) * 100;
    setBodyFatPercentage(bodyFat);
  };

  return (
    <Stack>
      <Typography sx={{color:'#FF2625'}} variant='h4' mb={4}>Body Fat Percentage Calculator</Typography>
      <Stack ml={8}   >
      <div>
        <label>Weight (in kg):</label>
        <input type="number" value={weight} onChange={e => setWeight(e.target.value)} />
      </div>
      <div>
        <label>Waist (in cm):</label>
        <input type="number" value={waist} onChange={e => setWaist(e.target.value)} />
      </div>
      <div>
        <label>Neck (in cm):</label>
        <input type="number" value={neck} onChange={e => setNeck(e.target.value)} />
      </div>
      <button onClick={calculateBodyFatPercentage}>Calculate</button>
      <div>
        <p>Body Fat Percentage: {bodyFatPercentage}%</p>
      </div>
      </Stack>
  
    </Stack>
  );
};

export default BodyFatCalculator;
