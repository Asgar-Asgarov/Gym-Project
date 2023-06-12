import React from 'react';
import { Link } from "react-router-dom";
import { AppBar, Toolbar, Typography } from '@mui/material';
import Logo from "../assets/images/Logo.png";

const Header = () => {
  return (
    <AppBar position='static' color='transparent'>
        <Toolbar>
            <Typography variant='h6'>
            <Link to="/">
        <img
          src={Logo}
          alt="logo"
          style={{ width: "48px", height: "48px", margin: "0 20px" }}
        />
      </Link>
            <Link
          to="/"
          style={{
            textDecoration: "none",
            color: "#3A1212",
            borderBottom: "3px solid #FF2625",
          }}
        >
          Home
        </Link>
            </Typography>
        </Toolbar>
    </AppBar>
  )
}

export default Header