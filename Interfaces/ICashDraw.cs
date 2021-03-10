namespace P04DomainMonopolyV1.Interfaces
{
  /*
  Cashdraw represents the number of each type of monetary note that 
  the player or bank has available
  */
  public class ICashDraw
  {

    int Notes500 { get; set; }

    int Notes100 { get; set; }

    int Notes50 { get; set; }

    int Notes20 { get; set; }

    int Notes10 { get; set; }

    int Notes1 { get; set; }

  }
}
