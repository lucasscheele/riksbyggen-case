# Riksbyggen Fullstack
Arbetsprov åt Riksbyggen, Fullstack lösning i .Net 9, SQL server och React.

### Starta appen
Se först till att docker finns installerat och clona repo.
För att starta navigera till mappen riksbyggen-repo i Command Promt och kör:

```docker-compose up --build -d```

Då startas databas, API och Frontend, frontend nås genom ```http://localhost:3000/```

### API
API körs på port 5000 med översikt och testning av API:er ```http://localhost:5000/scalar/```

För att testa webhook som ändrar slutdatum för kontrakt så krävs en header ```API-KEY: DemoKey```
```
exempel webhook
curl http://localhost:5000/api/ContractsWebhook \
  --request POST \
  --header 'Content-Type: application/json' \
  --header 'API-KEY: DemoKey' \
  --data '{
  "id": 1,
  "contractEndDate": "2025-08-30"
}'
```
### Databas
Databas går att ansluta till via:

Server name: ```localhost,1433``` 

Authentication: ```sql server authentication```

Login: ```sa```

Password: ```DemoPassword123!```


Hör av er vid frågor!
