import { useState } from "react";
import { useCompaniesLoader } from "./hooks/useCompaniesLoader";
import { useApartmentsLoader } from "./hooks/useApartmentsLoader";
import type { Company } from "./types/models";
import { CompanyList } from "./components/company/CompanyList";
import { ApartmentList } from "./components/apartment/ApartmentList";
import "./App.css";

export default function App() {
  const companies = useCompaniesLoader();
  const [selectedCompany, setSelectedCompany] = useState<Company | null>(null);
  const apartments = useApartmentsLoader(selectedCompany?.id);
  

  return (
    <div className="appContainer">
      <CompanyList
        companies={companies}
        selectedId={selectedCompany?.id}
        onSelect={setSelectedCompany}
      />
      <ApartmentList
        apartments={apartments}
        company={selectedCompany}
      />
    </div>
    
  );
}
