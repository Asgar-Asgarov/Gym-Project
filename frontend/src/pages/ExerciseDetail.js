import React,{useEffect, useState} from 'react';
import { useParams } from 'react-router-dom';
import {Box}  from '@mui/material';

import Detail from '../components/Detail';
import ExerciseVideos from '../components/ExerciseVideos';
import SimilarExercises from '../components/SimilarExercises';

import {exerciseOptions,fetchData} from '../utils/fetchData';

const ExerciseDetail = () => {
  return (
  <Box>
    <Detail/>
    <ExerciseVideos/>
    <SimilarExercises/>
  </Box>
  )
}

export default ExerciseDetail