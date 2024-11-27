import React, { useState, useEffect } from 'react';
import { getAdmins, createAdmin, updateAdmin, deleteAdmin } from '../services/adminService';

const AdminList = () => {
  const [admins, setAdmins] = useState([]);
  const [newAdmin, setNewAdmin] = useState({
    id: 0,
    fullName: '',
    email: ''
  });
  const [isEdit, setIsEdit] = useState(false);
  const [message, setMessage] = useState('');

  useEffect(() => {
    fetchAdmins();
  }, []);

  const fetchAdmins = async () => {
    try {
      const data = await getAdmins();
      setAdmins(data);
    } catch (error) {
      console.error(error);
    }
  };

  const handleCreate = async () => {
    try {
      const data = await createAdmin(newAdmin);
      setAdmins([...admins, data]);
      setNewAdmin({ id: 0, fullName: '', email: '' });
      setMessage('Admin created successfully');
    } catch (error) {
      setMessage('Failed to create admin');
      console.error(error);
    }
  };

  const handleUpdate = async () => {
    try {
      await updateAdmin(newAdmin.id, newAdmin);
      setAdmins(admins.map(admin => (admin.id === newAdmin.id ? newAdmin : admin)));
      setIsEdit(false);
      setNewAdmin({ id: 0, fullName: '', email: '' });
      setMessage('Admin updated successfully');
    } catch (error) {
      setMessage('Failed to update admin');
      console.error(error);
    }
  };

  const handleEdit = admin => {
    setNewAdmin(admin);
    setIsEdit(true);
  };

  return (
    <div>
      <h1>Admin List</h1>
      <ul>
        {admins.map(admin => (
          <li key={admin.id}>
            {admin.fullName} - {admin.email}
            <button onClick={() => handleEdit(admin)}>Edit</button>
            <button onClick={() => handleDelete(admin.id)}>Delete</button>
          </li>
        ))}
      </ul>
      <div>
        <h2>{isEdit ? 'Edit Admin' : 'Add New Admin'}</h2>
        <input
          type="text"
          placeholder="Full Name"
          value={newAdmin.fullName}
          onChange={e => setNewAdmin({ ...newAdmin, fullName: e.target.value })}
        />
        <input
          type="email"
          placeholder="Email"
          value={newAdmin.email}
          onChange={e => setNewAdmin({ ...newAdmin, email: e.target.value })}
        />
        <button onClick={isEdit ? handleUpdate : handleCreate}>
          {isEdit ? 'Update' : 'Add'}
        </button>
      </div>
      {message && <p>{message}</p>}
    </div>
  );
};

export default AdminList;
