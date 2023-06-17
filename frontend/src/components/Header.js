import  React,{useState} from 'react';
import { Link, NavLink } from "react-router-dom";
import {AppBar,Box,Badge,CssBaseline,Divider,Drawer,List,ListItem,ListItemButton,ListItemText,Toolbar,Typography,Button}  from '@mui/material';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import { ShoppingCart } from "@mui/icons-material";
import Logo from "../assets/images/Logo.png";

const midLinks = [
    { title: "home", path: "/" },
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

const drawerWidth = 240;
const navItems = ['Home', 'About', 'Contact'];

function DrawerAppBar(props) {
  const { window } = props;
  const [mobileOpen, setMobileOpen] = useState(false);

  const handleDrawerToggle = () => {
    setMobileOpen((prevState) => !prevState);
  };

  const drawer = (
    <Box onClick={handleDrawerToggle} sx={{ textAlign: 'center' }}>
      <Typography variant="h6" sx={{ my: 2 }}>
      <Link to="/">
            <img
              src={Logo}
              alt="logo"
              style={{ width: "48px", height: "48px", margin: "0 20px" }}
            />
          </Link>
      </Typography>
      <Divider />
      <List>
        {midLinks.map(({ title, path }) => (
          <ListItem               
          component={NavLink}
          to={path}
          key={path}
          style={{  color: "#3A1212" }}
          sx={navStyles} disablePadding>
            <ListItemButton sx={{ textAlign: 'center' }}>
              <ListItemText primary={title} />
            </ListItemButton>
          </ListItem>
        ))}
      </List>
    </Box>
  );

  const container = window !== undefined ? () => window().document.body : undefined;

  return (
    <Box sx={{ display: 'flex' }}>
      <CssBaseline />
      <AppBar component="nav" color="transparent" position="static" >
        <Toolbar>
          <IconButton          
            aria-label="open drawer"
            edge="start"
            onClick={handleDrawerToggle}
            sx={{ mr: 2, display: { sm: 'none' } }}
          >
            <MenuIcon />
          </IconButton>
          <Typography
            variant="h6"
            component="div"
            sx={{ flexGrow: 1, display: { xs: 'none', sm: 'block' } }}
          >
                 <Link to="/">
            <img
              src={Logo}
              alt="logo"
              style={{ width: "48px", height: "48px", margin: "0 20px" }}
            />
          </Link>
          </Typography>
          <Box sx={{ display: { xs: 'none', sm: 'block' },mr:40 }}>
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
          </Box>
          <Box display="flex" alignItems="center">
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
      </Box>
        </Toolbar>
      </AppBar>
      <Box component="nav">
        <Drawer
          container={container}
          variant="temporary"
          open={mobileOpen}
          onClose={handleDrawerToggle}
          ModalProps={{
            keepMounted: true, // Better open performance on mobile.
          }}
          sx={{
            display: { xs: 'block', sm: 'none' },
            '& .MuiDrawer-paper': { boxSizing: 'border-box', width: drawerWidth },
          }}
        >
          {drawer}
        </Drawer>
      </Box>
      
    </Box>
  );
}



export default DrawerAppBar;