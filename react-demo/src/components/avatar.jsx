import React from "react";

function Avatar() {
  return <img src="https://plus.unsplash.com/premium_photo-1731966051195-a1bf3db6487e?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxmZWF0dXJlZC1waG90b3MtZmVlZHwxNXx8fGVufDB8fHx8fA%3D%3D" alt="sample avatar" height={100} width={100} />;
}

export default function Profile() {
  return (
    <>
      <Avatar />
    </>
  );
}
