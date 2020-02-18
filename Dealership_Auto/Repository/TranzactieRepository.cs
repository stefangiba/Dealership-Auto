using Dealership_Auto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Auto.Repository
{
    public class TranzactieRepository: BaseRepository
    {
        // Functie care returneaza toate tranzactiile din baza de date
        public IList<Tranzactie> GetTranzactii()
        {
            var query = "SELECT * FROM Tranzactii";
            var dataTable = this.ExecuteQuery(query);
            IList<Tranzactie> listaTranzactii = dataTable.AsEnumerable().Select(row =>
                new Tranzactie
                {
                    TranzactieID = row.Field<int>("TranzactieID"),
                    AngajatID = row.Field<int>("AngajatID"),
                    ClientID = row.Field<int>("ClientID"),
                    MasinaID = row.Field<int>("MasinaID"),
                    Data = row.Field<string>("Data"),
                    Suma = row.Field<double>("Suma")
                }).ToList();

            return listaTranzactii ?? new List<Tranzactie>();
        }

        // Functie care returneaza tranzactiile care au suma > searchNumber si masina este model searchModel
        public IList<Tranzactie> GetTranzactiiFiltered(string searchNumber, string searchModel)
        {
            Convert.ToInt32(searchNumber);
            var query = $@"SELECT * FROM Tranzactii t
                        WHERE t.Suma > {searchNumber}
                        AND
                        (
	                        SELECT NumeModel FROM Modele md, Masini m
	                        WHERE m.MasinaID=t.MasinaID
	                        AND m.ModelID = md.ModelID
                        ) LIKE '%{searchModel}%'";
            var dataTable = this.ExecuteQuery(query);
            IList<Tranzactie> listaTranzactii = dataTable.AsEnumerable().Select(row =>
                new Tranzactie
                {
                    TranzactieID = row.Field<int>("TranzactieID"),
                    AngajatID = row.Field<int>("AngajatID"),
                    ClientID = row.Field<int>("ClientID"),
                    MasinaID = row.Field<int>("MasinaID"),
                    Data = row.Field<string>("Data"),
                    Suma = row.Field<double>("Suma")
                }).ToList();

            return listaTranzactii ?? new List<Tranzactie>();
        }

        // Functie care returneaza toate tranzactiile care au suma mai mare decat media de pret a masinilor de pe stoc
        public IList<Tranzactie> GetTranzactiiComplex()
        {
            var query = @"select * from Tranzactii t
                        where 
                        (
	                        select AVG(m.Pret) from Masini m
                        ) < t.Suma";
            var dataTable = this.ExecuteQuery(query);
            IList<Tranzactie> listaTranzactii = dataTable.AsEnumerable().Select(row =>
               new Tranzactie
               {
                   TranzactieID = row.Field<int>("TranzactieID"),
                   AngajatID = row.Field<int>("AngajatID"),
                   ClientID = row.Field<int>("ClientID"),
                   MasinaID = row.Field<int>("MasinaID"),
                   Data = row.Field<string>("Data"),
                   Suma = row.Field<double>("Suma")
               }).ToList();

            return listaTranzactii ?? new List<Tranzactie>();
        }

        // Functie care returneaza o tranzactie din baza de date dupa ID
        public Tranzactie GetTranzactie(int id)
        {
            var query = $"SELECT * FROM Tranzactii WHERE TranzactieID={id};";
            var dataTable = this.ExecuteQuery(query);
            Tranzactie tranzactie = dataTable.AsEnumerable().Select(row =>
                new Tranzactie
                {
                    TranzactieID = row.Field<int>("TranzactieID"),
                    AngajatID = row.Field<int>("AngajatID"),
                    ClientID = row.Field<int>("ClientID"),
                    MasinaID = row.Field<int>("MasinaID"),
                    Data = row.Field<string>("Data"),
                    Suma = row.Field<double>("Suma")
                }).FirstOrDefault();

            tranzactie.masina = this.ExecuteQuery($"SELECT * FROM Masini m, Modele md, Producatori pd " 
                                              + $"WHERE m.ModelID = md.ModelID AND md.ProducatorID = pd.ProducatorID AND m.MasinaID={tranzactie.MasinaID}").AsEnumerable().Select(row =>
                                new Masina
                                {
                                    MasinaID = row.Field<int>("MasinaID"),
                                    Model = row.Field<string>("NumeModel"),
                                    Producator = row.Field<string>("NumeProducator"),
                                    ModelID = row.Field<int>("ModelID"),
                                    Pret = row.Field<int>("Pret"),
                                    Motorizare = row.Field<string>("Motorizare"),
                                    Combustibil = row.Field<string>("Combustibil"),
                                    Culoare = row.Field<string>("Culoare"),
                                    AnFabricatie = row.Field<string>("AnFabricatie"),
                                    KM = row.Field<int>("KM"),
                                    Descriere = row.Field<string>("Descriere")
                                }).FirstOrDefault();

            tranzactie.angajat = this.ExecuteQuery($"SELECT * FROM Angajati WHERE AngajatID={tranzactie.AngajatID};").AsEnumerable().Select(row =>
                                new Angajat
                                {
                                    AngajatID = row.Field<int>("AngajatID"),
                                    Nume = row.Field<string>("Nume"),
                                    Prenume = row.Field<string>("Prenume"),
                                    Email = row.Field<string>("Email"),
                                    Adresa = row.Field<string>("Adresa"),
                                    Telefon = row.Field<string>("Telefon")
                                }).FirstOrDefault();
            tranzactie.client = this.ExecuteQuery($"SELECT * FROM Clienti WHERE ClientID={tranzactie.ClientID};").AsEnumerable().Select(row =>
                                new Client
                                {
                                    ClientID = row.Field<int>("ClientID"),
                                    Nume = row.Field<string>("Nume"),
                                    Prenume = row.Field<string>("Prenume"),
                                    Email = row.Field<string>("Email"),
                                    Adresa = row.Field<string>("Adresa"),
                                    Telefon = row.Field<string>("Telefon")
                                }).FirstOrDefault();

            return tranzactie;
        }

        // Functie care returneaza dupa ID din baza de date masina pentru care se creaza o tranzactie
        public Tranzactie GetForCreate(int id)
        {
            var query = $"SELECT MasinaID, Pret from Masini WHERE MasinaID={id}";
            var dataTable = this.ExecuteQuery(query);
            var tranzactie = dataTable.AsEnumerable().Select(row =>
            new Tranzactie
            {
                MasinaID = row.Field<int>("MasinaID"),
                Suma = row.Field<int>("Pret")
            }).FirstOrDefault();

            return tranzactie;
        }

        // Functie care insereasa o noua tranzactie in baza de date
        public void InsertTranzactie(Tranzactie tranzactie)
        {
            DateTime data = DateTime.UtcNow.Date;
            var query = $"INSERT INTO Tranzactii(AngajatID, ClientID, MasinaID, Data, Suma) " +
                        $"VALUES({tranzactie.AngajatID}, {tranzactie.ClientID}, {tranzactie.MasinaID}, " +
                        $"'{data}', {tranzactie.Suma})";

            this.ExecuteQuery(query);
        }

        // Functie care sterge o tranzactie din baza de date dupa ID
        public void RemoveTranzactie(int id)
        {
            var query = $"DELETE FROM Tranzactii where TranzactieID={id}";
            this.ExecuteQuery(query);
        }
    }
}
