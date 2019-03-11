
public class Rootobject
{
    public int id { get; set; }
    public string name { get; set; }
    public string symbol { get; set; }
    public string slug { get; set; }
    public int circulating_supply { get; set; }
    public int total_supply { get; set; }
    public int max_supply { get; set; }
    public DateTime date_added { get; set; }
    public int num_market_pairs { get; set; }
    public string[] tags { get; set; }
    public object platform { get; set; }
    public int cmc_rank { get; set; }
    public DateTime last_updated { get; set; }
    public Quote quote { get; set; }
}

public class Quote
{
    public USD USD { get; set; }
}

public class USD
{
    public float price { get; set; }
    public float volume_24h { get; set; }
    public float percent_change_1h { get; set; }
    public float percent_change_24h { get; set; }
    public float percent_change_7d { get; set; }
    public float market_cap { get; set; }
    public DateTime last_updated { get; set; }
}

