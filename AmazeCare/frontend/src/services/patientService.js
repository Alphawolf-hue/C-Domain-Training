import axios from 'axios';

const BASE_URL = "https://localhost:7183/api/Patients";

export const getPatients = async () => {
  try {
    const response = await axios.get(BASE_URL);
    return response.data;
  } catch (error) {
    console.error("Error fetching patients", error);
    throw error;
  }
};

export const createPatient = async (patientData) => {
  try {
    const response = await axios.post(BASE_URL, patientData);
    return response.data;
  } catch (error) {
    console.error("Error creating patient", error);
    throw error;
  }
};

export const updatePatient = async (id, patientData) => {
  try {
    const response = await axios.put(`${BASE_URL}/${id}`, patientData);
    return response.data;
  } catch (error) {
    console.error("Error updating patient", error);
    throw error;
  }
};

export const deletePatient = async (id) => {
  try {
    await axios.delete(`${BASE_URL}/${id}`);
  } catch (error) {
    console.error("Error deleting patient", error);
    throw error;
  }
};
