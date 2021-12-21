# FollowerService
Run het commando `docker-compose up --build` voor development in de main map.

Daarna heb je toegang tot de swagger pagina met deze url: http://localhost:5000/swagger/index.html.

## Swagger endpoints

### /api/Follower/online

Dit endpoint is gemaakt om te testen of de service aanspreekbaar is. 

Code 200 (Ok): Returned een string met "Follower service is online".

### /api/Follower/followuser

Dit endpoint is het endpoint om een gebruiker te volgen. De body van dit request moet het ID van de ingelogde gebruiker bevatten en het ID van de gebruiker die gevolgd gaat worden. De body moet zijn geschreven is JSON.

Code 201 (Created):  Request is succesvol afgehandeld. 

Code 500 (Internal Server Error): Er is iets fout gegaan bij het verwerken van de request.

### /api/Follower/followsdg

Dit endpoint is het endpoint om een SDG te volgen. De body van dit request moet het ID van de ingelogde gebruiker bevatten en het ID van de SDG die gevolgd gaat worden. De body moet zijn geschreven is JSON.

Code 201 (Created):  Request is succesvol afgehandeld. 

Code 500 (Internal Server Error): Er is iets fout gegaan bij het verwerken van de request.

### /api/Follower/unfollowuser

Dit endpoint is het endpoint om een gebruiker te ontvolgen. De body van dit request moet het ID van de ingelogde gebruiker bevatten en het ID van de gebruiker die ontvolgd gaat worden. De body moet zijn geschreven is JSON.

Code 200 (OK):  Request is succesvol afgehandeld. 

Code 500 (Internal Server Error): Er is iets fout gegaan bij het verwerken van de request.
