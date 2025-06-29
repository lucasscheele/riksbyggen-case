import React from "react";
import { CompanyCard } from "./CompanyCard";
import type { Company } from "../../types/models";

interface CompanyListProps {
    companies: Company[];
}

export const CompanyList: React.FC<CompanyListProps> = (p) => (
    <section>
        <h3>Fastighetsbolag</h3>
        {p.companies.map(company => (
            <CompanyCard
                key={company.id}
                company={company}
            />
        ))}
    </section>
);