namespace P04DomainMonopolyV1.Services
{
  using System.Collections.Generic;
  
  // Player passes Go
  // 
  // Each time a player's token lands on or passes over  GO,
  // whether by throwing the dice or drawing a card, the Banker
  // pays him/her a $200 salary.

  // The $200 is paid only once each time around the board.
  // However, if a player passing GO on the throw of the dice
  // lands 2 spaces beyond it it on Community Chest, or 7 spaces
  // beyond it on Chance, and draws the "Advance to GO" card, he/she collects
  // $200 for passing GO the first time and another $200 for reaching it the
  // second time by instructions on the card.
  public class PassingGo
  {
  }
}
