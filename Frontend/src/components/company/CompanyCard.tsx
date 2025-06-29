import React from "react";
import type { Company } from "../../types/models";

interface CompanyCardProps {
    company: Company;
    selected: boolean;
    onClick: () => void;
}

export const CompanyCard: React.FC<CompanyCardProps> = (p) => {
    
    return (
        <div onClick={p.onClick}>
            <span>{p.company.name}</span>
        </div>
    );
};