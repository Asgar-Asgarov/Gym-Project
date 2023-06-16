import React from "react";
import { Route, Routes } from "react-router-dom";
import { Box, CssBaseline } from "@mui/material";

import "./App.css";
import Home from "./pages/Home";
import Calculator from "./pages/Calculator";
import ExerciseDetail from "./pages/ExerciseDetail";
import Header from "./components/Header";
import Footer from "./components/Footer";
import Blog from "./pages/Blog";
import BlogDetail from "./pages/BlogDetail";
import Product from "./pages/Product";
import ProductDetail from "./pages/ProductDetail"

const App = () => {
  return (
    <Box width="400px" sx={{ width: { xl: "1488px" } }} m="auto">
      <CssBaseline/>
      <Header />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/exercise/:id" element={<ExerciseDetail />} />
        <Route path='calculator' element={<Calculator/>} />
        <Route path='blog' element={<Blog/>} />
        <Route path='blogdetail' element={<BlogDetail/>} />
        <Route path='product' element={<Product/>} />
        <Route path='catalog/:id' element={<ProductDetail/>} />
      </Routes>
      <Footer />
    </Box>
  );
};

export default App;
