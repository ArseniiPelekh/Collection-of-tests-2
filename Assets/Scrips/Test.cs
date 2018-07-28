using SQLite4Unity3d;

public class Test
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Ask { get; set; }
    public int Answer { get; set; }
}
