import React from "react";
import { Link, NavLink } from "react-router-dom";
import {
  AppBar,
  Badge,
  IconButton,
  List,
  ListItem,
  Toolbar,
  Typography,
} from "@mui/material";
import { ShoppingCart } from "@mui/icons-material";
import Logo from "../assets/images/Logo.png";

const midLinks = [
  { title: "shop", path: "/product" },
  { title: "blog", path: "/blog" },
  { title: "calculator", path: "/calculator" },
];

const rightLinks = [
  { title: "login", path: "/login" },
  { title: "register", path: "/register" },
];

const navStyles = {
  "&:hover": {
    borderBottom: "3px solid #FF2625",
  },
  "&.active": {
    borderBottom: "3px solid #FF2625",
  },
  textDecoration: "none"
};

const Header = () => {
  return (
    <AppBar position="static" color="transparent">
      <Toolbar>
        <Typography variant="h6">
          <Link to="/">
            <img
              src={Logo}
              alt="logo"
              style={{ width: "48px", height: "48px", margin: "0 20px" }}
            />
          </Link>
        </Typography>
        <List sx={{ display: "flex" }}>
          {midLinks.map(({ title, path }) => (
            <ListItem
              component={NavLink}
              to={path}
              key={path}
              style={{  color: "#3A1212" }}
              sx={navStyles}
            >
              {title.toUpperCase()}
            </ListItem>
          ))}
        </List>
        <IconButton
          size="large"
          edge="start"
          color="inherit"
          sx={{
            mr: 2,
            "&:hover": {
              borderBottom: "3px solid #FF2625",
            },
            "&.active": {
              borderBottom: "3px solid #FF2625",
            },
          }}
        >
          <Badge badgeContent="4" color="secondary">
            <ShoppingCart />
          </Badge>
        </IconButton>
        <List sx={{ display: "flex" }}>
          {rightLinks.map(({ title, path }) => (
            <ListItem
              component={NavLink}
              to={path}
              key={path}
              style={{
                color: "#3A1212",
              }}
              sx={navStyles}
            >
              {title.toUpperCase()}
            </ListItem>
          ))}
        </List>
      </Toolbar>
    </AppBar>
  );
};

export default Header;
