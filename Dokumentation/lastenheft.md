2. Projektarbeit
Konzeption und prototypische Umsetzung einer Anwendung zur Verwaltung von Projekten und Aufgaben
Rezwan Niazy
Ausbildung Fachinformatik/Anwendungsentwicklung
Lastenheft
	Prüfer:	Prof. Dr.-Ing. N. Jazdi
	Betreuer:	Prof. Dr.-Ing. N. Jazdi
	
	
 
 
Dokument Versionsverwaltung

Version	Autor	Datum	Status	Änderungen
0.1	Ja	06.08.26	in Bearb.	Erstellung
1.0	Ja	06.08.26	akzeptiert	

0	Inhaltsverzeichnis
0	INHALTSVERZEICHNIS	2
1	EINFÜHRUNG IN DAS PROJEKT	3
2	ZIELBESTIMMUNG	3
3	EINSATZ	4
4	ANFORDERUNGEN AN DIE KONZEPTION	4
5	QUALITÄTSANFORDERUNGEN	4
6	DURCHFÜHRUNG	5
7	ERGÄNZUNGEN	6
8	LITERATUR	6

 
1	Einführung in das Projekt
Die Organisation und Verwaltung von Projekten und Aufgaben spielt sowohl im privaten als auch im beruflichen Alltag eine zentrale Rolle. Mit zunehmender Anzahl an Projekten, Aufgaben und Terminen wächst der Bedarf nach digitalen Lösungen, die eine strukturierte, intuitive und effiziente Planung sowie Nachverfolgung ermöglichen. Insbesondere moderne Benutzeroberflächen, automatisierte Auswertungen und übersichtliche Visualisierungen können dazu beitragen, Arbeitsabläufe zu vereinfachen und die Produktivität der Nutzer nachhaltig zu steigern.
Im Rahmen dieser Projektarbeit soll eine Anwendung zur Verwaltung von Projekten und Aufgaben entwickelt werden. Die Software soll es Nutzern ermöglichen, Projekte in frei definierbaren Kategorien – beispielsweise Arbeit, Studium oder Privat – zu organisieren und diesen Aufgaben mit unterschiedlichen Prioritäten, Statuswerten und optionalen Fälligkeitsdaten zuzuordnen. Neben der komfortablen Erstellung, Bearbeitung und Löschung von Projekten und Aufgaben sollen Such-, Filter- und Sortierfunktionen eine effiziente Verwaltung der Daten unterstützen.
Ein weiterer Schwerpunkt liegt auf der automatischen Berechnung und Visualisierung des Projektfortschritts. Hierzu soll der Bearbeitungsstand eines Projekts anhand des Verhältnisses erledigter zu vorhandenen Aufgaben ermittelt und über einen Fortschrittsbalken dargestellt werden. Zusätzlich soll ein Dashboard zentrale Kennzahlen wie die Anzahl offener und überfälliger Aufgaben sowie den aggregierten Fortschritt aller aktiven Projekte übersichtlich zusammenfassen. Überfällige Aufgaben sollen dabei automatisch visuell hervorgehoben werden.
Ein besonderer Schwerpunkt der Anwendung liegt auf einer klaren Trennung von Daten, Geschäftslogik und Benutzeroberfläche gemäß dem Model – View – ViewModel (MVVM)-Architekturmuster. Änderungen an Projekten und Aufgaben sollen unmittelbar in der Benutzeroberfläche sichtbar werden. Zur langfristigen Speicherung der Daten wird eine relationale SQLite-Datenbank eingesetzt, auf die über Entity Framework Core zugegriffen wird. Dadurch wird eine wartbare, erweiterbare und performante Anwendung geschaffen, die den Anforderungen moderner Desktop-Anwendungen gerecht wird.
2	Zielbestimmung
Ziel der Projektarbeit ist die Konzeption und prototypische Umsetzung einer modernen Anwendung zur Verwaltung von Projekten und Aufgaben mit grafischer Benutzeroberfläche. Die Anwendung soll eine intuitive, strukturierte und effiziente Organisation von Projekten ermöglichen und dabei sowohl funktionale als auch gestalterische Anforderungen berücksichtigen.
Im Mittelpunkt steht die Entwicklung einer Anwendung, die Projekte übersichtlich verwaltet und diesen Aufgaben mit unterschiedlichen Statuswerten, Prioritäten und optionalen Fälligkeitsdaten zuordnet. Darüber hinaus sollen Projekte in frei definierbaren Kategorien organisiert sowie über Such-, Filter- und Sortierfunktionen effizient verwaltet werden. Ein Dashboard soll dem Nutzer jederzeit einen Überblick über offene und überfällige Aufgaben sowie den Gesamtfortschritt aller aktiven Projekte ermöglichen.
Ein weiteres Ziel ist die automatische Berechnung und Visualisierung des Projektfortschritts. Hierbei soll der Fortschritt eines Projekts anhand des Verhältnisses erledigter Aufgaben zur Gesamtzahl der Aufgaben ermittelt und über geeignete grafische Elemente, beispielsweise einen Fortschrittsbalken, dargestellt werden. Änderungen am Aufgabenstatus sollen den Projektfortschritt unmittelbar aktualisieren.
Ein weiterer Schwerpunkt ist die Umsetzung einer klar strukturierten Softwarearchitektur auf Basis des MVVM-Prinzips. Dabei sollen Datenmodell, Geschäftslogik und Benutzeroberfläche konsequent voneinander getrennt werden, um eine hohe Wartbarkeit, Erweiterbarkeit und Wiederverwendbarkeit der Anwendung sicherzustellen. Zusätzlich sollen Mechanismen zur Datenvalidierung sowie zur automatischen Synchronisation zwischen Benutzeroberfläche und Daten implementiert werden.
Die dauerhafte Speicherung der Daten soll relational mithilfe einer SQLite-Datenbank unter Verwendung von Entity Framework Core erfolgen. Darüber hinaus soll die Anwendung grundlegende Komfort- und Sicherheitsfunktionen, wie beispielsweise Bestätigungsdialoge bei kritischen Aktionen, die automatische Aktualisierung der Benutzeroberfläche sowie eine konsistente Datenhaltung, bereitstellen. Abschließend soll die entwickelte Lösung dokumentiert und in Form eines funktionsfähigen Prototyps demonstriert werden.
3	Einsatz
Die Ergebnisse werden im Rahmen der Ausbildung „Fachinformatiker/Anwendungsentwicklung verwendet.
4	Anforderungen an die Konzeption
/LA10/	Es soll die Möglichkeit bestehen, eigene Kategorien zur Strukturierung von Projekten anzulegen, zu bearbeiten und zu löschen (z. B. Arbeit, Studium oder Privat).
/LA20/	Jedes Projekt soll genau einer Kategorie zugeordnet werden können.
/LA30/	Die Anwendung soll eine Filterfunktion bereitstellen, mit der Projekte anhand ihrer Kategorie angezeigt werden können.
/LA40/	Es soll möglich sein, Projekte mit einem Namen, einer Beschreibung, einem Erstellungsdatum sowie einer zugehörigen Kategorie anzulegen.
/LA50/	Der Fortschritt eines Projekts soll automatisch als Prozentwert auf Basis des Verhältnisses erledigter Aufgaben zur Gesamtzahl der Aufgaben berechnet werden.
/LA60/	Der aktuelle Projektfortschritt soll in der Benutzeroberfläche mithilfe eines Fortschrittsbalkens (ProgressBar) grafisch dargestellt werden.
/LA70/	Beim Löschen eines Projekts sollen sämtliche zugehörigen Aufgaben automatisch mitgelöscht werden (kaskadierendes Löschen).
/LA80/	Es soll möglich sein, einem Projekt Aufgaben mit Titel, Beschreibung, Status, Priorität sowie einem optionalen Fälligkeitsdatum hinzuzufügen.
/LA90/	Jede Aufgabe soll einen Status (Offen, In Bearbeitung oder Erledigt) besitzen. Änderungen des Status sollen den Projektfortschritt automatisch aktualisieren.
/LA100/	Aufgaben sollen mit den Prioritätsstufen Niedrig, Mittel oder Hoch versehen werden können. Die Priorität soll in der Benutzeroberfläche farblich hervorgehoben werden.
/LA110/	Aufgaben, deren Fälligkeitsdatum überschritten wurde, sollen automatisch visuell hervorgehoben werden.
/LA120/	Die Anwendung soll auf der Startseite bzw. einem Dashboard zentrale Kennzahlen bereitstellen. Hierzu zählen die Gesamtzahl offener Aufgaben, die Anzahl überfälliger Aufgaben sowie der aggregierte Gesamtfortschritt aller aktiven Projekte.
/LA130/	Die Anwendung soll eine Volltextsuche über Aufgabentitel sowie Sortierfunktionen nach Fälligkeitsdatum und Priorität bereitstellen.
/LA140/	Die Datenhaltung soll relational mithilfe einer SQLite-Datenbank erfolgen. Für den Datenzugriff soll Entity Framework Core eingesetzt werden.
/LA150/	Die Anwendung soll nach dem MVVM-Architekturmuster entwickelt werden. Dabei sind Datenmodell, Geschäftslogik und Benutzeroberfläche klar voneinander zu trennen. Änderungen an den Daten sollen durch Data Binding automatisch in der Benutzeroberfläche aktualisiert werden.
5	Qualitätsanforderungen
	sehr hoch	hoch	normal	nicht relevant
