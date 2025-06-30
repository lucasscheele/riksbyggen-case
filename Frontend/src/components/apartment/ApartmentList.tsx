import React from "react";
import { ApartmentCard } from "./ApartmentCard";
import type { Company, Apartment } from "../../types/models";
import "../../styles/shared.css";

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
        <section className="contentList">
            <h2>Lägenheter hos {p.company.name}</h2>
            {content}
        </section>
    );
};