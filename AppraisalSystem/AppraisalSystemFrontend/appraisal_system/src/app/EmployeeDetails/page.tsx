"use client";
import React, { useState, useEffect } from "react";
import axios from "axios";
import Link from "next/link";
import EmployeeForm from "@/components/EmployeeForm";

interface Employee {
  id: number;
  name: string;
  employeeRole: string;
  systemRole: string;
}

export default function Main() {
  const [employees, setEmployees] = useState<Employee[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [searchTerm, setSearchTerm] = useState("");
  const [selectedEmployeeId, setSelectedEmployeeId] = React.useState<
    number | null
  >(null);

  useEffect(() => {
    axios
      .get("https://localhost:57679/Employees")
      .then((response) => {
        console.log(response.data);

        if (response.data && Array.isArray(response.data.employees)) {
          setEmployees(response.data.employees);
        } else {
          setError("Invalid data format");
        }
        setLoading(false);
      })
      .catch((err) => {
        setError("Error fetching data");
        setLoading(false);
      });
  }, []);

  const filteredEmployees = employees.filter(
    (employee) =>
      employee.name.toLowerCase().includes(searchTerm.toLowerCase()) ||
      employee.id.toString().includes(searchTerm)
  );

  return (
    <div className="main-container w-[1088px] h-[583px] bg-[#25DACB] bg-cover relative overflow-x-hidden">
      <div className="w-[855px] h-[151px] bg-[#1b334f] rounded-[10px] absolute top-[122px] left-[64px] z-[12]">
        <div className="flex w-[779px] h-[38.725px] justify-between items-center relative z-[91] mt-[25px] mr-0 mb-0 ml-[41px]">
          <span className="flex w-[171px] h-[33.248px] justify-center items-start shrink-0 font-['Inter'] text-[20px] font-semibold leading-[24.205px] text-[#fff] relative text-center whitespace-nowrap z-[15]">
            List of Employees
          </span>

          <div className="w-[552px] h-[35px] shrink-0 bg-[#fff] rounded-[10px] relative overflow-hidden z-[91]">
            <input
              type="text"
              className="w-[552px] h-[100%] p-[10px] border-2 border-[#ccc] rounded-[10px] outline-none"
              placeholder="Search by Name or ID"
              value={searchTerm}
              onChange={(e) => setSearchTerm(e.target.value)}
            />
          </div>
        </div>
        <div className="w-[791px] h-px bg-[url(../assets/images/ecfd16c1-9320-44b7-879c-52aeef886e63.png)] bg-cover bg-no-repeat relative z-[18] mt-[7.312px] mr-0 mb-0 ml-[31px]" />

        {loading ? (
          <div>Loading...</div>
        ) : error ? (
          <div>{error}</div>
        ) : (
          <div className="w-[614px] h-[26.321px] relative z-[17] mt-[33.248px] mr-0 mb-0 ml-[106px]">
            <div className="flex w-full justify-between items-center">
              <span className="flex w-[15px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-semibold leading-[19.364px] text-[#fff]">
                Id
              </span>
              <span className="flex w-[65px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-semibold leading-[19.364px] text-[#fff]">
                Name
              </span>
              <span className="flex w-[125px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-semibold leading-[19.364px] text-[#fff]">
                Employee Role
              </span>
              <span className="flex w-[110px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-semibold leading-[19.364px] text-[#fff]">
                System Role
              </span>
            </div>
            {filteredEmployees.length > 0 ? (
              filteredEmployees.map((employee) => (
                <div
                  key={employee.id}
                  className="flex w-[855px] justify-between items-center mt-4 bg-white rounded-lg  shadow-md p-4"
                >
                  <div
                    key={employee.id}
                    className="flex w-full justify-between items-center mt-4"
                  >
                    <span className="flex w-[15px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-normal leading-[19.364px] text-[#000]">
                      {employee.id}
                    </span>
                    <span className="flex w-[65px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-normal leading-[19.364px] text-[#000]">
                      {employee.name}
                    </span>
                    <span className="flex w-[125px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-normal leading-[19.364px] text-[#000]">
                      {employee.employeeRole}
                    </span>
                    <span className="flex w-[110px] h-[26.321px] justify-center items-start font-['Inter'] text-[16px] font-normal leading-[19.364px] text-[#000]">
                      {employee.systemRole || " -- "}
                    </span>
                    <Link href={`/Employee/${employee.id}`}>
                      <img
                        src="/employeedetails.png" 
                        alt={`View ${employee.name}'s Details`}
                        className="cursor-pointer" 
                        style={{ width: "50px", height: "50px" }}
                      />
                    </Link>
                  </div>
                </div>
              ))
            ) : (
              <div>No employees found</div>
            )}
          </div>
        )}
      </div>
    </div>
  );
}
