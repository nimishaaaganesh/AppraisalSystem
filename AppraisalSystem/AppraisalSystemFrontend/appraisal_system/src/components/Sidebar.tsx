import Link from "next/link";
import React from "react";

const Sidebar = () => {
  return (
    <div>
      <nav className=" bg-[#1b334f] w-64 h-screen top-0 left-0 ">
        <ul className="space-y-8 text-white p-8">
          <li>
            <div className="flex space-x-8 bottom-4">
              <img
                src="/images/profilehead.png"
                alt="alternative"
                style={{ width: "20px", height: "20px" }}
              />
              <p>Admin</p>
            </div>
          </li>
          <li>
          <Link href='/'>
            <div className="flex space-x-8  ">
              <img
                src="/images/menu.png"
                alt="alternative"
                style={{ width: "16px", height: "16px" }}
              />
              <p>Menu</p>
            </div>
          </Link>
          </li>
          <li>
            <Link href='/Employee'>
            <div className="flex space-x-8">
              <img
                src="/images/empoyee.png"
                alt="alternative"
                style={{ width: "16px", height: "16px" }}
              />
              <p>Employee</p>
            </div>
            </Link>
          </li>
          <li>
            <div className="flex space-x-8">
              <img
                src="/images/performanvefactor.png"
                alt="alternative"
                style={{ width: "16px", height: "16px" }}
              />
              <p>Performance Factor</p>
            </div>
          </li>
          <li>
            <div className="flex space-x-8">
              <img
                src="/images/Question.png"
                alt="alternative"
                style={{ width: "16px", height: "16px" }}
              />
              <p>Question</p>
            </div>
          </li>
        </ul>
      </nav>
    </div>
  );
};

export default Sidebar;
