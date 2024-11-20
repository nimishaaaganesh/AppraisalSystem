'use client'
import React, { useEffect, useState } from 'react';
import axios from 'axios';

const EmployeeForm = ({ employeeId }: { employeeId: number }) => {
  const [employeeData, setEmployeeData] = useState<any>(null);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchEmployeeDetails = async () => {
      try {
        const response = await axios.get(`https://localhost:57679/Employees/${employeeId}`);
        console.log(response)
        setEmployeeData(response.data);
      } catch (error) {
        setError('Failed to fetch employee details');
      } finally {
        setLoading(false);
      }
    };

    fetchEmployeeDetails();
  }, [employeeId]);

  if (loading) {
    return <div>Loading...</div>;
  }

  if (error) {
    return <div>{error}</div>;
  }

  return (
    <>
 <div className="relative max-w-[1200px] mx-auto p-4 space-x-3">
  <button className='w-[370px] h-[62px] bg-[#1b334f] rounded-[10px] border-none absolute top-[30px] left-[50%] transform -translate-x-1/2 z-[14] pointer'>
    <span className="flex w-[329px] h-[43px] justify-center items-start font-['Inter'] text-[32px] font-semibold leading-[38.727px] text-[#fff] absolute top-[11px] left-[23px] text-center whitespace-nowrap z-[22]">
      {employeeData.name}
    </span>
  </button>

  <div className="absolute top-[150px] left-[60%] transform -translate-x-1/2 w-full z-[5]">
    <div className="grid grid-cols-1 sm:grid-cols-2 gap-6">
      <div className="flex flex-col">
        <span className="font-['Inter'] text-[16px] font-semibold leading-[19px] text-[#000] mb-2">
          Employee Id
        </span>
        <div className="w-3/4 h-[50px] bg-[#fff] rounded-[10px] flex justify-start items-center pl-4 z-[16]">
          <span className="font-['Inter'] text-[16px] font-normal leading-[19px] text-[#000]">
            {employeeData?.id || 'Loading...'}
          </span>
        </div>
      </div>

      <div className="flex flex-col">
        <span className="font-['Inter'] text-[16px] font-semibold leading-[19px] text-[#000] mb-2">
          Employee Role
        </span>
        <div className="w-3/4 h-[50px] bg-[#fff] rounded-[10px] flex justify-start items-center pl-4 z-[15]">
          <span className="font-['Inter'] text-[16px] font-normal leading-[19px] text-[#000]">
            {employeeData?.employeeRole || 'Loading...'}
          </span>
        </div>
      </div>

      <div className="flex flex-col">
        <span className="font-['Inter'] text-[16px] font-semibold leading-[19px] text-[#000] mb-2">
          Employee Level
        </span>
        <div className="w-3/4  h-[50px] bg-[#fff] rounded-[10px] flex justify-start items-center pl-4 z-[16]">
          <span className="font-['Inter'] text-[16px] font-normal leading-[19px] text-[#000]">
            {employeeData?.employeeLevel || 'Loading...'}
          </span>
        </div>
      </div>

      <div className="flex flex-col">
        <span className="font-['Inter'] text-[16px] font-semibold leading-[19px] text-[#000] mb-2">
          Joining Date
        </span>
        <div className="w-3/4 h-[50px] bg-[#fff] rounded-[10px] flex justify-start items-center pl-4 z-[16]">
          <span className="font-['Inter'] text-[16px] font-normal leading-[19px] text-[#000]">
            {employeeData?.dateOfJoining || 'Loading...'}
          </span>
        </div>
      </div>

      <div className="flex flex-col">
        <span className="font-['Inter'] text-[16px] font-semibold leading-[19px] text-[#000] mb-2">
          Email
        </span>
        <div className="w-3/4  h-[50px] bg-[#fff] rounded-[10px] flex justify-start items-center pl-4 z-[16]">
          <span className="font-['Inter'] text-[16px] font-normal leading-[19px] text-[#000]">
            {employeeData?.email || 'Loading...'}
          </span>
        </div>
      </div>

      <div className="flex flex-col">
        <span className="font-['Inter'] text-[16px] font-semibold leading-[19px] text-[#000] mb-2">
          Phone Number
        </span>
        <div className="w-3/4  h-[50px] bg-[#fff] rounded-[10px] flex justify-start items-center pl-4 z-[15]">
          <span className="font-['Inter'] text-[16px] font-normal leading-[19px] text-[#000]">
            {employeeData?.phoneNumber || 'Loading...'}
          </span>
        </div>
      </div>
      <div className="flex flex-col col-span-2">
            <span className="font-['Inter'] text-[16px] font-semibold leading-[19px] text-[#000] mb-2">
              Address
            </span>
            <div className="w-5/6 h-[50px] bg-[#fff] rounded-[10px] flex justify-start items-center pl-4 z-[16]">
              <span className="font-['Inter'] text-[16px] font-normal leading-[19px] text-[#000]">
                {employeeData?.address || 'Loading...'}
              </span>
            </div>
          </div>

    </div>
  </div>
</div>

    </>
  );
};

export default EmployeeForm;
