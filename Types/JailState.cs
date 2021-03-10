namespace P04DomainMonopolyV1.Models
{
  /*
  A player is either free or in jail for a period of time

  This is a good place for a state machine pattern
  */
  public enum JailState
  {
    Freedom,

    Turn1,

    Turn2,

    Turn3
  }
}
