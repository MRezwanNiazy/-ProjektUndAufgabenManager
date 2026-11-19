2. Projektarbeit
Konzeption und prototypische Umsetzung einer Anwendung zur Verwaltung von Projekten und Aufgaben
Mohammad Rezwan Niazy 
 
Pflichtenheft
	Prüfer:	Prof. Dr.-Ing. N. Jazdi
	Betreuer:	Prof. Dr.-Ing. N. Jazdi
Start: 06.08.2026	Abgabe: 06.11.2026
	
 
 
Dokument Versionsverwaltung

Version
Autor	QS	Datum	Status	Änderungen
0.1	RN		06.08	in Bearb.	Erstellung
1.0	RN		02.09	vorgelegt	
1.0	RN		17.09	Akzeptiert	

0	Inhaltsverzeichnis
0	INHALTSVERZEICHNIS	2
1	ZIELBESTIMMUNG	3
1.1	Musskriterien	3
1.2	Wunschkriterien	3
1.3	Abgrenzungskriterien	3
2	EINSATZ	3
2.1	Anwendungsbereiche	3
2.2	Zielgruppen	4
3	ANFORDERUNGEN AN DIE KONZEPTION	4
4	QUALITÄTS-ZIELBESTIMMUNG	5
5	DURCHFÜHRUNG	6
6	PROTOTYP*	6
6.1	Umgebung	6
6.1.1	Software	6
6.1.2	Hardware	6
6.1.3	Systemschnittstellen	7
6.2	Qualitäts-Zielbestimmung für den Prototyp	7
6.3	Entwicklungs-Umgebung	7
6.3.1	Software	7
6.3.2	Hardware	8
7	GLOBALE EVALUIERUNGSMETHODEN	8
8	ERGÄNZUNGEN	8

 
1	Zielbestimmung
Das Ziel dieser Projektarbeit ist die Konzeption und prototypische Umsetzung einer modernen Windows Desktop Anwendung zur strukturierten Verwaltung von Projekten und Aufgaben. Im Mittelpunkt steht eine intuitive Benutzeroberfläche, die auf dem MVVM Architekturmuster basiert und eine konsequente Trennung von Datenmodell, Geschäftslogik und Präsentation sicherstellt.
1.1	Musskriterien 
Im Rahmen der Musskriterien bietet die Anwendung eine flexible Kategorienverwaltung, mit der Projekte in frei definierbaren Bereichen wie Arbeit, Studium oder Privat organisiert und gefiltert werden können. Die integrierte Projektverwaltung ermöglicht das Erstellen, Bearbeiten und Löschen von Projekten; beim Entfernen eines Projekts werden alle zugehörigen Aufgaben automatisch kaskadierend aus der Datenbank gelöscht. Aufgaben werden mit Titel, Beschreibung, Status (Offen, In Bearbeitung, Erledigt), Priorität (Niedrig, Mittel, Hoch) sowie einem optionalen Fälligkeitsdatum erfasst. Der Projektfortschritt wird automatisch aus dem Verhältnis erledigter zu allen vorhandenen Aufgaben berechnet und über einen Fortschrittsbalken visualisiert. Ein zentrales Dashboard fasst wichtige Kennzahlen wie offene und überfällige Aufgaben sowie den Gesamtfortschritt aller aktiven Projekte zusammen, wobei Prioritäten und überfällige Fristen farblich hervorgehoben werden. Für eine schnelle Datennavigation stehen eine Volltextsuche über Aufgabentitel sowie flexible Sortierfunktionen nach Fälligkeit und Priorität zur Verfügung. Die Datenhaltung erfolgt dauerhaft und relational in einer lokalen SQLite Datenbank unter Verwendung von Entity Framework Core.
1.2	Wunschkriterien
Als optionale Wunschkriterien sind Erweiterungen vorgesehen, die den Funktionsumfang bei verbleibender Entwicklungszeit ergänzen. Dazu zählen eine Exportfunktion für Aufgabenlisten und Projektberichte im PDF  oder CSV Format, erweiterte grafische Auswertungen im Dashboard zur besseren Visualisierung der Aufgabenverteilung sowie die Möglichkeit, detaillierte Unteraufgaben in Form kleiner Checklisten innerhalb einer Aufgabe zu erfassen.
1.3	Abgrenzungskriterien
Zur klaren Abgrenzung des Systemumfangs gehört, dass die Software als reine Einzelbenutzer Anwendung ohne Benutzerverwaltung, Login Funktionen oder Rollenrechte ausgeführt wird. Zudem besteht keine Cloud  oder Netzwerkanbindung, sodass sämtliche Daten ausschließlich lokal auf dem Zielrechner verbleiben. Auch auf externe Systembenachrichtigungen wie den Versand von E Mails oder Windows Push Nachrichten bei überfälligen Fristen wird bewusst verzichtet.
2	Einsatz
2.1	Anwendungsbereiche
Die entwickelte Anwendung dient als digitales Werkzeug zur persönlichen Organisation, Strukturierung und Nachverfolgung von Projekten und Aufgaben im privaten wie auch im beruflichen Umfeld. Der primäre Einsatzbereich umfasst das Selbstmanagement sowie die Koordination alltäglicher Vorhaben, etwa in der Aus  und Weiterbildung (z. B. zur Nachverfolgung von Lerninhalten und Abgabefristen), bei berufsbezogenen Teilprojekten oder bei privaten Planungen. Durch die Einteilung in frei wählbare Kategorien lässt sich das System flexibel an unterschiedliche Einsatzszenarien anpassen.
2.2	Zielgruppen
Die Zielgruppe der Anwendung besteht aus Einzelanwendenden, die eine lokale, übersichtliche und ohne Einarbeitungsaufwand bedienbare Software zur Aufgabenverwaltung suchen. Dazu zählen vor allem Auszubildende, Studierende und Berufstätige, die ein hohes Aufkommen paralleler Aufgaben strukturieren und ihre Termine sowie Projektfortschritte eigenständig und effizient im Blick behalten möchten. Ebenso richtet sich die Anwendung an Personen, die bewusst eine reine Offline Lösung ohne Registrierung und Cloud Zwang bevorzugen.
3	Anforderungen an die Konzeption

