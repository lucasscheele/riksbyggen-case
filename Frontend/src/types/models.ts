export type Company = {
  id: number;
  name: string;
};

export type Apartment = {
  id: number;
  companyId: number;
  address: string;
  hasExpiringContract: boolean;
};