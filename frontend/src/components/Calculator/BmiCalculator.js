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

const BmiCalculator = () => {
  const [weight, setWeight] = useState('');
  const [height, setHeight] = useState('');
  const [bmi, setBmi] = useState(0);

  const calculateBMI = () => {
    // Convert measurements to numbers
    const weightNum = parseFloat(weight);
    const heightNum = parseFloat(height);

    // Validate input
    if (isNaN(weightNum) || isNaN(heightNum) || heightNum === 0) {
      alert('Please enter valid measurements');
      return;
    }

    // Calculate BMI
    const bmiValue = weightNum / ((heightNum / 100) ** 2);
    setBmi(bmiValue.toFixed(2));
  };

  const clearFields = () => {
    setWeight('');
    setHeight('');
    setBmi(0);
  };

  return (
  <TableContainer component={Paper}>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell align="center" colSpan={3}>
              <Typography sx={{ color: "#FF2625" }} variant="h5" mb={4}>
               Body Mass Index Calculator
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
                onClick={calculateBMI}
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
            <TableCell colSpan={2}>BMI:: </TableCell>
            <TableCell align="right">{bmi}</TableCell>
          </TableRow>
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default BmiCalculator;
