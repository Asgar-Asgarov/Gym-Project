import React, { useState } from 'react';

import {
    Typography,
    Table,
    TableBody,
    TableCell,
    TableContainer,
    TableHead,
    TableRow,
    Paper,
    Button,
  } from "@mui/material";

const CalorieCalculator = () => {
  const [weight, setWeight] = useState('');
  const [height, setHeight] = useState('');
  const [age, setAge] = useState('');
  const [gender, setGender] = useState('male');
  const [activityLevel, setActivityLevel] = useState(1.2);
  const [calories, setCalories] = useState(0);

  const calculateCalories = () => {
    // Convert measurements to numbers
    const weightNum = parseFloat(weight);
    const heightNum = parseFloat(height);
    const ageNum = parseFloat(age);

    // Validate input
    if (isNaN(weightNum) || isNaN(heightNum) || isNaN(ageNum)) {
      alert('Please enter valid measurements');
      return;
    }

    // Calculate calorie requirements based on gender, weight, height, age, and activity level
    let calorieResult = 0;
    if (gender === 'male') {
      calorieResult = (10 * weightNum) + (6.25 * heightNum) - (5 * ageNum) + 5;
    } else if (gender === 'female') {
      calorieResult = (10 * weightNum) + (6.25 * heightNum) - (5 * ageNum) - 161;
    }

    const caloriesWithActivity = calorieResult * activityLevel;
    setCalories(caloriesWithActivity.toFixed(2));
  };

  const clearFields = () => {
    setWeight('');
    setHeight('');
    setAge('');
    setGender('male');
    setActivityLevel(1.2);
    setCalories(0);
  };

  return (
    <TableContainer component={Paper}>
    <Table>
      <TableHead>
        <TableRow>
          <TableCell align="center" colSpan={3}>
            <Typography sx={{ color: "#FF2625" }} variant="h5" mb={4}>
            Daily Calorie Requirements Calculator
            </Typography>
          </TableCell>
        </TableRow>
      </TableHead>
      <TableBody>
        <TableRow>
          <TableCell>
            <label>Weight (in kg):</label>
          </TableCell>
          <TableCell align="right">
            {" "}
            <input type="number" value={weight} onChange={(e) => setWeight(e.target.value)} />
          </TableCell>
        </TableRow>
        <TableRow>
          <TableCell>
          <label>Height (in cm):</label>
          </TableCell>
          <TableCell align="right">
            {" "}
            <input type="number" value={height} onChange={(e) => setHeight(e.target.value)} />
          </TableCell>
        </TableRow>
        <TableRow>
          <TableCell>
          <label>Age:</label>
          </TableCell>
          <TableCell align="right">
            {" "}
            <input type="number" value={age} onChange={(e) => setAge(e.target.value)} />
          </TableCell>
        </TableRow>
        <TableRow>
          <TableCell>
          <label>Gender:</label>
          </TableCell>
          <TableCell align="right">
            {" "}
            <select value={gender} onChange={(e) => setGender(e.target.value)}>
          <option value="male">Male</option>
          <option value="female">Female</option>
        </select>
          </TableCell>
        </TableRow>
        <TableRow>
          <TableCell>
          <label>Activity Level:</label>
          </TableCell>
          <TableCell align="right">
            {" "}
            <select value={activityLevel} onChange={(e) => setActivityLevel(parseFloat(e.target.value))}>
          <option value={1.2}>Sedentary (little or no exercise)</option>
          <option value={1.375}>Lightly active (light exercise/sports 1-3 days/week)</option>
          <option value={1.55}>Moderately active (moderate exercise/sports 3-5 days/week)</option>
          <option value={1.725}>Very active (hard exercise/sports 6-7 days/week)</option>
          <option value={1.9}>Extra active (very hard exercise/sports and a physical job)</option>
        </select>
          </TableCell>
        </TableRow>
        <TableRow>
          <TableCell rowSpan={3} />
          <TableCell colSpan={2}>
            {" "}
            <Button
              sx={{
                ml: "21px",
                color: "#fff",
                background: "#fcc757",
                fontSize: "14px",
                borderRadius: "20px",
                textTransform: "capitalize",
              }}
              onClick={calculateCalories}
            >
              Calculate
            </Button>
          </TableCell>
          <TableCell colSpan={2} align="right">
            {" "}
            <Button
              sx={{
                ml: "21px",
                color: "#fff",
                background: "#fcc757",
                fontSize: "14px",
                borderRadius: "20px",
                textTransform: "capitalize",
              }}
              onClick={clearFields}
            >
              Clear
            </Button>
          </TableCell>
        </TableRow>
        <TableRow>
          <TableCell colSpan={2}>Calorie Requirements: </TableCell>
          <TableCell align="right">{calories}</TableCell>
        </TableRow>
      </TableBody>
    </Table>
  </TableContainer>
  );
};

export default CalorieCalculator;
