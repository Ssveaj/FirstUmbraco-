# FirstUmbraco-


Mål i kursplanen som denna uppgift täcker:

    • **Sätta upp ett nytt Umbraco-projekt**
    
    • **Sätta upp ett nytt Umbraco CMS-projekt**
    
    • **Versionhantering med Git**
    
    • Utveckla de komponenter som behövs av CMS:et
    
    • Analysera och implementera avancerade webblösningar med Umbraco CMS

Inlämningsuppgift 2:
    • Uttöka det projekt du redan skapat eller starta upp ett nytt Umbraco-projekt
    • Använda dig utav Document Types, Data Types, Templates, Plugins, Controllers, ViewModels
    • Valfritt att versionshantera med Git/Github

Bedömningsnivå för G:
    • Använt dig av Document Types, Data Types, Templates, Plugins, Controllers, ViewModels för att bygga din hemsida.

Bedömingsnivå för VG:
    • Målen för G
    • Har utforskat och använt saker som inte har lärts ut under föreläsningar
    • Applikationen är användarvänlig

Uppgift:
Du ska använda dig utav standard databasen (CE som kommer med en .sdf fil). Inlämningen sker via pingpong och där vill jag se att du har med databasen i zip/rar filen. 
Har du gjort allting rätt så är det bara att zippa ditt projekt så kommer databasen med. Ni måste alltså inte ge mig någon github länk denna gången. 

Vill du absolut göra något annat än det som står här under så får du göra det, men jag vill att du tar med samma eller liknande funktionalitet.
Du får använda dig utav exempel templates för din design. Du ska alltså inte behöva spendera tid på att designa om du absolut inte vill det.
Skapa en hemsida i Umbraco där det ska finnas med ett master template och ett template för varje sida du skapar. 

Templates för sidor ska ligga under och använda sig av master templaten. 
Du ska ha med en root node (Homepage). Alla noder som ligger under denna ska även kräva att du loggar in som en medlem för att kunna visa innehållet på din hemsida.

En kontakta oss sida som innehåller ett kontaktformulär som du skapat med hjälp av en Controller och en ViewModel. (Optional) Vill du snygga till det så kan du 
även ta med en karta som visar vart ditt kontor ligger, till exempel.

En produkt sida ska också finnas, med olika typer av produkter.
Jag vill att din document type för produkt items innehåller en media picker som tillåter dig att välja en bild för din produkt. 
Du ska sedan med hjälp utav ditt template för denna sida skriva kod för att visa upp bilden/bilderna som hör till produkten/produkterna.

En login sida där du ska kunna logga in om du är medlem. Den här behöver du också skapa genom att skapa din egen Controller med en ViewModel. 
Man behöver också ha valet att gå till registreringen från denna sida. Detta ifall man inte är medlem redan.
En sida där man ska kunna registrera sig som medlem. 
Den här kan du skapa med hjälp av ett Partial View template där du får med allt som behövs för att man ska kunna registrera sig. 
