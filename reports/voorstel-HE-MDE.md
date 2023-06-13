# Herexamen Mobile Development

Ik werk voort op mijn reeds bestaande project en zal geen nieuw project starten. Dit omdat mijn project er nog goed voor staat, 
wat ik al uitgewerkt heb, werkt voor het grootste deel en zal geen problemen veroorzaken voor de rest dat nog toegevoegd zal moeten
worden.

## Online strategie

Kruis minstens **1 strategie** aan met

- [X] Online CRUD operaties met eigen REST API
- [ ] Online CRUD operaties met eenBackend Service
- [ ] Online Fetch, Offline CRUD
- [ ] Offline CRUD, Online Push
- [ ] Andere, namelijk: 


## Mobile features

Kruis minstens **4 mobile features** aan:

- [X] Xamarin Essentials
- [ ] Push notifications
- [X] 2D Graphics
- [ ] Authentication en Authorization
- [ ] Native Communication
- [X] Native Speech to Text
- [X] Cross-platform Native Plugin
- [ ] Andere, namelijk: 


## Beschrijving

Naam van de app: Creative Recipes App Platform

Voor deze app moet de gebruiker zich registreren en inloggen. Daarna kan de gebruiker een recept aanmaken. Voor dit recept kan de gebruiker
een foto van het resultaat van het recept tonen, en een lijst van ingedriënten. Daarnaast is er ook een tekstveld voorzien om de bereiding
van dit recept te tonen.

Doel van de app?
Aanmaken en bijhouden van recepten.

Voor wie?
Iedereen die een recept wil delen met andere gebruikers.

Hoe gaat de gebruiker mee aan de slag?
De gebruiker doet het volgende: registreren -> inloggen -> klikken op "new receipt". Hier kan deze dan een foto van het gerecht toevoegen (optioneel),
een lijst van ingedrïenten en een beschrijving van de bereiding (beide verplicht). Ook verplicht is het selecteren van welk soort maaltijd (ontbijt, middag, dessert, etc.)


## Mobile Features
 - Xamarin Essentials:  - Camera: Foto maken
			- Open Browser: om alle aangemaakte recepten te bekijken in een browser

 - Native Speech To Text: Indien de gebruiker liever de bereiding inspreekt dan intypt (want alles via een smartphone typen kan vervelend worden)

Bovenstaande 2 zijn al geïmplementeerd in mijn project, al werkt Speech To Text nog niet correct. Voor het herexamen komen er nog 2 features bij:

 - 2D Graphics: Met SkiaSharp zal ik een intro voorzien voor de app. Deze intro zal te zien zijn elke keer dat de app geopend wordt.

 - Cross-Platform Native Plugin: Een push-notificatie om gebruikers op de hoogte te stellen van een nieuw toegevoegd recept. Hiervoor zou ik Xamarin.Essentials gebruiken voor zowel verzenden als ontvangen.