'use client'; // Ensure this is a client-side component

import React, { useEffect, useState } from 'react';
import { useParams } from 'next/navigation'; // Use useParams from next/navigation
import EmployeeForm from '@/components/EmployeeForm';

const EmployeeDetails: React.FC = () => {
  const { employeeId } = useParams(); // Using useParams to access the dynamic route parameter
  const [id, setId] = useState<number | null>(null);

  useEffect(() => {
    if (employeeId) {
      setId(Number(employeeId));
    }
  }, [employeeId]); // Effect depends on employeeId

  if (id === null) {
    return <div>Loading...</div>; // Render loading state while employeeId is not available
  }

  return (
    <div className="bg-[#25DACB] bg-cover h-screen relative">
      <EmployeeForm employeeId={id} /> {/* Pass employeeId to the form */}
    </div>
  );
};

export default EmployeeDetails;
