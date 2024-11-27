import React, { useState, useEffect } from 'react';
import { getDoctors, createDoctor, updateDoctor, deleteDoctor } from '../services/doctorService';

const DoctorList = () => {
  const [doctors, setDoctors] = useState([]);
  const [newDoctor, setNewDoctor] = useState({
    id: 0,
    name: '',
    specialization: '',
    email: ''
  });
  const [isEdit, setIsEdit] = useState(false);
  const [message, setMessage] = useState('');

  useEffect(() => {
    fetchDoctors();
  }, []);

  const fetchDoctors = async () => {
    try {
      const data = await getDoctors();
      setDoctors(data);
    } catch (error) {
      console.error(error);
    }
  };

  const handleCreate = async () => {
    try {
      const data = await createDoctor(newDoctor);
      setDoctors([...doctors, data]);
      setNewDoctor({ id: 0, name: '', specialization: '', email: '' });
      setMessage('Doctor created successfully');
    } catch (error) {
      setMessage('Failed to create doctor');
      console.error(error);
    }
  };

  const handleUpdate = async () => {
    try {
      await updateDoctor(newDoctor.id, newDoctor);
      setDoctors(doctors.map(doctor => (doctor.id === newDoctor.id ? newDoctor : doctor)));
      setIsEdit(false);
      setNewDoctor({ id: 0, name: '', specialization: '', email: '' });
      setMessage('Doctor updated successfully');
    } catch (error) {
      setMessage('Failed to update doctor');
      console.error(error);
    }
  };

  const handleEdit = doctor => {
    setNewDoctor(doctor);
    setIsEdit(true);
  };

  const handleDelete = async id => {
    try {
      await deleteDoctor(id);
      setDoctors(doctors.filter(doctor => doctor.id !== id));
      setMessage('Doctor deleted successfully');
    } catch (error) {
      setMessage('Failed to delete doctor');
      console.error(error);
    }
  };

  return (
    <div>
      <h1>Doctor List</h1>
      <ul>
        {doctors.map(doctor => (
          <li key={doctor.id}>
            {doctor.name} - {doctor.specialization} - {doctor.email}
            <button onClick={() => handleEdit(doctor)}>Edit</button>
            <button onClick={() => handleDelete(doctor.id)}>Delete</button>
          </li>
        ))}
      </ul>
      <div>
        <h2>{isEdit ? 'Edit Doctor' : 'Add New Doctor'}</h2>
        <input
          type="text"
          placeholder="Name"
          value={newDoctor.name}
          onChange={e => setNewDoctor({ ...newDoctor, name: e.target.value })}
        />
        <input
          type="text"
          placeholder="Specialization"
          value={newDoctor.specialization}
          onChange={e => setNewDoctor({ ...newDoctor, specialization: e.target.value })}
        />
        <input
          type="email"
          placeholder="Email"
          value={newDoctor.email}
          onChange={e => setNewDoctor({ ...newDoctor, email: e.target.value })}
        />
        <button onClick={isEdit ? handleUpdate : handleCreate}>
          {isEdit ? 'Update' : 'Add'}
        </button>
      </div>
      {message && <p>{message}</p>}
    </div>
  );
};

export default DoctorList;
