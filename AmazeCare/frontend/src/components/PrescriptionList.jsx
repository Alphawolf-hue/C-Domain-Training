import React, { useState, useEffect } from 'react';
import { getPrescriptions, createPrescription, updatePrescription, deletePrescription } from '../services/prescriptionService';

const PrescriptionList = () => {
  const [prescriptions, setPrescriptions] = useState([]);
  const [newPrescription, setNewPrescription] = useState({
    id: 0,
    patientId: '',
    appointmentId: '',
    medications: ''
  });
  const [isEdit, setIsEdit] = useState(false);
  const [message, setMessage] = useState('');

  useEffect(() => {
    fetchPrescriptions();
  }, []);

  const fetchPrescriptions = async () => {
    try {
      const data = await getPrescriptions();
      setPrescriptions(data);
    } catch (error) {
      console.error(error);
    }
  };

  const handleCreate = async () => {
    try {
      const data = await createPrescription(newPrescription);
      setPrescriptions([...prescriptions, data]);
      setNewPrescription({ id: 0, patientId: '', appointmentId: '', medications: '' });
      setMessage('Prescription created successfully');
    } catch (error) {
      setMessage('Failed to create prescription');
      console.error(error);
    }
  };

  const handleUpdate = async () => {
    try {
      await updatePrescription(newPrescription.id, newPrescription);
      setPrescriptions(prescriptions.map(prescription => (prescription.id === newPrescription.id ? newPrescription : prescription)));
      setIsEdit(false);
      setNewPrescription({ id: 0, patientId: '', appointmentId: '', medications: '' });
      setMessage('Prescription updated successfully');
    } catch (error) {
      setMessage('Failed to update prescription');
      console.error(error);
    }
  };

  const handleEdit = prescription => {
    setNewPrescription(prescription);
    setIsEdit(true);
  };

  const handleDelete = async id => {
    try {
      await deletePrescription(id);
      setPrescriptions(prescriptions.filter(prescription => prescription.id !== id));
      setMessage('Prescription deleted successfully');
    } catch (error) {
      setMessage('Failed to delete prescription');
      console.error(error);
    }
  };

  return (
    <div>
      <h1>Prescription List</h1>
      <ul>
        {prescriptions.map(prescription => (
          <li key={prescription.id}>
            {prescription.patientId} - {prescription.appointmentId} - {prescription.medications}
            <button onClick={() => handleEdit(prescription)}>Edit</button>
            <button onClick={() => handleDelete(prescription.id)}>Delete</button>
          </li>
        ))}
      </ul>
      <div>
        <h2>{isEdit ? 'Edit Prescription' : 'Add New Prescription'}</h2>
        <input
          type="text"
          placeholder="Patient ID"
          value={newPrescription.patientId}
          onChange={e => setNewPrescription({ ...newPrescription, patientId: e.target.value })}
        />
        <input
          type="text"
          placeholder="Appointment ID"
          value={newPrescription.appointmentId}
          onChange={e => setNewPrescription({ ...newPrescription, appointmentId: e.target.value })}
        />
        <input
          type="text"
          placeholder="Medications"
          value={newPrescription.medications}
          onChange={e => setNewPrescription({ ...newPrescription, medications: e.target.value })}
        />
        <button onClick={isEdit ? handleUpdate : handleCreate}>
          {isEdit ? 'Update' : 'Add'}
        </button>
      </div>
      {message && <p>{message}</p>}
    </div>
  );
};

export default PrescriptionList;
