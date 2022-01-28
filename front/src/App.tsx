import React, { Fragment } from 'react';
import logo from './logo.svg';
import Navbar from './Components/Navbar/Navbar';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import LoginPage from './Features/Login/LoginPage';
import { Container } from 'semantic-ui-react';



function App() {
  return (
    <>
     <Router>
        <Navbar/>
        <Routes>
          <Route path="/" element={<LoginPage/>}/>
        </Routes>

     </Router>
     



    </> 
  );
}

export default  App;

