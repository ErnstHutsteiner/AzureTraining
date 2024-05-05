# Welcome to our Data Factory Lab

Zeit: 30 min

Die Story:
Ein Verkäufer möchte jede Woche eine aktuelle Liste von Mountainbikes und Rennrädern haben als csv-Datei haben.
Diese Informationen befinden sich in unserer Datenbank in den Tabellen Product und ProductCategory.

Um den Anforderungen unseres Verkäufers gerecht zu werden verwenden wir folgende SQL Abfrage:

   SELECT 
    pc.Name AS Category, 
    p.Name As Product,
    p.Color,
    p.StandardCost,
    p.ListPrice,
    p.Size
    FROM SalesLT.Product p
    INNER JOIN SalesLT.ProductCategory pc
    ON p.ProductCategoryID = pc.ProductCategoryID
    WHERE pc.Name in ('Mountain Bikes', 'Road Bikes')


# Die Aufgabe

1. Erstelle eine Data Factory Pipeline die die Daten aus der obigen Abfrage einmal pro Woche von SQL Server in einen BLOB Storage Container "salesdata" schreibt.

2. (Challange), wenn die Pipeline fehlt schläge, soll ein Alter getriggert werden. Versuche einen Weg zu finden wir das gemacht werden könnte.

