Gestione Utenti Console App 🚀

Questo progetto è un sistema gestionale semplificato basato su console, scritto in C#.
L’obiettivo è simulare un workflow professionale in un team di sviluppo, includendo GitHub, branching, documentazione e sviluppo di funzionalità collaborative.

📖 Descrizione

L’applicazione gestisce una lista di utenti mantenuta in memoria (RAM).
Permette di eseguire le principali operazioni CRUD:

-Creazione
-Visualizzazione
-Modifica
-Eliminazione

Il progetto riproduce un contesto reale di sviluppo condiviso, includendo la gestione del codice tramite GitHub e una struttura modulare facilmente estendibile.

✨ Funzionalità

Visualizzazione utenti: stampa formattata dell’elenco utenti.

Inserimento utenti: aggiunta di nuovi record con ID generato automaticamente.

Modifica: aggiornamento dell’indirizzo email tramite ID.

Eliminazione: rimozione di un utente tramite ID.

Future Features (in branch dedicati):
-Ricerca utenti per nome
-Esportazione su file .txt

🛠 Tecnologie Utilizzate
-C# (.NET)
-Visual Studio / VS Code
-Git & GitHub
-Documentazione stile Doxygen/XML

🚀 Installazione e Avvio

Clonare il repository:
git clone https://github.com/sinto-7/GPO---Verifica-di-laboratorio-2


Aprire il progetto in Visual Studio o VS Code.

Compilare ed eseguire:
dotnet run

👥 Organizzazione del Lavoro

Prima parte del codice:
è stata svolta insieme alla struttura iniziale del programma:

-classe Utente:
lista utenti simulata in memoria

-menu principale:
funzioni base (visualizzazione e inserimento)

Sviluppo funzionalità:
Funzione Elimina → sviluppata da Nardullo
Funzione Modifica Email → sviluppata da Pinna

Gestione GitHub:
Una volta completate le feature principali, si sono incontrati per:
caricare il progetto
organizzare i branch
effettuare commit e merge in base alle attività sviluppate

Branch utilizzati:
feature/elimina-utente → Nardullo
feature/modifica-email → Pinna
main → versione stabile

👤 Autori
Pinna Andrea
Nardullo Federico
