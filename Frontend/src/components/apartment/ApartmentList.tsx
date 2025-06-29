import React from "react";
import { ApartmentCard } from "./ApartmentCard";
import type { Company, Apartment } from "../../types/models";

interface ApartmentListProps {
    company: Company | null;
    apartments: Apartment[];
}

const renderApartments = (apartments: Apartment[]) => (<>
    {apartments.map(apartment => (
        <ApartmentCard
            key={apartment.id}
            apartment={apartment}
        />
    ))}
</>);

export const ApartmentList: React.FC<ApartmentListProps> = (p) => {
    if (!p.company) return null;

    let content = p.apartments.length === 0
        ? <div>Inga lägenheter hittades för {p.company.name}.</div>
        : renderApartments(p.apartments);

    return (
        <section>
            <h3>Lägenheter hos {p.company.name}</h3>
            {content}
        </section>
    );
};