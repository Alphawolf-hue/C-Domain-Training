import React, { useState, useEffect } from 'react';
import {
  getEmployees,
  createEmployee,
  updateEmployee,
  deleteEmployee,
} from '../Services/EmployeeService';

const Employee = () => {
  const [employees, setEmployees] = useState([]);
  const [newEmployee, setNewEmployee] = useState({
    id: 0,
    name: '',
    gender: '',
    designation: '',
    email: '',
    salary: '',
    departmentId: '',
  });

  const [isEdit, setIsEdit] = useState(false);
  const [errors, setErrors] = useState({ name: '', gender: '', designation: '', email: '', salary: '', departmentId: '' });

  useEffect(() => {
    fetchEmployees();
  }, []);

  const fetchEmployees = async () => {
    try {
      const data = await getEmployees();
      setEmployees(data);
    } catch (error) {
      console.error(error);
    }
  };

  const validateForm = () => {
    let formErrors = {};
    if (!newEmployee.name) formErrors.name = 'Name is required.';
    if (!newEmployee.gender) formErrors.gender = 'Gender is required.';
    if (!newEmployee.designation) formErrors.designation = 'Designation is required.';
    if (!newEmployee.email) formErrors.email = 'Email is required.';
    if (!newEmployee.salary) formErrors.salary = 'Salary is required.';
    if (!newEmployee.departmentId) formErrors.departmentId = 'Department ID is required.';
    setErrors(formErrors);
    return Object.keys(formErrors).length === 0;
  };

  const handleCreate = async () => {
    if (!validateForm()) return;

    try {
      const data = await createEmployee(newEmployee);
      await fetchEmployees();
      setNewEmployee({ id: 0, name: '', gender: '', designation: '', email: '', salary: '', departmentId: '' });
    } catch (error) {
      console.error(error);
    }
  };

  const handleUpdate = async () => {
    if (!validateForm()) return;

    try {
      await updateEmployee(newEmployee.id, newEmployee);
      setEmployees(
        employees.map((emp) =>
          emp.id === newEmployee.id ? newEmployee : emp
        )
      );
      setIsEdit(false);
      setNewEmployee({ id: 0, name: '', gender: '', designation: '', email: '', salary: '', departmentId: '' });
    } catch (error) {
      console.error(error);
    }
  };

  const handleEdit = (employee) => {
    setNewEmployee(employee);
    setIsEdit(true);
  };

  const handleDelete = async (id) => {
    try {
      await deleteEmployee(id);
      setEmployees(employees.filter((emp) => emp.id !== id));
    } catch (error) {
      console.error(error);
    }
  };

  return (
    <>
      <div>
        <h1>Employees</h1>
        <ul>
          {employees.map((employee) => (
            <li key={employee.employeeId}>
              {employee.name} - {employee.designation}
              <button onClick={() => handleEdit(employee)}>Edit</button>
              <button onClick={() => handleDelete(employee.employeeId)}>Delete</button>
            </li>
          ))}
        </ul>
        <div>
          <h2>{isEdit ? 'Edit Employee' : 'Add New Employee'}</h2>
          <input
            type="text"
            placeholder="Name"
            value={newEmployee.name}
            onChange={(e) =>
              setNewEmployee({ ...newEmployee, name: e.target.value })
            }
          />
          {errors.name && <span style={{ color: 'Red' }}>{errors.name}</span>}
          <input
            type="text"
            placeholder="Gender"
            value={newEmployee.gender}
            onChange={(e) =>
              setNewEmployee({ ...newEmployee, gender: e.target.value })
            }
          />
          {errors.gender && <span style={{ color: 'Red' }}>{errors.gender}</span>}
          <input
            type="text"
            placeholder="Designation"
            value={newEmployee.designation}
            onChange={(e) =>
              setNewEmployee({ ...newEmployee, designation: e.target.value })
            }
          />
          {errors.designation && <span style={{ color: 'Red' }}>{errors.designation}</span>}
          <input
            type="email"
            placeholder="Email"
            value={newEmployee.email}
            onChange={(e) =>
              setNewEmployee({ ...newEmployee, email: e.target.value })
            }
          />
          {errors.email && <span style={{ color: 'Red' }}>{errors.email}</span>}
          <input
            type="text"
            placeholder="Salary"
            value={newEmployee.salary}
            onChange={(e) =>
              setNewEmployee({ ...newEmployee, salary: e.target.value })
            }
          />
          {errors.salary && <span style={{ color: 'Red' }}>{errors.salary}</span>}
          <input
            type="text"
            placeholder="Department ID"
            value={newEmployee.departmentId}
            onChange={(e) =>
              setNewEmployee({ ...newEmployee, departmentId: e.target.value })
            }
          />
          {errors.departmentId && <span style={{ color: 'Red' }}>{errors.departmentId}</span>}
          <button onClick={isEdit ? handleUpdate : handleCreate}>
            {isEdit ? 'Update' : 'Add'}
          </button>
        </div>
      </div>
    </>
  );
};

export default Employee;
