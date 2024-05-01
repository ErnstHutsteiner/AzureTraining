# Welcome to Web Application Lab 1

In diesem Lab wirst Du
* einen Resource Group erstellen
* einen App Service Plan erstellen
* einen App Service erstellen
* eine Web Application lokal ausführen
* eine Web Application deployen
* eine Web Application konfigurieren

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
4. VS-Code ist nun gestartet. Wir führen die Application über das Terminal von VS-Code mit dem Befehl 'dotnet watch run' aus
5. Die kleine Web-Applikation wird nun im lokalen Browser angezeigt. Wir sehen sie uns in Ruhe an
6. Jetzt ist auch eine gute Zeit etwas 10 min Pause einzulegen bevor es mit dem nächsten Schritt weiter geht


## Web Application deployen

## Web Application konfigurieren




