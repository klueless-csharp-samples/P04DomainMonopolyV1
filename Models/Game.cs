namespace P04DomainMonopolyV1.Models
{
  using System.Collections.Generic;
  
  /*
  Game is a stateful representation of a game.
  */
  public class Game
  {
    public int Id { get; set; }

    // Players in this game
    public List<Player> Players { get; } = new List<Player>();
  }
}