/PA10/	Anlegen, Bearbeiten und Löschen frei definierbarer Kategorien (z. B. Arbeit, Studium, Privat) über eine eigene Verwaltungsoberfläche, einschließlich einer Validierung vor dem Entfernen. 
(/LA10/)

/PA20/




/PA30/ 




/PA40/




/PA50/ 




/PA60/ 




/PA70/



/PA80/




/PA90/ 




/PA100/





/PA110/




/PA120/




/PA130/




/PA140/




/PA150/




 	Eindeutige Zuordnung jedes Projekts zu genau einer Kategorie über eine relationale 1:n Beziehung im Datenmodell sowie Auswahl der Kategorie im Erstellungsdialog. 
(/LA20/)

Dynamisches Filtern der angezeigten Projektliste nach der aktuell ausgewählten Kategorie in der Benutzeroberfläche, wobei die Aktualisierung in Echtzeit erfolgt.
 (/LA30/)

Erfassung von Projekten mit den Pflichtfeldern Projektname und Kategorie, einem automatisch gesetzten Erstellungsdatum sowie einer optionalen Beschreibung. 
(/LA40/)

Serverseitige bzw. logische Berechnung des Projektfortschritts als Prozentwert auf Basis des Verhältnisses erledigter Aufgaben zur Gesamtzahl der Aufgaben eines Projekts. 
(/LA50/)

Visuelle Aufbereitung des berechneten Fortschrittswerts in der Projektliste und in der Detailansicht mithilfe eines WPF ProgressBar Bedienelements, ergänzt durch die Anzeige des Prozentwerts als Text. 
(/LA60/)

