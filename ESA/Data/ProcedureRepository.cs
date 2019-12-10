using ESA.Models.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.IO;

namespace ESA.Data
{
    // Author: Wen Loong Lee, Rodrigo Echeverria

    // This class contains the database controller for all procedures. These procedures are categorised into
    // Lacrimal, Orbital, and Eyelid. The controller can do the following:
    // - Get a list of lacrimal procedure, a list of orbital procedure, or a list of eyelid procedure
    // - Get a lacrimal procedure, an orbital procedure, or an eyelid procedure based on name or ID
    // - Save a procedure with its category, name, description, complications, history, key points, references, steps, and variations

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
            //database.DropTable<Lacrimal>();
            //database.DropTable<Orbital>();
            //database.DropTable<Eyelid>();
            //Create lacrimal table
            //database.CreateTable<Lacrimal>();
            // Create orbital table
            //database.CreateTable<Orbital>();
            // Create eyelid table
            //database.CreateTable<Eyelid>();
        }

        //-----------------------------------------------------------------------------//
        // Get a list of procedures depending on the category
        public List<Procedure> GetListLacrimalProcedures()
        {
            return database.Table<Procedure>().ToList();
        }
        public List<Procedure> GetListOrbitalProcedures()
        {
            return database.Table<Procedure>().ToList();
        }
        public List<Procedure> GetListEyelidProcedures()
        {
            return database.Table<Procedure>().ToList();
        }

        //-----------------------------------------------------------------------------//
        // Get a procedure based on id and category. 
        public Procedure GetLacrimalByID(int id)
        {
            return database.Table<Procedure>().Where(i => i.Id == id).FirstOrDefault();
        }
        public Procedure GetOrbitalByID(int id)
        {
            return database.Table<Procedure>().Where(i => i.Id == id).FirstOrDefault();
        }
        public Procedure GetEyelidByID(int id)
        {
            return database.Table<Procedure>().Where(i => i.Id == id).FirstOrDefault();
        }

        //-----------------------------------------------------------------------------//
        // Get a procedure based on name and category
        public Procedure GetLacrimalByName(Procedure proc)
        {
            return database.GetWithChildren<Procedure>(proc.Id);
        }
        public Procedure GetOrbitalByName(Procedure proc)
        {
            return database.GetWithChildren<Procedure>(proc.Id);
        }
        public Procedure GetEyelidByName(Procedure proc)
        {
            return database.GetWithChildren<Procedure>(proc.Id);
        }

        //-----------------------------------------------------------------------------//
        // The following functions perform saving.
        public int SaveProcedure(Procedure proc)
        {
            return database.Insert(proc);
        }

        //-----------------------------------------------------------------------------//
        // The following functions perform updating on exising procedure
        public int UpdateProcedure(Procedure proc)
        {
            return database.Update(proc);
        }

        //-----------------------------------------------------------------------------//
        // Delete procedure based on procedure type. 
        // Note: No use yet.
        public int DeleteProcedure(Procedure item)
        {
            if (item != null)
            {
                if (item is Procedure)
                {
                    Procedure lac = (Procedure)item;
                    return database.Delete(item);
                }
                else if (item is Procedure)
                {
                    Procedure orb = (Procedure)item;
                    return database.Delete(orb);
                }
                else if (item is Procedure)
                {
                    Procedure eye = (Procedure)item;
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
