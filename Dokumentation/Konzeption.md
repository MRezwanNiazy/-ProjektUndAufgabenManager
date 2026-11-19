2. Projektarbeit
Konzeption und prototypische Umsetzung einer Anwendung zur Verwaltung von Projekten und Aufgaben
Mohammad Rezwan Niazy 
 
Konzeption
	Prüfer:	Prof. Dr.-Ing. N. Jazdi
	Betreuer:	Prof. Dr.-Ing. N. Jazdi
Start: 06.08.2026	Abgabe: 06.11.2026
	
 
 
Dokument Versionsverwaltung

Version
Autor	Datum	Status	Änderungen
0.1	RN	02.09.	in Bearb.	Erstellung
1.0	RN	10.09	vorgelegt	
1.0	RN	17.09	Akzeptiert	


0	Inhaltsverzeichnis
0	INHALTSVERZEICHNIS	2
1	BESCHREIBUNG DER KONZEPTION	3
1.1	Zielsetzung und Vision	3
1.2	Funktionen	3
1.3	Logischer Ablauf	3
2	DIE PROGRAMMSTRUKTUR	4
2.1	Modulübersicht	4
2.2	Präzises Datenmodell	5
2.3	Speziallogiken und Fehlerbehandlung	8
3	ZUSAMMENFASSUNG	9
 
1	Beschreibung der Konzeption
In diesem Abschnitt wird die eigentliche Konzeption dargestellt. 
1.1	Zielsetzung und Vision
Ziel des Projekts ist es, ein leistungsfähiger, lokal ausgeführter Desktop Anwendung zu entwickeln, die die Verwaltung von Projekten und Aufgaben spürbar erleichtert. Die Vision dahinter: Nutzerinnen und Nutzern ein übersichtliches, fokussiertes Werkzeug bereitzustellen, das ohne komplexe Cloud Dienste oder Registrierungsprozesse auskommt.
1.2	Funktionen     
Die Anwendung stellt eine zentrale Palette an Kernfunktionen für die strukturierte Verwaltung von Kategorien, Projekten und Aufgaben bereit:
•	Kategorisierung: Das System ermöglicht das Anlegen, Bearbeiten und Löschen frei definierbarer Kategorien, die zusätzlich über Filteroptionen eingegrenzt werden können. Bevor eine Kategorie gelöscht wird, prüft die Anwendung, ob ihr noch Projekte zugeordnet sind. Diese Validierung verhindert, dass inkonsistente oder verwaiste Daten entstehen.
•	Projektverwaltung: Erfassen neuer Projekte mit automatisch gesetztem Erstellungsdatum sowie einer prozentualen Fortschrittsanzeige über ein ProgressBar Element.
•	Aufgabensteuerung: Anlegen von Aufgaben mit Priorität, Status und Fälligkeitsdatum; überfällige Aufgaben werden visuell hervorgehoben.
•	Dashboard & Suche:  Zentrale Anzeige wichtiger Kennzahlen auf der Startseite sowie Volltextsuche und Sortierfunktionen für eine schnelle Navigation.
Damit bildet die Anwendung alle wesentlichen Schritte der Projekt- und Aufgabenorganisation ab - von der Strukturierung über die Planung bis hin zur täglichen Steuerung.
1.3	Logischer Ablauf
Der logische Ablauf der Anwendung folgt einer klar strukturierten Hierarchie:
•	Initialisierung: Beim Start der Anwendung stellt das System über Entity Framework Core die Verbindung zur lokalen SQLite Datenbank her und lädt die relevanten Kennzahlen für das Dashboard.
•	Kategorie  und Projektauswahl: Nutzerinnen und Nutzer wählen eine Kategorie oder filtern die Projektliste. Sobald ein Projekt ausgewählt wird, lädt das System automatisch die dazugehörigen Aufgaben.
•	Aufgabenbearbeitung: Beim Erstellen, Bearbeiten oder Abschließen einer Aufgabe berechnet die Geschäftslogik den Projektfortschritt neu. Über Data Binding wird die Benutzeroberfläche sofort aktualisiert, sodass Änderungen direkt sichtbar sind.
•	Löschoperationen: Wird ein Projekt gelöscht, sorgt die kaskadierende Löschlogik der Datenbank dafür, dass alle verknüpften Aufgaben automatisch und konsistent entfernt werden.
Damit ergibt sich ein nachvollziehbarer, sauber definierter Ablauf, der die Interaktion zwischen Benutzeroberfläche, Geschäftslogik und Datenbank klar strukturiert.
2	Die Programmstruktur 
Die Architektur der Anwendung folgt dem Model View ViewModel Muster (MVVM), um Datenmodell, Geschäftslogik und Benutzeroberfläche sauber voneinander zu trennen. Durch diese modulare Struktur bleibt das System gut wartbar, leicht testbar und problemlos erweiterbar.

