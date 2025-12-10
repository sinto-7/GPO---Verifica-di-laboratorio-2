using System;
using System.Collections.Generic;
using System.Linq;

/// <namespace>
/// <summary>
/// Namespace contenente le classi per la gestione degli utenti.
/// </summary>
/// </namespace>
namespace GestioneUtenti
{
    /// <summary>
    /// Classe modello che rappresenta un utente.
    /// </summary>
    public class Utente
    {
        /// <value>
        /// <summary>Identificatore univoco dell'utente.</summary>
        /// </value>
        public int Id { get; set; }

        /// <value>
        /// <summary>Nome completo dell'utente.</summary>
        /// </value>
        public string Nome { get; set; }

        /// <value>
        /// <summary>Indirizzo email dell'utente.</summary>
        /// </value>
        public string Email { get; set; }
    }

    /// <summary>
    /// Classe principale che contiene il programma per la gestione degli utenti.
    /// </summary>
    class Program
    {
        /// <value>
        /// <summary>Lista statica che simula un database in memoria contenente gli utenti.</summary>
        /// </value>
        static List<Utente> utenti = new List<Utente>
        {
            new Utente { Id = 1, Nome = "Mario Rossi", Email = "mario@old.com" },
            new Utente { Id = 2, Nome = "Luigi Verdi", Email = "luigi@old.com" }
        };

        /// <summary>
        /// Metodo principale che avvia il programma.
        /// </summary>
        /// <param name="args">Argomenti da riga di comando (non utilizzati).</param>
        static void Main(string[] args)
        {
            Menu();
        }

        /// <summary>
        /// Visualizza tutti gli utenti presenti nella lista.
        /// </summary>
        static void MostraUtenti()
        {
            Console.WriteLine($"\n{"ID",-5} {"NOME",-20} {"EMAIL"}");
            Console.WriteLine(new string('-', 45));

            if (utenti.Count == 0)
            {
                Console.WriteLine("Nessun utente presente.");
            }
            else
            {
                foreach (var u in utenti)
                {
                    Console.WriteLine($"{u.Id,-5} {u.Nome,-20} {u.Email}");
                }
            }
            Console.WriteLine(new string('-', 45));
        }

        /// <summary>
        /// Aggiunge un nuovo utente alla lista.
        /// </summary>
        /// <param name="nome">Nome del nuovo utente.</param>
        /// <param name="email">Email del nuovo utente.</param>
        static void AggiungiUtente(string nome, string email)
        {
            int nuovoId = utenti.Any() ? utenti.Max(u => u.Id) + 1 : 1;

            utenti.Add(new Utente { Id = nuovoId, Nome = nome, Email = email });
            Console.WriteLine($"Aggiunto: {nome} (ID: {nuovoId})");
        }

        /// <summary>
        /// Elimina un utente dalla lista in base all'ID.
        /// </summary>
        /// <param name="idUtente">ID dell'utente da eliminare.</param>
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

        /// <summary>
        /// Visualizza il menu principale e gestisce le scelte dell'utente.
        /// </summary>
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n=== GESTIONALE UTENTI ===");
                Console.WriteLine("1. Mostra Utenti");
                Console.WriteLine("2. Aggiungi Utente");
                Console.WriteLine("3. Elimina Utente");
                Console.WriteLine("0. Esci");

                Console.Write("Scegli (0-4): ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        MostraUtenti();
                        break;

                    case "2":
                        Console.Write("Nome: ");
                        string n = Console.ReadLine();
                        Console.Write("Email: ");
                        string e = Console.ReadLine();
                        AggiungiUtente(n, e);
                        break;
                    
                    case "3":
                        Console.Write("ID da eliminare: ");
                        if (int.TryParse(Console.ReadLine(), out int idDel))
                        {
                            EliminaUtente(idDel);
                        }
                        else
                        {
                            Console.WriteLine("Input ID non valido!");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Uscita in corso...");
                        return;

                    default:
                        Console.WriteLine("Scelta non valida, riprova.");
                        break;
                }
            }
        }
    }
}