namespace CFTFTDD.CORE.TEST
{
  public class PlayerModel
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ShirtNumber { get; set; }
    public string LineupLabel
    {
      get { return string.Format("#{0} {1} {2}", ShirtNumber, FirstName, LastName); }
    }
  }
}