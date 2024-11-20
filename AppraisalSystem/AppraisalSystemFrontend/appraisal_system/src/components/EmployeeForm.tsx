'use client';
import React, { useEffect, useState } from 'react';
import axios from 'axios';

// Define the type for employee data
interface EmployeeData {
  id: number;
  name: string;
  employeeRole: string;
  employeeLevel: string;
  dateOfJoining: string;
  email: string;
  phoneNumber: string;
  address: string;
}

interface EmployeeFormProps {
  employeeId: number;
}

const EmployeeForm: React.FC<EmployeeFormProps> = ({ employeeId }) => {
  const [employeeData, setEmployeeData] = useState<EmployeeData | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchEmployeeDetails = async () => {
      try {
        setLoading(true);
        const response = await axios.get<EmployeeData>(`https://localhost:57679/Employees/${employeeId}`);
        setEmployeeData(response.data);
      } catch (err) {
        setError('Failed to fetch employee details. Please try again later.');
      } finally {
        setLoading(false);
      }
    };

    fetchEmployeeDetails();
  }, [employeeId]);

  if (loading) return <div className="text-center text-lg">Loading...</div>;

  if (error) return <div className="text-center text-red-600">{error}</div>;

  // Reusable component for displaying a field
  const EmployeeField = ({ label, value, customClass }: { label: string; value: string | number | undefined; customClass?: string }) => (
    <div className={`flex flex-col mb-4 w-full sm:w-3/4 md:w-1/2 lg:w-1/3 ${customClass}`}>
      <span className="font-semibold text-sm mb-2 text-gray-700">{label}</span>
      <div className={`h-[50px] ${customClass} bg-white rounded-lg flex items-center pl-4 shadow-sm`}>
        <span className="text-gray-900 text-sm">{value || 'Loading...'}</span>
      </div>
    </div>
  );

  return (
    <div className="flex flex-col p-6  items-center justify-center">
      {/* Header */}
      <button className="bg-[#1b334f] rounded-lg border-none mx-auto block mb-8">
        <span className="text-white text-2xl font-semibold">{employeeData?.name}</span>
      </button>

      {/* Employee Details */}
      <div className="flex flex-col sm:flex-row sm:flex-wrap gap-6 w-full justify-center items-center">
        <EmployeeField label="Employee ID" value={employeeData?.id} />
        <EmployeeField label="Employee Role" value={employeeData?.employeeRole} />
        <EmployeeField label="Employee Level" value={employeeData?.employeeLevel} />
        <EmployeeField label="Joining Date" value={employeeData?.dateOfJoining} />
        <EmployeeField label="Email" value={employeeData?.email} />
        <EmployeeField label="Phone Number" value={employeeData?.phoneNumber} />
        <EmployeeField label="Address" value={employeeData?.address} customClass="h-[130px]"/>
        <EmployeeField label="Additional Info" value="N/A" />
      </div>
    </div>
  );
};

export default EmployeeForm;
