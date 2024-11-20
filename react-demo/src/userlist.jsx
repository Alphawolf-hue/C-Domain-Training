import React from "react";
const users = [
  { id: 1, name: "Vijay Karthik", age: 14 },
  { id: 2, name: "Thiyaneshwar", age: 24 },
  { id: 3, name: "Suyash", age: 18 },
  { id: 4, name: "Yash", age: 23 },
];

export default function UserList() {
  return (
    <>
      <div id="firstDiv">UserList First Div</div>
      <div>
        <table border="1px">
          <thead>
            <tr>
              <th>ID</th>
              <th>Name</th>
              <th>Age</th>
            </tr>
          </thead>
          <tbody>
            {users.map((user) => (
              <tr key={user.id}>
                <td>{user.id}</td>
                <td>{user.name}</td>
                <td>{user.age}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
}