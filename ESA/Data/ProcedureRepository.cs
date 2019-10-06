using ESA.Models;
using ESA.Models.PageModels;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ESA.Data
{
    // Author: Wen Loong Lee, Rodrigo Echeverria

    // This class contains the database controller for all procedures. These procedures are categorised into
    // Lacrimal, Orbital, and Eyelid. The controller can do the following:
    // - Get a list of lacrimal procedure, a list of orbital procedure, or a list of eyelid procedure
    // - Get a lacrimal procedure, an orbital procedure, or an eyelid procedure based on name or ID
    // - Save a procedure with its category, name, and description
    // - Save complications, history, key points, references, steps, and variations

    public class ProcedureRepository : IProcedureRepository
    {
        readonly SQLiteConnection database;
        string path;
        // Constructor creates path to database with a given name then establishes connection to it. 
        // A table containing Video objects is then created.
        public ProcedureRepository(string dbPath)
        {
            Console.WriteLine("Create Lacrimal database because empty");
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbPath);
            database = new SQLiteConnection(path);
            database.Execute("PRAGMA foreign_keys = ON");
            database.DropTable<Lacrimal>();
            database.DropTable<Orbital>();
            database.DropTable<Eyelid>();
            //Create lacrimal table
            database.CreateTable<Lacrimal>();
            // Create orbital table
            database.CreateTable<Orbital>();
            // Create eyelid table
            database.CreateTable<Eyelid>();
        }

        //-----------------------------------------------------------------------------//
        // Get a list of procedures depending on the category
        public List<Lacrimal>GetListLacrimalProcedures()
        {
            return database.Table<Lacrimal>().ToList();
        }
        public List<Orbital> GetListOrbitalProcedures()
        {
            return database.Table<Orbital>().ToList();
        }
        public List<Eyelid> GetListEyelidProcedures()
        {
            return database.Table<Eyelid>().ToList();
        }

        //-----------------------------------------------------------------------------//
        // Get a procedure based on id and category. 
        public Lacrimal GetLacrimalByID(int id)
        {
            return database.Table<Lacrimal>().Where(i => i.ID == id).FirstOrDefault();
        }
        public Orbital GetOrbitalByID(int id)
        {
            return database.Table<Orbital>().Where(i => i.ID == id).FirstOrDefault();
        }
        public Eyelid GetEyelidByID(int id)
        {
            return database.Table<Eyelid>().Where(i => i.ID == id).FirstOrDefault();
        }

        //-----------------------------------------------------------------------------//
        // Get a procedure based on name and category
        public Lacrimal GetLacrimalByName(Lacrimal proc)
        {
            return database.GetWithChildren<Lacrimal>(proc.ID);
        }
        public Orbital GetOrbitalByName(Orbital proc)
        {
            return database.GetWithChildren<Orbital>(proc.ID);
        }
        public Eyelid GetEyelidByName(Eyelid proc)
        {
            return database.GetWithChildren<Eyelid>(proc.ID);
        }

        //-----------------------------------------------------------------------------//
        // The following functions perform saving.
        public int SaveProcedure(Procedure proc)
        {
            return database.Insert(proc);
        }
        public void SaveSteps(StepsModel steps)
        {
            database.Insert(steps);
            database.UpdateWithChildren(steps);
        }
        public void SaveVariations(VariationsModel variations)
        {
            database.Insert(variations);
            database.UpdateWithChildren(variations);
        }
        public void SaveKeyPoints(KeyPointsModel keyPoints)
        {
            database.Insert(keyPoints);
            database.UpdateWithChildren(keyPoints);
        }
        public void SaveComplications(ComplicationsModel complications)
        {
            database.Insert(complications);
            database.UpdateWithChildren(complications);
        }
        public void SaveHistory(HistoryModel history)
        {
            database.Insert(history);
            database.UpdateWithChildren(history);
        }
        public void SaveReferences(ReferencesModel references)
        {
            database.Insert(references);
            database.UpdateWithChildren(references);
        }

        //-----------------------------------------------------------------------------//
        // The following functions perform updating on exising procedure
        public int UpdateProcedure(Procedure proc)
        {
            return database.Update(proc);
        }

        public void UpdateSteps(StepsModel steps)
        {
            database.Update(steps);
            database.UpdateWithChildren(steps);
        }

        public void UpdateVariations(VariationsModel variations)
        {
            database.Update(variations);
            database.UpdateWithChildren(variations);
        }

        public void UpdateKeyPoints(KeyPointsModel keyPoints)
        {
            database.Update(keyPoints);
            database.UpdateWithChildren(keyPoints);
        }

        public void UpdateComplications(ComplicationsModel complications)
        {
            database.Update(complications);
            database.UpdateWithChildren(complications);
        }

        public void UpdateHistory(HistoryModel history)
        {
            database.Update(history);
            database.UpdateWithChildren(history);
        }

        public void UpdateReferences(ReferencesModel references)
        {
            database.Update(references);
            database.UpdateWithChildren(references);
        }

        //-----------------------------------------------------------------------------//
        // Delete procedure based on procedure type. 
        // Note: No use yet.
        public int DeleteProcedure(Procedure item)
        {
            if (item != null)
            {
                if (item is Lacrimal)
                {
                    Lacrimal lac = (Lacrimal)item;
                    return database.Delete(item);
                }
                else if (item is Orbital)
                {
                    Orbital orb = (Orbital)item;
                    return database.Delete(orb);
                }
                else if (item is Eyelid)
                {
                    Eyelid eye = (Eyelid)item;
                    return database.Delete(eye);
                }
                else
                {
                    throw new FormatException();
                }
            }
            throw new ArgumentNullException();
        }


    }
}
