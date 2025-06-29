import React from "react";
import type { Apartment } from "../../types/models";


export const ApartmentCard: React.FC<{ apartment: Apartment }> = ({ apartment }) => {
    let expiringContent = apartment.hasExpiringContract ? " - Kontrakt löper ut inom 3 månader" :"";
    
    return (
        <div>
            <span>{apartment.address}</span>
            <span style={{color: 'red'}}>{expiringContent}</span>
        </div>
    );
};