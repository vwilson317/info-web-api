public class StatisticsDto
{
    public int Count {get;set;}
    public List<string> Countries => new List<string>();
    public Decimal DollarsSpent {get;set;}
}