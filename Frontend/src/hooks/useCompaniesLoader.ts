import { useEffect, useState } from "react";
import type { Company } from "../types/models";
import { fetchCompanies } from "../services/api";

export function useCompaniesLoader() {
  
    const [companies, setCompanies] = useState<Company[]>([]);
    useEffect(() => {
        fetchCompanies()
            .then(setCompanies)
            .catch(console.error);
    }, []);

    return companies;
}
