import { useEffect, useState } from "react";
import type { Apartment } from "../types/models";
import { fetchApartments, fetchApartmentsWithExpiringContracts } from "../services/api";

export function useApartmentsLoader(companyId?: number) {
    const [apartments, setApartments] = useState<Apartment[]>([]);

     useEffect(() => {
        if (!companyId) {
            setApartments([]);
            return;
        }

        const loadData = async () => {
            try {
                const [allApartments, expiringApartments] = await Promise.all([
                    fetchApartments(companyId),
                    fetchApartmentsWithExpiringContracts(companyId),
                ]);

                const expiringIds = new Set(expiringApartments.map(a => a.id));

                const flaggedApartments = allApartments.map(apartment => ({
                    ...apartment,
                    hasExpiringContract: expiringIds.has(apartment.id),
                }));

                setApartments(flaggedApartments);
            } catch (error) {
                console.error(error);
            }
        };

        loadData();

    }, [companyId]);


    return apartments;
}