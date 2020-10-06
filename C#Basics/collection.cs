using System.Collections.Generic;

public class collections
{
    public void LearnAboutList()
    {
        List<string> something = new List<string> {"shyam", "hari"};

        List<string> names = new List<string>();
        names.Add("Bijen");
        names.Add("akf");
        names.Add("Bijasfen");
        names.Add("Bijeafsn");

        names.Sort();
    }

    public void LearnAboutDictionary()
    {
        // Holds key-value pairs
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            ["Bhutan"] = "Thimpu",
            ["China"] = "Beijing"
        };
        
        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("USA", "WDC");
        countryCapitals.Add("Russia", "Mosco");
    }
}