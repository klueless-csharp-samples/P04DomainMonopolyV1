namespace P04DomainMonopolyV1.Interfaces
{
  using System.Collections.Generic;

  /*
  Deck of chance or community chest cards
  */
  public class IDeckOfCards
  {
    public List<ICard> Deck { get; set; }
  }
}
