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

    // This class handles the database controller for Lacrimal procedures. The controller can grab a list of Lacrimal
    // procedures or a procedure based on ID. It can also delete lacrimal procedure or save new procedure.

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
            database.DropTable<StepsModel>();
            database.DropTable<VariationsModel>();
            database.DropTable<KeyPointsModel>();
            
            // Create lacrimal table
            database.CreateTable<Lacrimal>();
            // Create orbital table
            database.CreateTable<Orbital>();
            // Create eyelid table
            database.CreateTable<Eyelid>();

            database.CreateTable<StepsModel>();
            database.CreateTable<VariationsModel>();
            database.CreateTable<KeyPointsModel>();
        }

        // Get list of lacrimal procedures
        public List<Lacrimal>GetListLacrimalProceduresAsync()
        {
            return database.Table<Lacrimal>().ToList();
        }

        // Get list of orbital procedures
        public List<Orbital> GetListOrbitalProceduresAsync()
        {
            return database.Table<Orbital>().ToList();
        }

        // Get list of eyelid procedures
        public List<Eyelid> GetListEyelidProceduresAsync()
        {
            return database.Table<Eyelid>().ToList();
        }

        // Get a lacrimal procedure based on id
        public Lacrimal GetLacrimalProcedureAsync(int id)
        {
            return database.Table<Lacrimal>().Where(i => i.ID == id).FirstOrDefault();
        }

        public Lacrimal GetLacrimalNameAsync(string name)
        {
            return database.Table<Lacrimal>().Where(i => i.Name == name).FirstOrDefault();
        }

        // Get a orbital procedure based on id
        public Orbital GetOrbitalProcedureAsync(int id)
        {
            return database.Table<Orbital>().Where(i => i.ID == id).FirstOrDefault();
        }

        // Get a eyelid procedure based on id
        public Eyelid GetEyelidProcedureAsync(int id)
        {
            return database.Table<Eyelid>().Where(i => i.ID == id).FirstOrDefault();
        }

        // Delete procedure based on procedure type.
        public int DeleteProcedureAsync(Procedure item)
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

        // Save procedure based on procedure type.
        public int SaveProcedureAsync(Procedure item)
        {
            if (item != null)
            {
                if (item is Lacrimal)
                {
                    Lacrimal lac = (Lacrimal)item;
                    if (lac.ID != 0)
                    {
                        return database.Update(lac);
                        
                    }
                    else
                    {
                        return database.Insert(lac);
                    }
                }
                else if (item is Orbital)
                {
                    Orbital orb = (Orbital)item;
                    if (orb.ID != 0)
                    {
                        return database.Update(orb);
                    }
                    else
                    {
                        return database.Insert(orb);
                    }
                }
                else if (item is Eyelid)
                {
                    Eyelid eye = (Eyelid)item;
                    if (eye.ID != 0)
                    {
                        return database.Update(eye);
                    }
                    else
                    {
                        return database.Insert(eye);
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            throw new ArgumentNullException();
        }
       
        // Save steps with additional procedure type.
        public int SaveStepsAsync(StepsModel steps, Procedure proc)
        {
            if (steps != null)
            {
                if (steps.ID != 0)
                {
                    if (proc == null)
                    {
                        return database.Update(steps);
                    }
                    else
                    {
                        if (proc is Lacrimal)
                        {
                            steps.LacrimalProcedure = new List<Lacrimal> { (Lacrimal) proc };
                            database.UpdateWithChildren(steps);
                            return 1;
                        }
                        else if (proc is Orbital)
                        {
                            steps.OrbitalProcedure = new List<Orbital> { (Orbital) proc };
                            database.UpdateWithChildren(steps);
                            return 1;
                        }
                        else if (proc is Eyelid)
                        {
                            steps.EyelidProcedure = new List<Eyelid> { (Eyelid) proc };
                            database.UpdateWithChildren(steps);
                            return 1;
                        }
                    }
                }
                else
                {
                    if (proc == null)
                    {
                        return database.Insert(steps);
                    }
                    else
                    {
                        if (proc is Lacrimal)
                        {
                            steps.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                            database.InsertWithChildren(steps);
                            return 1;
                        }
                        else if (proc is Orbital)
                        {
                            steps.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                            database.InsertWithChildren(steps);
                            return 1;
                        }
                        else if (proc is Eyelid)
                        {
                            steps.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                            database.InsertWithChildren(steps);
                            return 1;
                        }
                    }
                }
            }
            throw new ArgumentNullException();
        }

    }
}
