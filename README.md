🧑‍💼 Gestione Utenti – Console App in C#

Una semplice applicazione console in C# che permette di gestire una lista di utenti mantenuta in memoria.
Il programma include funzionalità per:

-Visualizzare gli utenti salvati

-Aggiungere nuovi utenti

-Eliminare utenti tramite ID

-Modificare utenti tramite ID

Questo progetto è pensato per esercitarsi con liste, classi modello, menu interattivi e gestione input da console.

📁 Struttura del progetto

Il progetto consiste principalmente in due classi:

✔️ Utente
Rappresenta un utente con:
-Id (intero)
-Nome (stringa)
-Email (stringa)

✔️ Program
Contiene:
Una lista statica di utenti che simula un database in memoria
Il menu dell’applicazione
I metodi per mostrare, aggiungere, eliminare e modificare utenti

▶️ Funzionalità
1. Mostra Utenti
Stampa in tabella tutti gli utenti presenti nella lista.

2. Aggiungi Utente
Richiede:
-Nome
-Email
Genera automaticamente un nuovo ID incrementale.

3. Elimina Utente
Richiede un ID valido e lo rimuove dalla lista.

0. Esci
Chiude il programma.

🔧 Come eseguire il progetto

Clona il repository:
git clone https://github.com/tuo-user/tuo-repo.git

Entra nella cartella:
cd tuo-repo

Compila ed esegui con .NET:
dotnet run


Assicurati di avere installato il .NET SDK (6.0 o superiore).

📌 Esempio di utilizzo
=== GESTIONALE UTENTI ===
1. Mostra Utenti
2. Aggiungi Utente
3. Elimina Utente
0. Esci
Scegli (0-4):

🛠️ Tecnologie utilizzate

C#
.NET Console Application
Liste generiche (List<T>)

🚀 Possibili miglioramenti futuri
-Persistenza dei dati su file o database
-Validazione avanzata input
-Aggiornamento degli utenti
-Interfaccia grafica (WinForms/WPF/Web)
