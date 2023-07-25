using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public Models Model { get; set; }
        public string Year { get; set; } = String.Empty;
        public string Engine { get; set; } = String.Empty;

    
        public List<string> GetYearsForModel(Models model)
        {
            return Years[model.ToString()];
        }

        public List<string> GetEnginesForModel(Models model)
        {
            return Engines[model.ToString()];
        }

        public IDictionary<string, List<string>> Years = new Dictionary<string, List<string>>()
        {
            {"Cosmo", new List<string>() { "1990 - 1995"} },
            {"Miata", new List<string>() { "1990 - 1993", "1994 - 1997", "1999 - 2000", "2001 - 2005", "2006 - 2013", "2015 - now"} },
            {"RX7", new List<string>() { "1978 - 1985", "1985 - 1992", "1992 - 2002"} },
            {"RX8", new List<string>() { "2004 - 2008", "2009 - 2011"} }
        };

        public IDictionary<string, List<string>> Engines = new Dictionary<string, List<string>>()
        {
            {"Cosmo", new List<string>() { "20B"} },
            {"Miata", new List<string>() { "1.6", "1.8", "2.0"} },
            {"RX7", new List<string>() { "13B-REW"} },
            {"RX8", new List<string>() { "13B-MSP"} }
        }
        ;

    }


}

public enum Models
{
    Cosmo,
    Miata,
    RX7,
    RX8
}

