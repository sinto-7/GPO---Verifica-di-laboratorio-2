Stato degli Unit Test

Questo repository contiene un'applicazione console C# per la gestione degli utenti. Il codice attuale è stato già mergiato ed è condiviso tra più sviluppatori; per questo motivo non è stato modificato all'interno del branch dedicato agli unit test.
Nel branch unit-tests è stato analizzato lo stato del progetto con l'obiettivo di introdurre test automatici.
Problema riscontrato
Non è stato possibile implementare unit test automatici eseguibili senza modificare il codice sorgente originale.
Il problema non è legato agli strumenti di testing, ma alla struttura del codice, che non è progettata per essere testata in modo unitario.

Motivazioni tecniche:
1. Accessibilità dei metodi
La classe Program e i metodi di business (AggiungiUtente, EliminaUtente, AggiornaEmail) non sono dichiarati come public.
👉 Un progetto di test separato non può accedere a questi metodi, causando errori di compilazione.

2. Stato globale statico
La lista degli utenti è mantenuta come stato statico:
static List<Utente> utenti
👉 Questo rende i test dipendenti dall'ordine di esecuzione e non permette di ripristinare uno stato iniziale consistente tra un test e l'altro.

3. Dipendenza diretta dalla Console
L'applicazione è fortemente legata all'input/output da console (Console.ReadLine, Console.WriteLine) ed entra in un ciclo infinito (while(true) nel metodo Menu).
👉 Questo comportamento blocca l'esecuzione automatica dei test.

Scelta progettuale:
Poiché il codice:
è già stato mergiato
è condiviso con altri sviluppatori
non può essere modificato senza introdurre breaking changes
si è deciso intenzionalmente di non alterare il codice sorgente originale.

Conclusione

L'assenza di unit test eseguibili non è una limitazione degli strumenti, ma una conseguenza diretta della struttura attuale dell'applicazione.
Per rendere il progetto testabile in futuro, sarebbe necessario:
-separare la logica di business dalla UI (Console)
-evitare stato statico condiviso
-rendere i metodi di business accessibili ai test
