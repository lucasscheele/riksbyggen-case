import { useEffect, useState } from "react";
import type { Apartment } from "../types/models";
import { fetchApartments } from "../services/api";

export function useApartmentsLoader(companyId?: number) {
    
    const [apartments, setApartments] = useState<Apartment[]>([]);

    useEffect(() => {
        if (!companyId) {
            setApartments([]);
            return;
        }

        fetchApartments(companyId)
            .then(setApartments)
            .catch(console.error);
    }, [companyId]);

    return apartments;
}