using System.Text.RegularExpressions;

namespace GenshinCodeFinder;

public class GenshinCodesHelper
{
    public static List<string> FindCodesInTweet(string tweet)
    {
        MatchCollection promoCodes = Regex.Matches(tweet, """"([0-9A-Z]{12})"""");
        return promoCodes.Select(x => x.Value).ToList();
    }
}