Automatisches, kaskadierendes Löschen aller zugehörigen Aufgaben auf Datenbankebene, sobald ein übergeordnetes Projekt vom Anwender entfernt wird. (/LA70/)


Hinzufügen und Bearbeiten von Aufgaben innerhalb eines Projekts mit Angaben zu Titel, Beschreibung, Status, Prioritätsstufe und einem optionalen Fälligkeitsdatum.
(/LA80/)

Führung des Aufgabenstatus (Offen, In Bearbeitung, Erledigt), wobei jede Statusänderung unmittelbar eine Neuberechnung des übergeordneten Projektfortschritts auslöst.
(/LA90/)

Einteilung von Aufgaben in die Prioritätsstufen Niedrig, Mittel oder Hoch sowie deren deutliche farbliche Kennzeichnung in den Listenansichten zur schnellen Orientierung.
(/LA100/)


Automatischer Abgleich des aktuellen Datums mit dem Fälligkeitsdatum nicht erledigter Aufgaben sowie auffällige optische Hervorhebung überfälliger Einträge in der Benutzeroberfläche.
(/LA110/)

Zentrale Übersichtsseite (Dashboard) mit automatisch berechneten Gesamtkennzahlen: Anzahl offener Aufgaben, Anzahl überfälliger Aufgaben sowie der aggregierte Gesamtfortschritt aller aktiven Projekte.
(/LA120/)

Bereitstellung einer Live Volltextsuche über die Aufgabentitel sowie flexibler Sortieroptionen nach Fälligkeitsdatum (auf /absteigend) und Prioritätsstufe.
(/LA130/)

Dauerhafte, relationale Datenhaltung in einer lokalen SQLite Datenbankdatei unter Verwendung von Entity Framework Core als Object Relational Mapper (ORM).
(/LA140/)

Konsequente Umsetzung des MVVM Architekturmusters zur sauberen Entkopplung von XAML Ansichten und Geschäftslogik sowie automatische UI Aktualisierung mittels Data Binding (INotifyPropertyChanged).
(/LA150/)
4	Qualitäts-Zielbestimmung
	sehr hoch	hoch	normal	nicht relevant
Theorie			x	
Allgemeingültigkeit			x	
Konsistenz			x	
Funktionalität			x	
Richtigkeit			x	
Anwendbarkeit			x	
Sicherheit			x	
Benutzbarkeit			x	
Verständlichkeit			x	
Erlernbarkeit			x	
Änderbarkeit			x	
Analysierbarkeit			x	
Modifizierbarkeit			x	

5	Durchführung
Die Arbeit wird nach dem IAS-Vorgehensmodell (Modell für konzeptionelle Arbeiten) durchgeführt werden.

Der Stand der Arbeit und die Ergebnisse werden in regelmäßigen Abständen (ca. alle 2 Wochen) mit den Betreuern diskutiert.

Bei der Durchführung der Arbeit und der Anfertigung der Ausarbeitung werden die Richtlinien des IAS beachtet.

6	Prototyp*
6.1	Umgebung
6.1.1	Software
Für die Ausführung des entwickelten Prototyps wird ein Windows Betriebssystem ab Windows 10 (64 Bit) benötigt. Auf dem Zielsystem muss die .NET 8.0 Desktop Runtime (oder höher) installiert sein, um die auf der Windows Presentation Foundation (WPF) basierende Anwendung ausführen zu können. Die relationale Datenbank wird als eingebettete SQLite Instanz in Form einer lokalen Datei (projektmanager.db) geführt, sodass keine serverseitigen Datenbankdienste auf dem Zielsystem installiert werden müssen.
6.1.2	Hardware
Die Hardwareanforderungen für den Betrieb des Prototyps orientieren sich an den Mindestanforderungen moderner Windows Arbeitsplätze. Erforderlich ist ein Standard PC oder Laptop mit einem 64 Bit Prozessor (mindestens 1 GHz Dual Core), mindestens 4 GB Arbeitsspeicher sowie etwa 100 MB freiem Festplattenspeicher für die Anwendungsdateien und die SQLite Datenbank. Für eine optimale Darstellung der grafischen Benutzeroberfläche wird ein Bildschirm mit einer Auflösung von mindestens 1280 × 720 Pixeln empfohlen.
6.1.3	Systemschnittstellen
Der Prototyp ist als isolierte Desktop Anwendung ohne externe Netzwerkschnittstellen konzipiert. Die Schnittstellen beschränken sich auf die lokale Dateisystem Schnittstelle zum Lesen und Schreiben der SQLite Datenbankdatei über Entity Framework Core sowie auf die Standard Eingabegeräte (Maus und Tastatur) zur Interaktion mit der WPF Benutzeroberfläche.
       
