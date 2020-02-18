using Dealership_Auto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace Dealership_Auto.Repository
{
    public class ClientRepository : BaseRepository
    {
        // Functie care returneaza toti clientii din baza de date
        public IList<Client> GetClienti()
        {
            var dataTable = this.ExecuteQuery("SELECT * FROM Clienti ");
            IList<Client> listaClienti = dataTable.AsEnumerable().Select(row =>
                new Client
                {
                    ClientID = row.Field<int>("ClientID"),
                    Nume = row.Field<string>("Nume"),
                    Prenume = row.Field<string>("Prenume"),
                    Email = row.Field<string>("Email"),
                    Adresa = row.Field<string>("Adresa"),
                    Telefon = row.Field<string>("Telefon")
                }).ToList();

            return listaClienti ?? new List<Client>();
        }

        // Functie care returneaza din baza de date clientii care au mai mult de searchNumber tranzactii cu masini de la searchProducator
        public IList<Client> GetClienti(string searchNumber, string searchProducator)
        {
            Convert.ToInt32(searchNumber);
            var query = $@"select distinct c.ClientID, c.Nume, c.Prenume, c.Email, c.Adresa, c.Telefon FROM Clienti c, Tranzactii t 
                        WHERE c.ClientID = t.ClientID
                        and 
                        (select count(t1.TranzactieID) from Tranzactii t1 
                        where t1.ClientID = c.ClientID) >= {searchNumber}
                        and 
                        (select p.NumeProducator from Producatori p, Modele m, Masini ms where p.ProducatorID = m.ProducatorID and ms.ModelID = m.ModelID and ms.MasinaID = t.MasinaID) = '{searchProducator}'";
            var dataTable = this.ExecuteQuery(query);
            IList<Client> listaClienti = dataTable.AsEnumerable().Select(row =>
                new Client
                {
                    ClientID = row.Field<int>("ClientID"),
                    Nume = row.Field<string>("Nume"),
                    Prenume = row.Field<string>("Prenume"),
                    Email = row.Field<string>("Email"),
                    Adresa = row.Field<string>("Adresa"),
                    Telefon = row.Field<string>("Telefon")
                }).ToList();

            return listaClienti ?? new List<Client>();
        }

        // Functie care returneaza un client din baza de date dupa ID
        public Client GetClient(int id)
        {
            var dataTable = this.ExecuteQuery($"SELECT * FROM Clienti WHERE ClientID = {id};");
            Client client = dataTable.AsEnumerable().Select(row =>
                new Client
                {
                    ClientID = row.Field<int>("ClientID"),
                    Nume = row.Field<string>("Nume"),
                    Prenume = row.Field<string>("Prenume"),
                    Email = row.Field<string>("Email"),
                    Adresa = row.Field<string>("Adresa"),
                    Telefon = row.Field<string>("Telefon")
                }).FirstOrDefault();

            return client;
        }

        // Functie care sterge un client din baza de date dupa ID
        public void DeleteClient(int id)
        {
            var query = $"DELETE FROM Clienti WHERE ClientID={id}";
            this.ExecuteQuery(query);
        }

        // Functie care executa operatia de UPDATE pentru un client dupa ID-ul acestuia
        public void EditClient(Client client)
        {
            var query = $"UPDATE Clienti SET Nume='{client.Nume}', Prenume='{client.Prenume}', "
                        + $"Email='{client.Email}', Adresa='{client.Adresa}', Telefon='{client.Telefon}'"
                        + $"WHERE clientID={client.ClientID}";
            this.ExecuteQuery(query);
        }

        // Functie care executa operatia de INSERT in baza de date a unui client
        public void InsertClient(Client client)
        {
            var query = "INSERT INTO clienti(Nume, Prenume, Email, Adresa, Telefon)" +
                        $"VALUES('{client.Nume}', '{client.Prenume}', '{client.Email}', '{client.Adresa}', '{client.Telefon}');";
            this.ExecuteQuery(query);
        }
    }
}
