using Dealership_Auto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Auto.Repository
{
    public class MasinaRepository: BaseRepository
    {
        // Functie care returneaza o lista cu toate masinile care au Producatorul sau Modelul search
        public IList<Masina> GetMasini(string searchBy, string search)
        {
            if(searchBy == "Producator")
            {
                var dataTable = this.ExecuteQuery("SELECT * FROM Masini m, Modele md, Producatori pd "
                                              + $"WHERE m.ModelID = md.ModelID AND md.ProducatorID = pd.ProducatorID and pd.NumeProducator LIKE '%{search}%'");
                IList<Masina> listaMasini = dataTable.AsEnumerable().Select(row =>
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
                    }).ToList();

                return listaMasini ?? new List<Masina>();
            }
            else
            {
                var dataTable = this.ExecuteQuery("SELECT * FROM Masini m, Modele md, Producatori pd "
                                              + $"WHERE m.ModelID = md.ModelID AND md.ProducatorID = pd.ProducatorID and md.NumeModel LIKE '%{search}%'");
                IList<Masina> listaMasini = dataTable.AsEnumerable().Select(row =>
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
                    }).ToList();

                return listaMasini ?? new List<Masina>();
            }
            
        }

        // Functie care returneaza din baza de date o masina dupa ID
        public Masina GetMasina(int id)
        {
            var dataTable = this.ExecuteQuery("SELECT * FROM Masini m, Modele md, Producatori pd "
                                              + $"WHERE m.ModelID = md.ModelID AND md.ProducatorID = pd.ProducatorID AND m.MasinaID={id};");
            Masina masina = dataTable.AsEnumerable().Select(row =>
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

            return masina;
        }

        // Funcite care insereaza o masina in baza de date
        public void InsertMasina(Masina masina)
        {
            var modelID = this.SearchModelMasina(masina.Model);
            if (modelID == 0)
                return;

            var query = "INSERT INTO Masini(ModelID, Pret, Motorizare, Combustibil, Culoare, AnFabricatie, KM, Descriere)" +
                        $"VALUES({modelID}, {masina.Pret}, '{masina.Motorizare}', '{masina.Combustibil}', '{masina.Culoare}', '{masina.AnFabricatie}', {masina.KM}, '{masina.Descriere}')";
            this.ExecuteQuery(query);
        }

        // Functie care cauta modelul masinii dupa searchString
        public int SearchModelMasina(string searchString)
        {
            var query = "SELECT ModelID FROM Modele " +
                        $"WHERE NumeModel='{searchString}'";
            var dataTable = this.ExecuteQuery(query);
            var modelID = dataTable.AsEnumerable().Select(row => row.Field<int>("ModelID")).FirstOrDefault();

            return modelID; 
        }

        // Functie care sterge o masina din baza de date dupa ID
        public void DeleteMasina(int id)
        {
            var query = $"delete from Masini where MasinaID = {id}";
            this.ExecuteQuery(query);
        }
        // Functie care efectueaza operatia de UPDATE pe o masina din baza de date dupa ID

        public void EditMasina(Masina masina)
        {
            var query = $"UPDATE Masini SET Pret = {masina.Pret}, Motorizare='{masina.Motorizare}', Combustibil='{masina.Combustibil}', " +
                        $"Culoare='{masina.Culoare}', AnFabricatie='{masina.AnFabricatie}', KM={masina.KM}, Descriere='{masina.Descriere}'"+
                        $" WHERE MasinaID={masina.MasinaID}";
            this.ExecuteQuery(query);
        }

    }
}
