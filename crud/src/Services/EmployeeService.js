import axios from 'axios';

const BASE_URL = "https://localhost:7135/api/Employees";

export const getEmployees = async () => {
  try {
    const response = await axios.get(BASE_URL);
    return response.data;
  } catch (error) {
    console.error("Error fetching employees", error);
    throw error;
  }
};

export const createEmployee = async (employee) => {
  try {
    const response = await axios.post(BASE_URL, employee);
    return response.data;
  } catch (error) {
    console.error("Error creating employee", error);
    throw error;
  }
};

export const updateEmployee = async (id, employee) => {
  try {
    const response = await axios.put(`${BASE_URL}/${id}`, employee);
    return response.data;
  } catch (error) {
    console.error("Error updating employee", error);
    throw error;
  }
};

export const deleteEmployee = async (id) => {
  try {
    await axios.delete(`${BASE_URL}/${id}`);
  } catch (error) {
    console.error("Error deleting employee", error);
    throw error;
  }
};
