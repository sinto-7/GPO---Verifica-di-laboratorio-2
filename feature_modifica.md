✏️ Funzionalità: Aggiornamento Email Utente
La funzionalità Aggiorna Email permette di modificare l’indirizzo email associato a un utente già presente nella lista.
Questa operazione è utile per mantenere aggiornati i dati degli utenti e correggere eventuali informazioni obsolete o errate.

🔍 Come funziona
L’applicazione richiede l’ID dell’utente di cui si vuole aggiornare l’email.
Viene verificato che l’input sia numerico tramite int.TryParse().
Il metodo AggiornaEmail(int id, string nuovaEmail) cerca un utente corrispondente usando FirstOrDefault().

Se viene trovato:
l’email dell’utente viene aggiornata con la nuova fornita
il metodo restituisce true, indicando il successo dell’operazione

Se l’utente non esiste:
nessuna modifica viene effettuata
il metodo restituisce false
il menu notifica che l’ID non è stato trovato

🧩 Metodo coinvolto
static bool AggiornaEmail(int idUtente, string nuovaEmail)
{
    var utente = utenti.FirstOrDefault(u => u.Id == idUtente);

    if (utente != null)
    {
        utente.Email = nuovaEmail;
        return true;
    }
    return false;
}

📌 Note
L’aggiornamento è immediato in quanto opera direttamente sulla lista che funge da database in memoria.
La nuova email viene accettata “così com’è”; eventuali validazioni più avanzate possono essere aggiunte in futuro.
Il menu gestisce automaticamente il feedback per l’utente, indicando se l’operazione è andata a buon fine.
