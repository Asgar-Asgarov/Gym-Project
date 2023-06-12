import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, RouterProvider } from 'react-router-dom';
import App from './App';
import { router } from './router/Routes';


const root = ReactDOM.createRoot(document.getElementById('root'));

root.render(
    <BrowserRouter>
    <RouterProvider router={router}/>
    </BrowserRouter>

);
