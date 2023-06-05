import React from 'react';
import {Box,Stack,Typography} from '@mui/material';
import Loader from './Loader';

const SimilarExercises = ({targetMuscleExercises,equipmentExercises}) => {
  return (
    <Box sx={{mt:{lg:'100px',xs:'0'}}}>
      <Typography variant="h3">Exercises that target the same muscle group</Typography>
      <Stack></Stack>

    </Box>
  )
}

export default SimilarExercises