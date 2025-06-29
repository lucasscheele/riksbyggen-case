import type { Company } from "../types/models";

const API_BASE_URL = 'http://localhost:5000/api';

async function fetchData<T>(endpoint: string): Promise<T> {
    const result = await fetch(`${API_BASE_URL}${endpoint}`);
    if (!result.ok) throw new Error(`Failed to fetch from ${endpoint}`);
    return result.json();
}

export async function fetchCompanies(): Promise<Company[]> {
    return fetchData<Company[]>('/company');
}