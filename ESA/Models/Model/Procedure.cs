using ESA.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Models.Model
{
    public class Procedure
    {
        #region json
        [JsonProperty("$id", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public int JsonId { get; set; }
        [JsonProperty("procedureID", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }
        [JsonProperty("longName", NullValueHandling = NullValueHandling.Ignore)]
        public string LongName { get; set; }
        [JsonProperty("shortName", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortName { get; set; }
        [JsonProperty("videoSource", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoSource { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Step> Steps { get; set; }
        [JsonProperty("keypoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeyPoint> KeyPoints { get; set; }
        [JsonProperty("variations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Variation> Variations { get; set; }
        [JsonProperty("complications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Complication> Complications { get; set; }
        [JsonProperty("histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<History> History { get; set; }
        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<Reference> References { get; set; }
        [JsonProperty("procedures", NullValueHandling = NullValueHandling.Ignore)]
        public List<Procedure> Procedures { get; set; }
        // Have to check
        [JsonProperty("procedure1", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelatedProcedure> RelatedProcedures { get; set; }
        #endregion
        //public Detail Details { get; set; }


        #region OldHardCoded
        //public Procedure GetProcedure(int id)
        //{
        //    Procedure p = new Procedure();
        //    switch (id)
        //    {
        //        case 0:
        //            // Tarso hughes flap
        //            p = new Procedure()
        //            {
        //                Id = 0,
        //                LongName = "",
        //                ShortName = "",
        //                VideoSource = "",
        //                Details = new Detail().GetDetails(id),
        //                Steps = null,
        //                KeyPoints = null,
        //                Variations = null,
        //                Complications = null,
        //                History = null,
        //                References = null,
        //                RelatedProcedures = new RelatedProcedure().GetRelatedProcedures(id)
        //            };
        //            break;

        //        case 1:
        //            // Tenzel
        //            p = new Procedure()
        //            {
        //                Id = 1,
        //                LongName = "",
        //                ShortName = "",
        //                VideoSource = "",
        //                Details = new Detail().GetDetails(id),
        //                Steps = null,
        //                KeyPoints = null,
        //                Variations = null,
        //                Complications = null,
        //                History = null,
        //                References = null,
        //                RelatedProcedures = new RelatedProcedure().GetRelatedProcedures(id)
        //            };
        //            break;

        //        case 2:
        //            // Full thickness Skin graft
        //            p = new Procedure()
        //            {
        //                Id = 2,
        //                LongName = "",
        //                ShortName = "",
        //                VideoSource = "",
        //                Details = new Detail().GetDetails(id),
        //                Steps = null,
        //                KeyPoints = null,
        //                Variations = null,
        //                Complications = null,
        //                History = null,
        //                References = null,
        //                RelatedProcedures = new RelatedProcedure().GetRelatedProcedures(id)
        //            };
        //            break;
        //    }

        //    return p;
        //}        
        #endregion


    }
}
