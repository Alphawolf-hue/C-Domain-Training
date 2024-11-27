import logo from './logo.svg';
import './App.css';
import React from 'react';
import RegisterForm from './components/RegisterForm';
import LoginForm from './components/LoginForm';
import DoctorList from './components/DoctorList';
import PatientList from './components/PatientList';
import PrescriptionList from './components/PrescriptionList';
import AdminList from './components/AdminList';

function App() {
  return (
    <div className='App'>
      <h1>AmazeCare App</h1>
      <RegisterForm/>
      <LoginForm/>
      <AdminList/>
      <DoctorList/>
      <PatientList/>
      <PrescriptionList/>
    </div>
  );
}

export default App;
