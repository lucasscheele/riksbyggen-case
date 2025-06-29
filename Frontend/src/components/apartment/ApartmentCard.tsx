import React from "react";
import type { Apartment } from "../../types/models";

export const ApartmentCard: React.FC<{ apartment: Apartment }> = ({ apartment }) => {

    return (
        <div>{apartment.address}</div>
    );
};