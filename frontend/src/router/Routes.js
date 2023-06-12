import {CreateBrowserRouter, createBrowserRouter} from 'react-router-dom';
import App from '../App'
import Home from '../pages/Home';
import ExerciseDetail from '../pages/ExerciseDetail';
import Calculator from '../pages/Calculator';
import Blog from '../pages/Blog';
import BlogDetail from '../pages/BlogDetail';



export const router = createBrowserRouter([
{
    path:'/',
    element: <App/>,
    children: [
        {path: '',element:<Home/>},
        {path: 'exercisedetail',element:<ExerciseDetail/>},
        {path: 'calculator',element:<Calculator/>},
        {path: 'blog',element:<Blog/>},
        {path: 'blogdetail',element:<BlogDetail/>},

    ]
}

])