6.2	Qualitäts-Zielbestimmung für den Prototyp
	sehr hoch	hoch	normal	nicht relevant
Funktionalität			x	
Richtigkeit			x	
Sicherheit (Security)			x	
Interoperabilität			x	
Zuverlässigkeit			x	
Reife			x	
Fehlertoleranz			x	
Wiederherstellbarkeit			x	
Sicherheit (Safety)			x	
Benutzbarkeit			x	
Verständlichkeit			x	
Erlernbarkeit			x	
Bedienbarkeit			x	
Effizienz			x	
Zeitverhalten			x	
Verbrauchsverhalten			x	
Änderbarkeit			x	
Analysierbarkeit			x	
Modifizierbarkeit			x	
Übertragbarkeit			x	

6.3	Entwicklungs-Umgebung
6.3.1	Software
Für die Realisierung der Anwendung wird eine moderne Microsoft Entwicklungsumgebung eingesetzt. Als primäre Entwicklungsumgebung (IDE) dient Microsoft Visual Studio 2022 in Verbindung mit dem .NET 8.0 SDK (alternativ .NET 6.0/7.0). Das Framework bildet die technische Basis für die WPF Anwendung und ermöglicht eine effiziente Ausführung von XAML Oberflächen sowie C# Geschäftslogik. Für das objektrelationale Mapping (ORM) und die Datenbankverwaltung kommen die NuGet Pakete Microsoft.EntityFrameworkCore.Sqlite sowie die EF Core Tools zur Durchführung von Datenbankmigrationen zum Einsatz. Die Versionsverwaltung des Quellcodes erfolgt mittels Git und wird über GitHub gehostet. Zur Verwaltung der Datenbankinhalte während der Testphase wird zusätzlich ein SQLite Verwaltungstool wie der DB Browser for SQLite verwendet.
6.3.2	Hardware
Die Entwicklung und das Testen der Anwendung erfolgen auf einem Standard Entwicklungsrechner unter Windows 10 oder Windows 11 (64 Bit). Die Hardware Ausstattung umfasst einen Mehrkern Prozessor (z. B. Intel Core i5/i7 oder AMD Ryzen 5/7), mindestens 16 GB Arbeitsspeicher für die reibungslose parallele Nutzung von Visual Studio und der SQLite Datenbank sowie eine SSD Festplatte mit ausreichend freiem Speicherplatz für Entwicklungsumgebung, Quellcode und die lokale Datenbankdatei projektmanager.db. Für die effiziente Gestaltung und Überprüfung der WPF Benutzeroberflächen wird ein Monitor mit einer Full HD Auflösung (1920 × 1080 Pixel) oder höher eingesetzt.
7	Globale Evaluierungsmethoden
Die fertige Anwendung wird direkt mit den Anforderungen aus dem Lastenheft (/LA10/ bis /LA150/) abgeglichen. Zusätzlich werden verschiedene Testdatensätze definiert, sowohl gemeinsam mit dem Betreuer/Prüfer als auch unabhängig davon, um alle zentralen Funktionen gezielt zu überprüfen.

8	Ergänzungen
Keine. 

