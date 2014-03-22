using CFTFTDD.CF.WEB;

namespace CFTFTDD.WEB.TEST
{
  public class PlayerModel : Player
  {
    public string FullName
    {
      get { return string.Format("{0} {1}", FirstName, LastName); }
    }
  }
}