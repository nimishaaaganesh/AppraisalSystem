import Link from "next/link";
export default function Dashboard() {
  return (
    <div className="bg-[#25DACB] bg-cover  relative">
      <p className="text-[#1B334F] text-3xl text-center py-8">
        Welcome Back, Admin
      </p>

      <div className="grid grid-cols-2 gap-8 px-20 py-10">
        <div className="bg-[#1B334F] w-[410px] h-[185px] rounded-3xl shadow-lg relative">
          <div className="w-[100px] h-[100px] bg-[url(../assets/images/b6e626cf-14dd-4f91-a5f4-95b095164e28.png)] bg-cover bg-no-repeat absolute -top-[12.5px] -left-[12.5px]"></div>
          <h3 className="text-white text-3xl font-semibold text-center mt-20">
            Employees
          </h3>
          <button className="bg-[#25DACB] text-black font-semibold py-2 px-6 rounded-md shadow absolute bottom-4 right-4">      
                  <Link href="/Employee">View</Link>
          </button>
        </div>

        <div className="bg-[#1B334F]  w-[410px] h-[185px] rounded-3xl shadow-lg relative">
          <div className="w-[100px] h-[100px] bg-[url(../assets/images/2a7fcaec-b6fd-4a88-baec-794c2e1113ed.png)] bg-cover bg-no-repeat absolute -top-[12.5px] -left-[12.5px]"></div>
          <h3 className="text-white text-3xl font-semibold text-center mt-20">
            Performance<br/> Factor
          </h3>
          <button className="bg-[#25DACB] text-black font-semibold py-2 px-6 rounded-md shadow absolute mt-6 bottom-4 right-4">
            View
          </button>
        </div>

        <div className="bg-[#1B334F]  w-[410px] h-[185px] rounded-3xl shadow-lg relative">
          <div className="w-[100px] h-[100px] bg-[url(../assets/images/d4c6f8cb-1c6f-4521-aa04-dec9761b569b.png)] bg-cover bg-no-repeat absolute -top-[12.5px] -left-[12.5px]"></div>
        <h3 className="text-white text-3xl font-semibold text-center mt-20">
            Questions
          </h3>
          <button className="bg-[#25DACB] text-black font-semibold py-2 px-6 rounded-md shadow absolute  mt-6 bottom-4 right-4">
            View
          </button>
        </div>

        <div className="bg-[#1B334F] w-[410px] h-[185px] rounded-3xl shadow-lg relative">
          <div className="w-[100px] h-[100px] bg-[url(../assets/images/d4c6f8cb-1c6f-4521-aa04-dec9761b569b.png)] bg-cover bg-no-repeat absolute -top-[12.5px] -left-[12.5px]"></div>
          <h3 className="text-white text-3xl font-semibold text-center mt-20">
            Settings
          </h3>
          <button className="bg-[#25DACB] text-black font-semibold py-2 px-6 rounded-md shadow absolute  mt-6 bottom-4 right-4">
            View
          </button>
        </div>
      </div>
    </div>
  );
}
