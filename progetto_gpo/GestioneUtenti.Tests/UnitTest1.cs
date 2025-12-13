using Xunit;
using GestioneUtenti;

namespace GestioneUtenti.Tests
{
    public class ProgramTests
    {
        public ProgramTests()
        {
            // reset prima di ogni test
            Program.ResetUtenti();
        }

        [Fact]
        public void AggiungiUtente_AumentaNumeroUtenti()
        {
            Program.AggiungiUtente("Anna Bianchi", "anna@test.com");

            bool risultato = Program.AggiornaEmail(3, "anna@test.com");

            Assert.True(risultato);
        }

        [Fact]
        public void EliminaUtente_RimuoveUtenteEsistente()
        {
            Program.EliminaUtente(1);

            bool risultato = Program.AggiornaEmail(1, "nuova@mail.com");

            Assert.False(risultato);
        }

        [Fact]
        public void AggiornaEmail_IdEsistente_RitornaTrue()
        {
            bool risultato = Program.AggiornaEmail(2, "luigi@new.com");

            Assert.True(risultato);
        }

        [Fact]
        public void AggiornaEmail_IdNonEsistente_RitornaFalse()
        {
            bool risultato = Program.AggiornaEmail(99, "x@y.com");

            Assert.False(risultato);
        }
    }
}