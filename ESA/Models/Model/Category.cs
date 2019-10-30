using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class Category
    {
        public string Name { get; set; }
        public Category Parent { get; set; }

        internal List<Category> GetCategories(int id)
        {
            Category eyelid = new Category() { Name = "Eyelid /", Parent = null };

            List<List<Category>> categoriesList = new List<List<Category>>()
            {
                // Tarso Hughes
                new List<Category>()
                {
                    eyelid,
                    new Category()
                    {
                        Name = "Tumour Surgery /",
                        Parent = eyelid
                    },
                    new Category()
                    {
                        Name = "Eyelid Reconstuction",
                        Parent = eyelid
                    }
                },
                // Tenzel
                new List<Category>()
                {
                    eyelid,
                    new Category()
                    {
                        Name = "Lower Lid Tightning /",
                        Parent = eyelid
                    },
                    new Category()
                    {
                        Name = "Facial Nerve Palsy",
                        Parent = eyelid
                    }
                },
                // FTS Graft
                new List<Category>()
                {
                    eyelid,
                    new Category()
                    {
                        Name = "Lower Lid Retraction /",
                        Parent = eyelid
                    },
                    new Category()
                    {
                        Name = "Entropion /",
                        Parent = eyelid
                    }
                },
            };

            return categoriesList[id];
        }
    }
}