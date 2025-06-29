import { useCompaniesLoader } from "./hooks/useCompaniesLoader";

import { CompanyList } from "./components/company/CompanyList";


export default function App() {
  const companies = useCompaniesLoader();
  return (
    <CompanyList
        companies={companies}
      />
  );
}