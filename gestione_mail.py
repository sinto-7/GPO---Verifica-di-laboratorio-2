# ==========================================
# ESERCIZIO PYTHON: CRUD UTENTI CON MENU
# ==========================================
# ISTRUZIONI:
# 1. Completa la funzione 'aggiorna_email'.
# 2. Esegui il codice: apparirà un MENU interattivo.
#    (Su browser userai i popup, su VS Code il terminale).
# ==========================================

utenti = [
    {"id": 1, "nome": "Mario Rossi", "email": "mario@old.com"},
    {"id": 2, "nome": "Luigi Verdi", "email": "luigi@old.com"}
]

def mostra_utenti():
    print(f"\n{'ID':<5} {'NOME':<15} {'EMAIL'}")
    print("-" * 35)
    for u in utenti:
        print(f"{u['id']:<5} {u['nome']:<15} {u['email']}")
    print("-" * 35)

def aggiungi_utente(nome, email):
    global utenti
    if utenti:
        nuovo_id = max(u["id"] for u in utenti) + 1
    else:
        nuovo_id = 1
    utenti.append({"id": nuovo_id, "nome": nome, "email": email})
    print(f"✅ Aggiunto: {nome} (ID: {nuovo_id})")

def elimina_utente(id_utente):
    global utenti
    prima = len(utenti)
    utenti = [u for u in utenti if u["id"] != id_utente]
    if len(utenti) < prima:
        print(f"🗑️ Eliminato ID: {id_utente}")
    else:
        print(f"❌ ID {id_utente} non trovato.")

def aggiorna_email(id_utente, nuova_email):
    """
    Cerca l'utente con 'id_utente' e cambia la sua email.
    Ritorna True se trovato e modificato, altrimenti False.
    """
    global utenti
    # TODO: Scrivi qui il codice per aggiornare l'email
    
    
    return False

# --- MENU INTERATTIVO (CLI) ---
def menu():
    while True:
        print("\n=== GESTIONALE UTENTI ===")
        print("1. Mostra Utenti")
        print("2. Aggiungi Utente")
        print("3. Elimina Utente")
        print("4. Aggiorna Email (DA FARE)")
        print("0. Esci")
        
        # input() su browser apre un popup, su VS Code aspetta input tastiera
        scelta = input("Scegli (0-4): ")
        
        if scelta == "1":
            mostra_utenti()
        elif scelta == "2":
            n = input("Nome: ")
            e = input("Email: ")
            aggiungi_utente(n, e)
        elif scelta == "3":
            try:
                i = int(input("ID da eliminare: "))
                elimina_utente(i)
            except:
                print("❌ ID non valido!")
        elif scelta == "4":
            try:
                i = int(input("ID utente: "))
                e = input("Nuova Email: ")
                ok = aggiorna_email(i, e)
                if ok: print("✅ Aggiornato!")
                else: print("❌ Fallito (ID non trovato o funzione vuota)")
            except:
                print("❌ Input non valido!")
        elif scelta == "0":
            print("👋 Uscita...")
            break

# Esegui menu solo se non stiamo facendo i test automatici
if __name__ == "__main__" and "TESTING_MODE" not in globals():
    menu()