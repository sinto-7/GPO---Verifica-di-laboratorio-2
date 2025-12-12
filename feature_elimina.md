🗑️ Funzionalità: Eliminazione Utente

La funzionalità Elimina Utente permette di rimuovere un utente dalla lista in memoria tramite il suo identificatore univoco (ID).
Questa operazione è utile per mantenere aggiornato il database simulato e per evitare la presenza di dati obsoleti.

🔍 Come funziona
L’applicazione richiede all’utente di inserire l'ID dell’utente da eliminare.
Viene verificato che l’input sia un valore numerico valido tramite int.TryParse().
Il metodo EliminaUtente(int id) cerca nella lista un elemento con quell'ID usando FirstOrDefault().

Se l’utente esiste:
viene rimosso dalla lista con Remove()
viene mostrato un messaggio di conferma

Se l’utente non esiste:
viene notificato che l’ID non è stato trovato

🧩 Metodo coinvolto
static void EliminaUtente(int idUtente)
{
    var utente = utenti.FirstOrDefault(u => u.Id == idUtente);

    if (utente != null)
    {
        utenti.Remove(utente);
        Console.WriteLine($"Eliminato ID: {idUtente}");
    }
    else
    {
        Console.WriteLine($"ID {idUtente} non trovato.");
    }
}

📌 Note

L'eliminazione è definitiva in quanto la lista rappresenta un database in memoria.
L’ID viene passato come input tramite il menu interattivo.
In caso di input non valido (non numerico), il programma avvisa l’utente senza interrompere l’esecuzione.
