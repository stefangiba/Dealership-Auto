using Dealership_Auto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Auto.Repository
{
    public class AngajatRepository: BaseRepository
    {
        // Functie ce extrage toti angajatii din baza de date
        public IList<Angajat> GetAngajati()
        {
            var dataTable = this.ExecuteQuery("SELECT * FROM Angajati ");
            IList<Angajat> listaAngajati = dataTable.AsEnumerable().Select(row =>
                new Angajat
                {
                    AngajatID = row.Field<int>("AngajatID"),
                    Nume = row.Field<string>("Nume"),
                    Prenume = row.Field<string>("Prenume"),
                    Email = row.Field<string>("Email"),
                    Adresa = row.Field<string>("Adresa"),
                    Telefon = row.Field<string>("Telefon"),
                    Parola = row.Field<string>("Parola")
                }).ToList();

            return listaAngajati ?? new List<Angajat>();
        }

        // Functie ce extrage toti angajatii din baza de date ce indeplinesc anumite conditii
        // Aceasta interogare complexa returneaza toti angajatii care au relaizat mai mult de searchNumber tranzactii cu un client cu numele de familie searchNume
        public IList<Angajat> GetAngajatiFiltered(string searchNumber, string searchNume)
        {
            Convert.ToInt32(searchNumber);
            var query = $@"SELECT a.AngajatID, a.Nume, a.Prenume, a.Adresa, a.Email, a.Telefon, a.Parola  FROM Angajati a,Tranzactii t,Clienti c
                        WHERE a.AngajatID = t.AngajatID
                        AND t.ClientID = c.ClientID
                        AND (SELECT COUNT(t1.TranzactieID) FROM Tranzactii t1 where t1.ClientID = c.ClientID) >= {searchNumber}
                        AND c.Nume like '%{searchNume}%'
                        GROUP BY a.AngajatID, a.Nume, a.Prenume, a.Adresa, a.Email, a.Telefon, a.Parola;";
            var dataTable = this.ExecuteQuery(query);
            IList<Angajat> listaAngajati = dataTable.AsEnumerable().Select(row =>
                new Angajat
                {
                    AngajatID = row.Field<int>("AngajatID"),
                    Nume = row.Field<string>("Nume"),
                    Prenume = row.Field<string>("Prenume"),
                    Email = row.Field<string>("Email"),
                    Adresa = row.Field<string>("Adresa"),
                    Telefon = row.Field<string>("Telefon"),
                    Parola = row.Field<string>("Parola")
                }).ToList();

            return listaAngajati ?? new List<Angajat>();
        }

        // Functie care extrage un angajat din baza de date in functie de ID-ul acestuia
        public Angajat GetAngajat(int id)
        {
            var dataTable = this.ExecuteQuery($"SELECT * FROM Angajati WHERE AngajatID = {id};");
            Angajat angajat = dataTable.AsEnumerable().Select(row =>
                new Angajat
                {
                    AngajatID = row.Field<int>("AngajatID"),
                    Nume = row.Field<string>("Nume"),
                    Prenume = row.Field<string>("Prenume"),
                    Email = row.Field<string>("Email"),
                    Adresa = row.Field<string>("Adresa"),
                    Telefon = row.Field<string>("Telefon"),
                    Parola = row.Field<string>("Parola")
                }).FirstOrDefault();

            return angajat;
        }

        // O functie simpla pentru verificarea datelor de login
        public bool VerifyLoginInfo(string email, string parola)
        {
            var query = $"SELECT Email, Parola From Angajati WHERE Email='{email}' AND Parola='{parola}';";
            var dataTable = this.ExecuteQuery(query);
            Angajat angajat = dataTable.AsEnumerable().Select(row =>
            new Angajat
            {
                Email = row.Field<string>("Email"),
                Parola = row.Field<string>("Parola")
            }).FirstOrDefault();

            if ((angajat.Email != "") && (angajat.Parola != ""))
            {
                return true;
            }
            else return false;

        }
        
        // Functie care se ocupa cu stergerea unui angajat din baza de date dupa ID-ul acestuia
        public void DeleteAngajat(int id)
        {
            var query = $"DELETE FROM Angajati WHERE AngajatID={id}";
            this.ExecuteQuery(query);
        }

        // Functie ce se ocupa cu operatia de UPDATE in baza de date a unui angajat dupa ID-ul acestuia
        public void EditAngajat(Angajat angajat)
        {
            var query = $"UPDATE Angajati SET Nume='{angajat.Nume}', Prenume='{angajat.Prenume}', "
                        + $"Email='{angajat.Email}', Adresa='{angajat.Adresa}', Telefon='{angajat.Telefon}', Parola='{angajat.Parola}' "
                        + $"WHERE AngajatID={angajat.AngajatID};";
            this.ExecuteQuery(query);
        }

        // Functie ce se ocupa cu operatia de INSERT in baza de date a unui angajat
        public void InsertAngajat(Angajat angajat)
        {
            var query = "INSERT INTO Angajati(Nume, Prenume, Email, Adresa, Telefon, Parola)" +
                         $" VALUES('{angajat.Nume}', '{angajat.Prenume}', '{angajat.Email}', '{angajat.Adresa}', '{angajat.Telefon}', '{angajat.Parola}');";
            this.ExecuteQuery(query);
        }
    }

    
}