VIEW (UI)
(MainWindow, Views, controls, XAML, WPF)

            DATA Bindung                                                          User Commands


VIEWMODEL
(MainViewModel, ProjectViewModel, RelayComands)

                Notifications                                                           Updates / Calls                                                     
                    (INotify) 

MODEL
(Katagorie, Projekt, Aufgabe)

                                       EF Core ORM 


MySQL Datenhaltung 
(MySQL-Server / Database)


2.1	Modulübersicht
Die Quellcode Struktur der Anwendung ist in mehrere logisch getrennten Module und Schichten gegliedert:
•	Models: enthalten die zentralen Datenmodelle Kategorie, Projekt und Aufgabe als C# Klassen. Sie bilden die Datenstruktur ab und tragen die notwendigen Annotationen für das Object Relational Mapping mit Entity Framework Core.
•	Views: bilden die grafische Oberfläche auf Basis von WPF und XAML. Dazu gehören das MainWindow, das Dashboard sowie Dialoge zum Erfassen und Bearbeiten von Kategorien, Projekten und Aufgaben.
•	ViewModels: stellen die Präsentationslogik bereit und verbinden die Views mit den Models. Sie verwalten den UI Zustand, verarbeiten Benutzereingaben über ICommand bzw. RelayCommand und liefern aufbereitete Daten für das Data Binding.
•	Data / DataAccess: umfasst den AppDbContext, die Migrationsdateien sowie die Repository  und Datenzugriffslogiken für die lokale SQLite Datenbank.
•	Services / Common: stellt allgemeine Hilfsfunktionen bereit, darunter den Navigationsservice, Dialog Services, Wertkonverter (Value Converter für WPF) und die Implementierung von INotifyPropertyChanged.
Diese modulare Struktur sorgt dafür, dass die Anwendung übersichtlich bleibt, gut wartbar ist und sich problemlos erweitern lässt.
2.2	Präzises Datenmodell 
Das relationale Datenbankmodell stützt sich auf die drei zentralen Entitäten Kategorie, Projekt und Aufgabe. In der Datenhaltungs-Schicht werden die dazugehörigen Attribute, Datentypen, Primär  und Fremdschlüssel, Pflichtfelder sowie alle Integritätsregeln umgesetzt, die für eine konsistente und nachvollziehbare Datenstruktur notwendig sind.

Entität	Attribute	Datentyp	Schlüssel / Constraint	Pflichtfeld	Beschreibung / Validierung
Kategorie	Id	INT	Primary Key (Auto-Inc)	Ja	Eindeutige Kennung.
	Name	VARCHAR (100)	Unique	Ja	Name der Kategorie. Darf nicht leer sein.
Projekt	Id	INT	Primary Key (Auto-Inc)	Ja	Eindeutige Kennung.
	KategorieId	INT	Foreign Key (Kategorie.Id)	Ja	Zuordnung zur Kategorie (1:n). Validierung beim Löschen der Kategorie.
	Name	VARCHAR (150)	-	Ja	Projektbezeichnung.
	Beschreibung	TEXT	-	Nein	Optionale Detailbeschreibung.
	Erstellungsdatum	DATETIME	-	Ja	Automatisch auf den aktuellen Zeitstempel gesetzt.
Aufgabe	Id	INT	Primary Key (Auto-Inc)	Ja	Eindeutige Kennung.
	ProjektId	INT	Foreign Key (Projekt.Id)	Ja	Zuordnung zum Projekt ($1:n$).
	Titel	VARCHAR (200)	-	Ja	Aufgabenbezeichnung.
	Status	VARCHAR (50)	-	Ja	Werte: Offen, In Bearbeitung, Erledigt.
	Priorität	INT	-	Ja	Werte: 1 (Niedrig), 2 (Mittel), 3 (Hoch).
	Fälligkeitsdatum	DATETIME	-	Nein	Optionales Ziel-Datum zur Fristenüberwachung.
