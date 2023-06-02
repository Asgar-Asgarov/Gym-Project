import React from 'react';
import {Link} from 'react-router-dom';
import {Button,Stack,Typography} from '@mui/material';

const ExerciseCard = ({exercise}) => {
  return (
    <Link className="exercise-card" to={`/exercise/${exercise.id}`}>
        <img src={exercise.gifUrl} alt={exercise.name} 
        Loading="lazy"
        />
    </Link>
  )
}

export default ExerciseCard