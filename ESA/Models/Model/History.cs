using System;
using System.Collections.Generic;

namespace ESA.Models.Model
{
    public class History
    {
        public string Body { get; set; }
        public string References { get; set; }

        internal List<History> GetHistory(int id)
        {
            List<History> history = new List<History>();
            switch (id)
            {
                case 0:
                    // Tarso
                    history = new List<History>()
                    {
                        new History()
                        {
                            Body = "Dr Wendel Hughes, an ophthalmologist who contributed to the field of oculoplastic surgery, published his first paper on tarsoconjunctival flaps in 1937.",
                            References = "[1,2]"
                        },
                        new History()
                        {
                            Body = "Further modifications to the technique by Hughes and others occurred throughout subsequent decades. Significant developments included using full-thickness skin grafting of the tarsoconjunctival flap, sparing of the marginal upper lid tarsus, and removal of the levator muscle complex from the tarsoconjunctival flap.  This led to the reduction in upper lid complications, such as upper lid retraction, entropion, and trichiasis. ​",
                                References = "[3-6]"
                        },
                        new History()
                        {
                            Body = "Traditionally, flap division occurred 3 to 4 months after the initial stage.  Currently the standard time to flap division is frequently 2 weeks,  but can be carried out from 7 days with good outcome.",
                            
                                References = "[7,8]"
                            
                        }
                    };
                    break;
                case 1:
                    // Tenzel
                    history = new List<History>()
                    {
                        new History()
                        {
                            Body = "Eponymous flap named after Richard R Tenzel in 1975",
                            References = "[1]"
                        },
                        new History()
                        {
                            Body = "Performed 41 eyelid reconstructions following tumour excision – 36 lower lid and 4 upper lid",
                            References = null
                        },
                    };
                    break;

                case 2:
                    // Graft
                    history = new List<History>()
                    {
                        new History()
                        {
                            Body = "Wolfe is credited with introducing full-thickness skin graft ectropion repair in 1875. However, other authors have also published papers in the use of full-thickness skin grafts for ectropion repair (Lawson, 1870; Le Fort, 1872; Ollier, 1872).",
                            References = "[1-5]"
                        },
                        new History()
                        {
                            Body = "Krause popularised the use of full-thickness grafts, hence the eponymous name of ‘Wolfe-Krause graft’ for full-thickness grafts.",
                            References = "[5,6]"
                        },
                        new History()
                        {
                            Body = "Full-thickness skin grafts are commonly used to close anterior lamella defects.  They can be carried out on their own, in conjunction with other anterior lamella techniques, or along with posterior lamella reconstruction e.g. tarsoconjunctival flaps",
                            References = "[7-9]"
                        },
                        new History()
                        {
                            Body = "Further modifications to the technique have occurred, including the use of cyanoacrylate glue instead of sutures.",
                            References = "[10]"
                        }
                    };
                    break;
            }

            return history;
        }
    }
}