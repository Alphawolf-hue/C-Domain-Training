import axios from 'axios';

const BASE_URL = "https://localhost:7183/api/Auth/login";

export const loginUser = async (loginData) => {
  try {
    const response = await axios.post(`${BASE_URL}/login`, loginData);
    return response.data;
  } catch (error) {
    console.error("Error logging in user", error);
    throw error;
  }
};
