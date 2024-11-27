import React, { useState, useEffect } from 'react';
import { getPatients, createPatient, updatePatient, deletePatient } from '../services/patientService';

const PatientList = () => {
  const [patients, setPatients] = useState([]);
  const [newPatient, setNewPatient] = useState({
    id: 0,
    name: '',
    age: '',
    gender: '',
    contactInfo: ''
  });
  const [isEdit, setIsEdit] = useState(false);
  const [message, setMessage] = useState('');

  useEffect(() => {
    fetchPatients();
  }, []);

  const fetchPatients = async () => {
    try {
      const data = await getPatients();
      setPatients(data);
    } catch (error) {
      console.error(error);
    }
  };

  const handleCreate = async () => {
    try {
      const data = await createPatient(newPatient);
      setPatients([...patients, data]);
      setNewPatient({ id: 0, name: '', age: '', gender: '', contactInfo: '' });
      setMessage('Patient created successfully');
    } catch (error) {
      setMessage('Failed to create patient');
      console.error(error);
    }
  };

  const handleUpdate = async () => {
    try {
      await updatePatient(newPatient.id, newPatient);
      setPatients(patients.map(patient => (patient.id === newPatient.id ? newPatient : patient)));
      setIsEdit(false);
      setNewPatient({ id: 0, name: '', age: '', gender: '', contactInfo: '' });
      setMessage('Patient updated successfully');
    } catch (error) {
      setMessage('Failed to update patient');
      console.error(error);
    }
  };

  const handleEdit = patient => {
    setNewPatient(patient);
    setIsEdit(true);
  };

  const handleDelete = async id => {
    try {
      await deletePatient(id);
      setPatients(patients.filter(patient => patient.id !== id));
      setMessage('Patient deleted successfully');
    } catch (error) {
      setMessage('Failed to delete patient');
      console.error(error);
    }
  };

  return (
    <div>
      <h1>Patient List</h1>
      <ul>
        {patients.map(patient => (
          <li key={patient.id}>
            {patient.name} - {patient.age} - {patient.gender} - {patient.contactInfo}
            <button onClick={() => handleEdit(patient)}>Edit</button>
            <button onClick={() => handleDelete(patient.id)}>Delete</button>
          </li>
        ))}
      </ul>
      <div>
        <h2>{isEdit ? 'Edit Patient' : 'Add New Patient'}</h2>
        <input
          type="text"
          placeholder="Name"
          value={newPatient.name}
          onChange={e => setNewPatient({ ...newPatient, name: e.target.value })}
        />
        <input
          type="number"
          placeholder="Age"
          value={newPatient.age}
          onChange={e => setNewPatient({ ...newPatient, age: e.target.value })}
        />
        <input
          type="text"
          placeholder="Gender"
          value={newPatient.gender}
          onChange={e => setNewPatient({ ...newPatient, gender: e.target.value })}
        />
        <input
          type="text"
          placeholder="Contact Info"
          value={newPatient.contactInfo}
          onChange={e => setNewPatient({ ...newPatient, contactInfo: e.target.value })}
        />
        <button onClick={isEdit ? handleUpdate : handleCreate}>
          {isEdit ? 'Update' : 'Add'}
        </button>
      </div>
      {message && <p>{message}</p>}
    </div>
  );
};

export default PatientList;
