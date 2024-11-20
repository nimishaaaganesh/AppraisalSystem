'use client'; 

import React, { useEffect, useState } from 'react';
import { useParams } from 'next/navigation'; 
import EmployeeForm from '@/components/EmployeeForm';

const EmployeeDetails: React.FC = () => {
  const { employeeId } = useParams(); 
  const [id, setId] = useState<number | null>(null);

  useEffect(() => {
    if (employeeId) {
      setId(Number(employeeId));
    }
  }, [employeeId]); 

  if (id === null) {
    return <div>Loading...</div>; 
  }

  return (
    <div className="main-container w-[1088px] h-[583px] bg-[#25DACB] bg-cover relative overflow-x-hidden">
      <EmployeeForm employeeId={id} /> 
    </div>
  );
};

export default EmployeeDetails;
