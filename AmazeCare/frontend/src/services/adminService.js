import axios from 'axios';

const BASE_URL = "https://localhost:7183/api/Admin/admins";

export const getAdmins = async () => {
  try {
    const response = await axios.get(BASE_URL);
    return response.data;
  } catch (error) {
    console.error("Error fetching admins", error);
    throw error;
  }
};

export const createAdmin = async (adminData) => {
  try {
    const response = await axios.post(BASE_URL, adminData);
    return response.data;
  } catch (error) {
    console.error("Error creating admin", error);
    throw error;
  }
};

export const updateAdmin = async (id, adminData) => {
  try {
    const response = await axios.put(`${BASE_URL}/${id}`, adminData);
    return response.data;
  } catch (error) {
    console.error("Error updating admin", error);
    throw error;
  }
};

