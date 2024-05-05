# Welcome to our Storage Account Lab

In diesem Lab wirst Du
* Azure Storage Explorer downloaden
* einen Azure Storage Account erstellen
* Container im BLOB Bereich erstellen
* Einen SAS Token generieren
* Dich mit Azure Storage Manager verbinden
* Daten hochladen

Zeit: 45 min

## Azure Storage Explorer downloaden

* download von: https://azure.microsoft.com/de-de/products/storage/storage-explorer
* bitte das Tool auf Deiner VM installieren

## Azure Storage Account erstellen
* öffne das Azure Portal und wähle "+ create a resource"
* suche nach "Storage Account" und wähle dort den Microsoft Azure Storage Account (akutell ein grünes Icon mit Grid)
* klick auf "create"
* treffe nun folgende Auswahlen
- Resource Group = Deine Resource Group
- Storageaccount Name : <DeinPrefix>gfustorage
- Region : West Europe
- Performance: Standard
- Redundancy : LRS (wir wollen schliesslich Geld sparen)
* keine Anpassungen in Advanced, Networking, Data protection, Encrpytion - gehe die einzelnen Segmente aber gerne durch, um die möglichen Settings zu entdecken und ggf. zu erforschen
* Tags sind optional
* Review + Create

## Blob Container erstellen
* öffne Deinen Storage Account im Azure Portal und prüfe unter "Overview" ob sich Deine Settings dort widerspiegeln
* wechsle nun in den Bereich Data Storage -> Containers
* klick auf "+ Container"
* vergebe den Namen "transfer"
* erstelle den Container
* der Container müsste jetzt im Blob Bereich sichtbar sein
* öffne nun den Container
* wähle "Shared Access Tokens" auf der linken Seite und erstelle einen read-only token mit "list" Berechtigung, der einen Tag gültig ist (wir werden diesen Token nun verwenden)

## Dich mit Azure Storage Manager verbinden
1. Teil 1
* öffne die Applikation Storage Explorer in Deiner VM
* klicke auf Connect und wähle danach "Blobcontainer"
* wähle nun die Optione SAS-URL
* klicke auf "weiter" vergebe einen Anzeigenamen und kopiere den zuvor generierten Token in das vorgesehene Feld
* klicke auf weiter und dann auf Verbinden
* Dein Container müsste jetzt angezeigt werden

2. Teil 2
* im Storage Explorer wählen wir wieder "Connect" aus
* danach wählen wir "Abonnement" (Subscription) aus
* wähle die Option "Azure" klicke auf weiter
* verwende nun Deine Entra ID Credentials
* Du wirst nun alle anderen Storage Accounts sehen und ausser den Blobs auch Table, Queue und File

## Dateien hochladen
* öffne nun Deinen Container mit der Verbindung die über die Entra ID gemacht wurde
* lade eine beliebige Datei hoch
* verifiziere über das Portal, ob diese dort auch sichtbar ist
* versuche desweiteren einen Download der Datei
* gehen up- und download auch über das Portal? Probier's aus






