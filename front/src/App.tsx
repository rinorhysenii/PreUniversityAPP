import React, { Fragment } from 'react';
import logo from './logo.svg';
import Navbar from './Components/Navbar/Navbar';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import LoginPage from './Features/Login/LoginPage';
import TeacherPage from './Features/Teacher/TeacherPage';
import { Container } from 'semantic-ui-react';
import StudentPage from './Features/Students/StudentPage';




function App() {
  return (
    <>
     <Router>
        <Navbar/>
        <Routes>
          <Route path="/" element={<LoginPage/>}/>
          <Route path="/Teacher" element={<TeacherPage/>}/>
          <Route path="/Students" element={<StudentPage/>}/>
        </Routes>

     </Router>
     



    </> 
  );
}

export default  App;

