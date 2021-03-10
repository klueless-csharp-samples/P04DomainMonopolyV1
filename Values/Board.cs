namespace P04DomainMonopolyV1.Values
{
  using System;
  using System.Collections.Generic;

  /*
  Board represents the structural layout of a Monopoly board
  */
  public record Board(
    List<Square> Squares,
    List<string> Pieces,
    List<ChanceCard> Chances,
    List<CommunityChestCard> CommunityChests,
    int Houses,
    int Hotels,
    List<Rule> Rules);


}
