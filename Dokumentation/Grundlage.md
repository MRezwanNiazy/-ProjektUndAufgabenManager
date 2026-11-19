2. Projektarbeit
Konzeption und prototypische Umsetzung einer Anwendung zur Verwaltung von Projekten und Aufgaben
Mohammad Rezwan Niazy 
 
Grundlagen
	Prüfer:	Prof. Dr.-Ing. N. Jazdi
	Betreuer:	Prof. Dr.-Ing. N. Jazdi
Start: 06.08.2026	Abgabe: 06.11.2026
	
 
 
Dokument Versionsverwaltung

Version
Autor	Datum	Status	Änderungen
0.1	RN	02.09	in Bearb.	Erstellung
1.0	RN	10.09	vorgelegt	
1.0	RN	17.09	Akzeptiert	
	
0	Inhaltsverzeichnis
0	INHALTSVERZEICHNIS	2
1	UMGEBUNGS- UND RANDBEDINGUNGEN	3
2	C#	3
3	XAML	3
4	DATENBANK SQL	3
4.1	Relationales Datenmodell	3
4.2	Kaskadierendes Löschen und Integrität	4

 
1	Umgebungs- und Randbedingungen  
Die Projektarbeit wird im Rahmen meiner Ausbildung durchgeführt und ist auf drei Monate begrenzt. Sie begann am 06.08.2026 und endet am 06.11.2026. 
2	C#
Die Entwicklung der Anwendung erfolgt in C#, der zentralen Programmiersprache des NET-Ökosystems. C# bietet für dieses Projekt eine optimale Grundlage, da es folgende Vorteile vereint: 
•	Vollständige Unterstützung moderner Windows-Desktop-Anwendungen und des MVVM-Architekturmusters. 
•	C# reduziert Eingabefehler bei Termindaten und erleichtert die Validierung. 
•	C# ermöglicht performante Abfragen und eine effiziente Echtzeit-Filterung der Terminliste.  
•	C# erlaubt die automatische JSON-Speicherung im Hintergrund, ohne dass die Benutzeroberfläche blockiert. 
 
3	XAML
Die Gestaltung der Benutzeroberfläche der Anwendung KalenderTermin erfolgt mittels XAML. Die deklarative Beschreibung trennt das UI-Design konsequent von der Programmlogik und bietet für dieses Projekt mehrere Vorteile: 
•	XAML ermöglicht die schnelle und präzise Definition zentraler Steuerelemente wie DataGrid und DatePicker.
•	XAML verbindet die View direkt mit dem ViewModel und sorgt für automatische Aktualisierungen der Benutzeroberfläche.
•	XAML erlaubt visuelle Fehlererkennung unmittelbar am Eingabefeld, ohne zusätzlichen Code-Overhead. 
•	XAML stellt ein einheitliches, wartbares und sauberes Design für die gesamte Anwendung sicher. 

4	Datenbank SQL 
Für die dauerhafte und strukturierte Speicherung der Anwendungsdaten kommt eine relationale SQLite Datenbank zum Einsatz. Die Modellierung und Abfrage der Daten erfolgt über SQL, wird aber durch das Object Relational Mapping von Entity Framework Core abstrahiert. Dadurch lassen sich die Datenbanktabellen direkt über C# Objekte ansprechen, ohne dass SQL Befehle manuell formuliert werden müssen.

4.1	Relationales Datenmodell
Das Datenbankdesign orientiert sich an einer Tabellenstruktur, die die Anwendungslogik direkt widerspiegelt.
•	Kategorien: speichern den Namen und eine eindeutige ID für die jeweiligen Arbeitsbereiche.
•	Projekte: enthalten den Projektnamen, eine Beschreibung, das Erstellungsdatum sowie einen Fremdschlüssel, der auf die zugehörige Kategorie verweist (1:n Beziehung).
•	Aufgaben: speichern Titel, Beschreibung, Status, Priorität, ein optionales Fälligkeitsdatum und einen Fremdschlüssel zum übergeordneten Projekt (ebenfalls 1:n Beziehung).
Damit entsteht ein übersichtliches, logisch strukturiertes Datenmodell, das die Beziehungen zwischen Kategorien, Projekten und Aufgaben klar abbildet.
4.2	Kaskadierendes Löschen und Integrität
Um die referenzielle Integrität sicherzustellen, wird beim Löschen eines Projekts eine kaskadierende Löschweitergabe (ON DELETE CASCADE) verwendet. Dadurch entfernt die SQLite Datenbank automatisch alle zugehörigen Aufgaben, sodass keine verwaisten Datensätze zurückbleiben.
