import React from "react";
import type { Company } from "../../types/models";
import "../../styles/shared.css";
import "./CompanyCard.css";


interface CompanyCardProps {
    company: Company;
    selected: boolean;
    onClick: () => void;
}

export const CompanyCard: React.FC<CompanyCardProps> = (p) => {
    let styleClass = "card company" 
    if (p.selected) styleClass += " selected"
    
    return (
        <div className={styleClass} onClick={p.onClick}>
            <span>{p.company.name}</span>
        </div>
    );
};