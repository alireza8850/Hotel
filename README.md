# Hotel
Jag har byggt ett hotelhanteringssystem som uppfyller alla krav från uppgiften. Systemet hanterar rum, gäster och statusar genom 
filbaserad lagring. Jag började med att skapa alla klass filer och lägga upp grundstrukturen. I RoomStatus.cs definierade jag en enum med 
tre tillstånd Empty, Occupied och Unavailable. I Room.cs skapade jag en datamodel med tre properties för rumnummer, status och gästnamn. 
När grundstrukturen var klar började jag att implementera första menyvalet i program.cs och metoden showoccupiedroom i Reception klassen.
 Jag valde att använda while loop för att gå genom alla rum eftersom det var lätt att förstå och felsöka. Sedan forsatte jag med att 
 implementera de övriga menyvalen på samma sätt. 
Jag valde att använda textfiler för datalagring. I FileData klassen lade jag till två metoder AllRooms för att ladda rum från fil och 
SaveRooms för att spara rum till fil. AllRoom metoden kollar först om filen finns, om den inte gör det så skapar den en ny fil med 10 
tomma rum. SaveRooms metoden skriver om hela filen varje gång något ändras. Jag tycker att det här sättet är lätt att förstå. 
När jag skulle använda TryParse metoden visste jag tillexempel att jag behövde omvandla string till int men min kod fungerade inte och 
det var för att jag missade int framför. Jag lärde mig nu hur jag ska använda den för jag annväde TryParse metoden många gånger i min kod 
och nu sitter den fast. 
