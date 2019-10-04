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

        // Author: Jason Wen Lee
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
            //database.DropTable<StepsModel>();
            //database.DropTable<VariationsModel>();
            //database.DropTable<KeyPointsModel>();

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
        //-----------------------------------------------------------------------------//
        // Get list of lacrimal procedures
        public List<Lacrimal>GetListLacrimalProcedures()
        {
            return database.Table<Lacrimal>().ToList();
        }
        // Get list of orbital procedures
        public List<Orbital> GetListOrbitalProcedures()
        {
            return database.Table<Orbital>().ToList();
        }
        // Get list of eyelid procedures
        public List<Eyelid> GetListEyelidProcedures()
        {
            return database.Table<Eyelid>().ToList();
        }
        //-----------------------------------------------------------------------------//
        // Get a lacrimal procedure based on id
        public Lacrimal GetLacrimalByID(int id)
        {
            return database.Table<Lacrimal>().Where(i => i.ID == id).FirstOrDefault();
        }
        // Get a orbital procedure based on id
        public Orbital GetOrbitalByID(int id)
        {
            return database.Table<Orbital>().Where(i => i.ID == id).FirstOrDefault();
        }
        // Get a eyelid procedure based on id
        public Eyelid GetEyelidByID(int id)
        {
            return database.Table<Eyelid>().Where(i => i.ID == id).FirstOrDefault();
        }

        //-----------------------------------------------------------------------------//
        // Get a lacrimal procedure based on name
        public Lacrimal GetLacrimalByName(Lacrimal proc)
        {
            return database.GetWithChildren<Lacrimal>(proc.ID);
        }
        // Get a orbital procedure based on name
        public Orbital GetOrbitalByName(Orbital proc)
        {
            return database.GetWithChildren<Orbital>(proc.ID);
        }
        // Get a eyelid procedure based on name
        public Eyelid GetEyelidByName(Eyelid proc)
        {
            return database.GetWithChildren<Eyelid>(proc.ID);
        }

        //-----------------------------------------------------------------------------//
        // Delete procedure based on procedure type.
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

        //-----------------------------------------------------------------------------//
        // Save procedure based on procedure type.
        public int SaveProcedure(Procedure item)
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

        //-----------------------------------------------------------------------------//
        // Save steps with additional procedure type.
        public int SaveSteps(StepsModel steps, Procedure proc)
        {
            if (steps != null)
            {
                if (steps.ID != 0)
                {
                    database.Update(steps);
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
                else
                {
                    database.Insert(steps);
                    if (proc is Lacrimal)
                    {
                        steps.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(steps);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        steps.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(steps);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        steps.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(steps);
                        return 1;
                    }
                }
            }
            throw new ArgumentNullException();
        }

        //-----------------------------------------------------------------------------//
        // Save variations with additional procedure type.
        public int SaveVariations(VariationsModel variations, Procedure proc)
        {
            if (variations != null)
            {
                if (variations.ID != 0)
                {
                    database.Update(variations);
                    if (proc is Lacrimal)
                    {
                        variations.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(variations);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        variations.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(variations);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        variations.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(variations);
                        return 1;
                    }
                }
                else
                {
                    database.Insert(variations);
                    if (proc is Lacrimal)
                    {
                        variations.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(variations);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        variations.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(variations);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        variations.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(variations);
                        return 1;
                    }
                }
            }
            throw new ArgumentNullException();
        }

        //-----------------------------------------------------------------------------//
        // Save key points with additional procedures
        public int SaveKeyPoints(KeyPointsModel keyPoints, Procedure proc)
        {
            if (keyPoints != null)
            {
                if (keyPoints.ID != 0)
                {
                    database.Update(keyPoints);
                    if (proc is Lacrimal)
                    {
                        keyPoints.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(keyPoints);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        keyPoints.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(keyPoints);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        keyPoints.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(keyPoints);
                        return 1;
                    }
                }
                else
                {
                    database.Insert(keyPoints);
                    if (proc is Lacrimal)
                    {
                        keyPoints.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(keyPoints);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        keyPoints.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(keyPoints);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        keyPoints.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(keyPoints);
                        return 1;
                    }
                }
            }
            throw new ArgumentNullException();
        }

        //-----------------------------------------------------------------------------//
        // Save key points with additional procedures
        public int SaveComplications(ComplicationsModel complications, Procedure proc)
        {
            if (complications != null)
            {
                if (complications.ID != 0)
                {
                    database.Update(complications);
                    if (proc is Lacrimal)
                    {
                        complications.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(complications);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        complications.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(complications);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        complications.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(complications);
                        return 1;
                    }
                }
                else
                {
                    database.Insert(complications);
                    if (proc is Lacrimal)
                    {
                        complications.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(complications);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        complications.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(complications);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        complications.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(complications);
                        return 1;
                    }
                }
            }
            throw new ArgumentNullException();
        }        
        
        //-----------------------------------------------------------------------------//
        // Save key points with additional procedures
        public int SaveHistory(HistoryModel history, Procedure proc)
        {
            if (history != null)
            {
                if (history.ID != 0)
                {
                    database.Update(history);
                    if (proc is Lacrimal)
                    {
                        history.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(history);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        history.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(history);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        history.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(history);
                        return 1;
                    }
                }
                else
                {
                    database.Insert(history);
                    if (proc is Lacrimal)
                    {
                        history.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(history);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        history.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(history);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        history.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(history);
                        return 1;
                    }
                }
            }
            throw new ArgumentNullException();
        }        
        
        //-----------------------------------------------------------------------------//
        // Save key points with additional procedures
        public int SaveReferences(ReferencesModel references, Procedure proc)
        {
            if (references != null)
            {
                if (references.ID != 0)
                {
                    database.Update(references);
                    if (proc is Lacrimal)
                    {
                        references.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(references);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        references.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(references);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        references.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(references);
                        return 1;
                    }
                }
                else
                {
                    database.Insert(references);
                    if (proc is Lacrimal)
                    {
                        references.LacrimalProcedure = new List<Lacrimal> { (Lacrimal)proc };
                        database.UpdateWithChildren(references);
                        return 1;
                    }
                    else if (proc is Orbital)
                    {
                        references.OrbitalProcedure = new List<Orbital> { (Orbital)proc };
                        database.UpdateWithChildren(references);
                        return 1;
                    }
                    else if (proc is Eyelid)
                    {
                        references.EyelidProcedure = new List<Eyelid> { (Eyelid)proc };
                        database.UpdateWithChildren(references);
                        return 1;
                    }
                }
            }
            throw new ArgumentNullException();
        }
    }
}
