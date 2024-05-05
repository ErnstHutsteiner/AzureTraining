# Welcome to our Storage Account Lab

In diesem Lab wirst Du
* Azure Data Studio downloaden und installieren
* eine logische Azure SQL Instanz erstellen
* eine Azure Datenbank erstellen
* die erstellten Resource inspizieren


Zeit: 45 min

## Azure Data Studio downloaden

* download von: https://azure.microsoft.com/de-de/products/data-studio
* bitte das Tool auf Deiner VM installieren


## Azure SQL Server erstellen
den brauchen wir als Instanz
* öffne das Azure Portal und wähle "+ create a resource"
* suche nach "Azure SQL Server" und wähle dort  Microsoft SQL Database
* clicke "create"
* Trage unter Basics nun folgendes ein:
- Resource Group: Deine Resource Group
- Server Name: <DeinPrefix>gfusqlserver
- location: West Europe
- Authentication: Use both, SQL and Entra
- Set Entra Admin : das wird unser Entra Account
- Server Admin login: Name: sqladmin  Password: Pa$$w0rd
* Networking: keine Änderung
* Security: keine Änderung
* Additional Settings: keine Änderung
* Create


## Azure SQL Database erstellen
* öffne das Azure Portal und wähle "+ create a resource"
* suche nach "Azure SQL Database" und wähle dort SQL Server (logical server)
* clicke "create"
* Trage unter Basics nun folgendes ein:
- Resource Group: Deine Resource Group
- Database Name: adventure
- Server: "wähle hier Deinen zuvor erstellten Server
- location: West Europe
- elastic pool: no
- environment: Development
- Compute + storage: DTU based, Basic 2GB
- backup storage redundancy : LRS
* Networking:
- akutell keine Anpassung
* Security:
- keine Anpassung
* Additional Settings:
- Use Existing Data: Sample (AdventureWorksLT)
- Tags: Optional
- Create

## Inspektion der Ressourcen

Wir sehen uns zunächst den erstellten Server an.
In der Overview finden wir (ausser den üblichen Infos) den Serveradmin, den Entra Admin, den vollständigen Servernamen.

Unter SQL Database finden wir unsere Datenbank gelistet (hoffentlich)

In Backups steht u.U. schon ein Backup. Hier hätten wir die Möglichkeit eines Restore


Unter Networking finden wir Einstellungen zum Netzwerk. Hier ist vor allem Spannend der Public Network Access. Dieser sollte aktuell nicht möglich sein.




