import axios from 'axios';

const BASE_URL = "https://localhost:7183/api/Doctors";

export const getDoctors = async () => {
  try {
    const response = await axios.get(BASE_URL);
    return response.data;
  } catch (error) {
    console.error("Error fetching doctors", error);
    throw error;
  }
};

export const createDoctor = async (doctorData) => {
  try {
    const response = await axios.post(BASE_URL, doctorData);
    return response.data;
  } catch (error) {
    console.error("Error creating doctor", error);
    throw error;
  }
};

export const updateDoctor = async (id, doctorData) => {
  try {
    const response = await axios.put(`${BASE_URL}/${id}`, doctorData);
    return response.data;
  } catch (error) {
    console.error("Error updating doctor", error);
    throw error;
  }
};

export const deleteDoctor = async (id) => {
  try {
    await axios.delete(`${BASE_URL}/${id}`);
  } catch (error) {
    console.error("Error deleting doctor", error);
    throw error;
  }
};
