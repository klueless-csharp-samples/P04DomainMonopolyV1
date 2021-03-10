namespace P04DomainMonopolyV1.Models
{
  using System.Collections.Generic;
  
  /*
  Action represents a sequential action that was taken during the game.
  */
  public class Activity
  {
    public int Id { get; set; }

    public Game Game { get; set; }

    public string ActionTaken { get; set; }
  }
}
