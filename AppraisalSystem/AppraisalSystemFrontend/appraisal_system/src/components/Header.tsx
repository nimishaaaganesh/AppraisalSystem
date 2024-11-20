'use client'
import { usePathname } from 'next/navigation';
import React from 'react'

const Header = () => {
 
  const pathname = usePathname();;
  const renderMenu = () => {
    if(pathname=='/')
    {
      return 'Menu'; 
    }

    if (pathname.startsWith('/Employee')) {
      return 'Employees';
    }

    if (pathname.startsWith('/performance/')) {
      return 'Performance Factors';
    }

    if (pathname.startsWith('/questions/')) {
      return 'Questions';
    }
  };
  return (
    <header className="w-full  bg-white p-4 flex justify-between items-center shadow">
      <span className="text-lg font-bold ml-4">Menu</span>
      
    </header>
  )
}

export default Header