Die Kardinalitäten sowie die Lösch  und Validierungsregeln sind wie folgt definiert:
•	Kategorie - Projekt (1:n) : Eine Kategorie kann mehrere Projekte enthalten. Löschregel: Restrict / Validierung:  Eine Kategorie darf erst gelöscht werden, wenn ihr keine Projekte mehr zugeordnet sind. Ist dies nicht der Fall, erhält die Nutzerin bzw. der Nutzer eine entsprechende Validierungsmeldung in der Oberfläche.
•	Projekt - Aufgabe (1:n) — Ein Projekt kann mehrere Aufgaben umfassen. Löschregel: Cascade (ON DELETE CASCADE): Wird ein Projekt gelöscht, entfernt die Datenbank automatisch alle verknüpften Aufgaben vollständig und konsistent.
Diese Regeln stellen sicher, dass die Datenbank sowohl strukturell korrekt bleibt als auch ein erwartbares Verhalten bei Löschoperationen zeigt.

2.3	Speziallogiken und Fehlerbehandlung
1.	Definition von Sonderfällen & Fortschrittsberechnung:

Die Fortschrittslogik berücksichtigt definierte Sonderfälle und folgt einer klaren Berechnungsregel:
•	Projekt ohne Aufgaben: Hat ein Projekt noch keine Aufgaben, wird sein Fortschritt automatisch auf 0 % gesetzt. Dadurch bleibt die Darstellung konsistent und nachvollziehbar.
•	Formel für den Projektfortschritt: In die Berechnung fließen ausschließlich Aufgaben ein, deren Status exakt „Erledigt“ lautet.

Projektfortschritt (%) = (Anzahl erledigter Aufgaben) / (Gesamtanzahl Aufgaben des Projekts) *100

•	Gesamtfortschritt im Dashboard: Der Gesamtwert wird als gewichteter Mittelwert über alle im System vorhandenen Aufgaben berechnet. Das heißt:

Gesamtfortschritt= (Summe aller erledigten Aufgaben) / (Summe aller Aufgaben im System) *100
Dadurch entsteht ein unverfälschtes Gesamtbild, das unabhängig von der         Größe einzelner Projekte bleibt.
2.	Fehlerbehandlung und Systemverhalten (Robustheit)

•	Datenbank kann nicht geöffnet werden: Das System fängt die Verbindungsausnahme (DbUpdateException / MySqlException) ab, verhindert den Anwendungsabsturz und zeigt dem Nutzer einen Dialog mit Hinweis auf die fehlende Serververbindung an.
•	Speicherung schlägt fehl: Schlägt ein SaveChanges() fehl (z. B. durch Constraint-Verletzung), wird die Transaktion abgebrochen (Rollback), die UI-Eingabe bleibt für den Nutzer zur Korrektur erhalten und eine Fehlermeldung wird ausgegeben.
•	Gleichzeitige / Zwischenzeitliche Datenänderung: Über Optimistic Concurrency Control (Nebenläufigkeitsprüfung via EF Core) wird erkannt, wenn ein Datensatz parallel verändert wurde. Dem Nutzer wird ein Konfliktdialog zur Erneuerung der Ansicht angeboten.
•	Teilweise Ausführung einer Löschoperation: Sämtliche zusammenhängende Löschvorgänge werden innerhalb einer Datenbanktransaktion ausgeführt. Schlägt das Löschen eines Teil-Datensatzes fehl, wird die gesamte Transaktion zurückgerollt (Rollback).
•	Beschädigte Datenbank: Erkennt das System eine beschädigte Datenbankdatei oder beschädigte Tabellenstrukturen, sperrt die Anwendung Schreibzugriffe, loggt den Fehler lokal und fordert den Benutzer auf, die Datenbankverbindung zu prüfen oder ein Backup einzuspielen.



3	Zusammenfassung 
Das Konzeptionsdokument beschreibt die technische und funktionale Ausgestaltung der Desktop Anwendung zur Projekt  und Aufgabenverwaltung. Durch den konsequenten Einsatz des MVVM Musters entsteht eine klare Trennung zwischen WPF Benutzeroberfläche, Präsentationslogik und Datenhaltung. Die lokale Persistenz wird über eine performante SQLite Datenbank in Verbindung mit Entity Framework Core umgesetzt, was eine konsistente Datenführung und kaskadierende Löschoperationen zuverlässig sicherstellt.
Mit der definierten Modulstruktur, dem detaillierten Datenmodell samt festen Kardinalitäten und Löschregeln sowie den klar beschriebenen Ausnahmelogiken für Fehlerfälle ist eine stabile Grundlage für die Implementierung geschaffen. Die Konzeption stellt sicher, dass alle Anforderungen aus dem Pflichtenheft strukturiert, nachvollziehbar und fehlertolerant umgesetzt werden können.