Theorie			x	
Funktionalität			x	
Benutzbarkeit			x	
Änderbarkeit			x	
Übertragbarkeit			x	

6	Durchführung
Die Arbeit soll nach dem IAS-Vorgehensmodell (Modell für konzeptionelle Arbeiten) durchgeführt werden. In der nachfolgenden Tabelle sind die im Rahmen dieser Arbeit zu erstellenden Dokumente eingetragen. 

Tabelle 1: Zu erstellende Dokumente  
Projektphasen	BA/FA/MA/SA
KE 1 Definitionsphase
	PM 1	Projektplanung	Projektplan	X
	KE 1.1	Analyse und Festlegung der Anforderungen an die Konzeption	Pflichtenheft	X
	KE 1.2	Analyse der Grundlagen	Grundlagen	X
KE 2 Konzeptionsphase
	QS 2.1	Erstellung der Evaluierungs-spezifikation	Evaluierungs-spezifikation	0
	KE 2.1	Erstellung der Konzeption	Konzeption	X
KE 3 Prototyping-Phase
	KE 3.1	Erstellung des Prototyps	Beschreibung des Prototyps	X
	QS 2.2	Evaluation	Evaluierungsprotokoll	0
	PM 3	Projektabschluss	Projektabschlussbericht	O

Legende:
	

X	Dokument ist vorgeschrieben
O	Dokument ist freiwillig

Der Stand der Arbeit und die Ergebnisse sollen in regelmäßigen Abständen (ca. alle 2 Wochen) mit den Betreuern diskutiert werden.

Bei der Durchführung der Arbeit und der Anfertigung der Ausarbeitung sind die Richtlinien des IAS zu beachten.
7	Ergänzungen
Keine.
8	Literatur
[1]		Weyrich, M. : Skript zur Vorlesung Technologien und Methoden der Softwaresysteme I, IAS, Stuttgart, 2016.
[2]		Jazdi, N., Oppenländer, N., Weyrich, M.. Quantification of the quality characteristics for the calculation of software reliability. In IFAC TC 3.3 Telematics: Control via Communication Networks, Telematics Application (TA) 2016 06.-09.2016 Porto Alegre, Brazil.
[3]	Berg, B., Knott, P., Sandhaus, G.: Hybride Softwareentwicklung. 1. Aufl., Berlin, Heidelberg, New York: Springer-Verlag, 2014. 

