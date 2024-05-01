# Welcome to Web Application Lab 1

In diesem Lab wirst Du
* eine Resource Group erstellen
* einen App Service Plan erstellen
* einen App Service erstellen
* eine Web Application lokal ausführen
* eine Web Application deployen
* eine Web Application konfigurieren

Zeit: 45 min

## Resource Group erstellen

Erstelle eine Resource Group mit folgenden Vorgaben:
* <DeinPrefix>apprg
* Region "West Europe"
* Tags: optional

## App Service Plan erstellen
1. suche im Marketplace nach "App Service Plan" von Microsoft
2. Erstelle einen App Service Plan mit folgenden Eigenschaften:
* Resource Group: Deine Resource Group
* Name: <DeinPrefix>appserviceplan
* OS : Windows
* Region: West Europe
* Priciing: Shared D1
* Tags: Optional


## App Service erstellen
1. suche im Marketplace nach "App Service (Web App) von Microsoft
2. erstelle die Web App mit folgenden Eigenschaften
* Resource Group: Deine Ressourcen Gruppe
* Name: <DeinPrefix>appservice
* Publish: Code
* Runtime Stack: .NET 8  (LTS), Windows
* Region: West Europe
* Windows Plan: wählen Deinen zuvor erstellten App Service Plan
3. In den Bereichten Database, Deployment, Networking, Monitoring, => keine Aktion
4. Tags: Optional


## Web Application lokal ausführen
1. Öffne eine command prompt und wechsle in das Verzeichnis des zuvor geladenen Repositories (AzureTraining)
2. gehe in das Unterverzeichnis /BlazorApp
3. starte VS-code mit dem Befehl: `code .`
4. VS-Code ist nun gestartet. Wir führen die Application über das Terminal von VS-Code mit dem Befehl `dotnet watch run` aus
5. Die kleine Web-Applikation wird nun im lokalen Browser angezeigt. Wir sehen sie uns in Ruhe an
6. Jetzt ist auch eine gute Zeit etwas 10 min Pause einzulegen bevor es mit dem nächsten Schritt weiter geht


## Web Application deployen
1. klicke auf das Azure Symbol auf der linke Leiste von VS-Code und melde Dich bei Azure an, sofern noch nicht geschehen
2. öffne dann App Services und suche nach Deinem App Service
3. mit einem rechtsklick auf "Deploy to Web App" kannst Du Deine Applikation deployen. Bestätige einfach den Pfad
4. Wechsle zum Azure Portal, wenn Dein Deployment fertig ist
5. Wähle im Portal Deine App und klicke dort auf "Overview"
6. klicke dort unter "Default domain" auf den Link. Es ist die URL Deiner App. Und läuft Sie, wenn ja, war Dein Deployment erfolgreich

## Web Application konfigurieren
1. Wir befinden uns wieder in VS Code
2. In appsettings.json fügen wir einen weiteren Konfigurationsparameter ein (nach "AllowedHosts"):
`"WelcomeText": "Hallo GFU"`
3. Das müsste jetzt etwa so aussehen:


`  },`
`  "AllowedHosts": "*",`
`  "WelcomeText": "Hallo GFU"`
`}`

4. In Home.razor fügen wir ganz am Beginn folgende Zeile ein:
`@inject IConfiguration _CONFIGURATION`
und ersetzen "Hello World" mit:
`@_CONFIGURATION["WelcomeText"]`

5. Wir starten die Application lokal. Es sollte nun "Hallo Gfu" angezeigt werden.

? Wenn wir jetzt unsere Applikation deployen. Würde diese über das Portal laufen? Nein! den dort fehlt die vorgenommene Konfiguration

6. Wir tragen nun die Konfiguration im App Service ein:
* Portal öffnen
* App Service finden
* dort auf "Environment Variables"
* unter "App Settings" ein neues App Setting eintragen:
- Name: WelcomeText
- Value: Hallo Gfu
* Speichern

7. Wir deployen unsere Web App erneut. Läuft diese wie erwartet?








