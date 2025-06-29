import React from "react";
import type { Company } from "../../types/models";

interface CompanyCardProps {
    company: Company;
}

export const CompanyCard: React.FC<CompanyCardProps> = (p) => {
    
    return (
        <div>
            <span>{p.company.name}</span>
        </div>
    );
};