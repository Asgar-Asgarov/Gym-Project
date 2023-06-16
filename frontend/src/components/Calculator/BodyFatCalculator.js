import React, { useState } from "react";
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

const BodyFatCalculator = () => {
  const [weight, setWeight] = useState("");
  const [waist, setWaist] = useState("");
  const [neck, setNeck] = useState("");
  const [hip, setHip] = useState("");
  const [gender, setGender] = useState("male");
  const [bodyFatPercentage, setBodyFatPercentage] = useState(0);

  const calculateBodyFatPercentage = () => {
    // Convert measurements to numbers
    const weightNum = parseFloat(weight);
    const waistNum = parseFloat(waist);
    const neckNum = parseFloat(neck);
    const hipNum = parseFloat(hip);

    // Validate input
    if (isNaN(weightNum) || isNaN(waistNum) || isNaN(neckNum)) {
      alert("Please enter valid measurements");
      return;
    }

    // Calculate body fat percentage based on the U.S. Navy body fat formula
    let bodyFat = 0;
    if (gender === "male") {
      bodyFat =
        86.01 * Math.log10(waistNum - neckNum) -
        70.041 * Math.log10(weightNum) +
        36.76;
    } else if (gender === "female") {
      bodyFat =
        163.205 * Math.log10(waistNum + hipNum - neckNum) -
        97.684 * Math.log10(weightNum) -
        78.387;
    }

    setBodyFatPercentage(bodyFat.toFixed(2));
  };

  const clearFields = () => {
    setWeight("");
    setWaist("");
    setNeck("");
    setHip("");
    setGender("male");
    setBodyFatPercentage(0);
  };

  return (
    <TableContainer component={Paper}>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell align="center" colSpan={3}>
              <Typography sx={{ color: "#FF2625" }} variant="h5" mb={4}>
                Body Fat Percentage Calculator
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
              <input
                type="number"
                value={weight}
                onChange={(e) => setWeight(e.target.value)}
              />
            </TableCell>
          </TableRow>
          <TableRow>
            <TableCell>
              <label>Waist (in cm):</label>
            </TableCell>
            <TableCell align="right">
              {" "}
              <input
                type="number"
                value={waist}
                onChange={(e) => setWaist(e.target.value)}
              />
            </TableCell>
          </TableRow>
          <TableRow>
            <TableCell>
              <label>Neck (in cm):</label>
            </TableCell>
            <TableCell align="right">
              {" "}
              <input
                type="number"
                value={neck}
                onChange={(e) => setNeck(e.target.value)}
              />
            </TableCell>
          </TableRow>
          <TableRow>
            <TableCell>
              <label>Hip (in cm):</label>
            </TableCell>
            <TableCell align="right">
              {" "}
              <input
                type="number"
                value={hip}
                onChange={(e) => setHip(e.target.value)}
              />
            </TableCell>
          </TableRow>
          <TableRow>
            <TableCell>
              <label>Gender:</label>
            </TableCell>
            <TableCell align="right">
              {" "}
              <select
                value={gender}
                onChange={(e) => setGender(e.target.value)}
              >
                <option value="male">Male</option>
                <option value="female">Female</option>
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
                onClick={calculateBodyFatPercentage}
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
            <TableCell colSpan={2}>Body Fat Percentage: </TableCell>
            <TableCell align="right">{bodyFatPercentage}%</TableCell>
          </TableRow>
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default BodyFatCalculator;
