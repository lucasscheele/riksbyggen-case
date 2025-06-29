import { useEffect, useState } from 'react';

export default function App() {
  const apiBaseUrl = 'http://localhost:5000/api';
  const [companies, setCompanies] = useState<{ id: number; name: string }[]>([]);

  useEffect(() => {
    fetch(`${apiBaseUrl}/company`)
      .then(r => r.json())
      .then(data => setCompanies(data))
      .catch(() => setCompanies([]));
  }, []);

  return (
    <ul>
      {companies.map(c => (
        <li key={c.id}>{c.name}</li>
      ))}
    </ul>
  );
}