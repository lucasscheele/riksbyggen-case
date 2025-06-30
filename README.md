# Riksbyggen Fullstack
Arbetsprov åt Riksbyggen, fullstack lösning i .Net 9, SQL server och React.

### Starta appen
Se först till att Docker finns installerat och clona repot.
För att starta, navigera till mappen riksbyggen-repo i terminal och kör:

```docker-compose up --build -d```

Då startas databas, API och Frontend. Frontend nås genom [http://localhost:3000/](http://localhost:3000/).

### API
API körs på port 5000. Översikt och testning av API:er på [http://localhost:5000/scalar/](http://localhost:5000/scalar/)

För att testa [webhook](http://localhost:5000/scalar/#tag/contractswebhook/post/api/ContractsWebhook) som ändrar slutdatum för kontrakt så krävs en header ```API-KEY: DemoKey```. Exempel på webhook:
```
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
Databas går att ansluta till via SQL server:

* Server name: ```localhost,1433``` 

* Authentication: ```sql server authentication```

* Login: ```sa```

* Password: ```DemoPassword123!```


Hör av er vid frågor!
