import axios from 'axios';

const BASE_URL = "https://localhost:7183/api/Prescriptions";

export const getPrescriptions = async () => {
  try {
    const response = await axios.get(BASE_URL);
    return response.data;
  } catch (error) {
    console.error("Error fetching prescriptions", error);
    throw error;
  }
};

export const createPrescription = async (prescriptionData) => {
  try {
    const response = await axios.post(BASE_URL, prescriptionData);
    return response.data;
  } catch (error) {
    console.error("Error creating prescription", error);
    throw error;
  }
};

export const updatePrescription = async (id, prescriptionData) => {
  try {
    const response = await axios.put(`${BASE_URL}/${id}`, prescriptionData);
    return response.data;
  } catch (error) {
    console.error("Error updating prescription", error);
    throw error;
  }
};

export const deletePrescription = async (id) => {
  try {
    await axios.delete(`${BASE_URL}/${id}`);
  } catch (error) {
    console.error("Error deleting prescription", error);
    throw error;
  }
};
