namespace P04DomainMonopolyV1.Services
{
  using System.Collections.Generic;
  
  // You land in Jail when ...
  // - (1) [pred] your token lands on the space marked "Go to Jail";
  // - (2) [pred] you draw a card marked "Go to Jail"; or
  // - (3) [pred] you throw doubles three times in succession.
  // 
  // When you are sent to Jail you cannot collect your $200 salary in that move since, regardless of where your token is on the board, you must move it a directly into Jail. Your turn ends when you are sent to Jail.
  // 
  // 
  public class GoToJail
  {
  }
}
