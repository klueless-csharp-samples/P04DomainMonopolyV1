namespace P04DomainMonopolyV1.Values
{
  using System;
  
  /*
  Square represents any square on the monopoly board.
  */
  public record Square(int Index, string NameUs, string NameUk);

  /*
  SquareLand represents land or property that you can build houses and hotels on
  */
  public record SquareLand(int Index, string Group, string NameUs, string NameUk) :
                Square(Index, NameUs, NameUk);


  /*
  SquareRail represents Rail Roads
  */
  public record SquareRail(int Index, string Group, string NameUs, string NameUk) :
                Square(Index, NameUs, NameUk);

  /*
  SquareUtility represents Utilities (Gas & Water)
  */
  public record SquareUtility(int Index, string Group, string NameUs, string NameUk) :
                Square(Index, NameUs, NameUk);

  /*
  SquareIncomeTax represents income tax
  */
  public record SquareIncomeTax(int Index) :
                Square(Index, NameUs: "Income Tax", NameUk: "Income Tax");

  /*
  SquareSuperTax represents super tax
  */
  public record SquareSuperTax(int Index) :
                Square(Index, NameUs: "Super Tax", NameUk: "Super Tax");
  
  /*
  SquareGo represents the starting square
  */
  public record SquareGo(int Index) :
                Square(Index, NameUs: "Go", NameUk: "Go");

  /*
  SquareGo represents the starting square
  */
  public record SquareGoToJail(int Index) :
                Square(Index, NameUs: "Go To Jail", NameUk: "Go To Gaol");
  
  /*
  SquareFreeParking represents the starting square
  */
  public record SquareFreeParking(int Index) :
                Square(Index, NameUs: "FreeParking", NameUk: "FreeParking");
  
  /*
  SquareCommunityChest represents community chest card for pickup
  */
  public record SquareCommunityChest(int Index) :
                Square(Index, NameUs: "Community Chest", NameUk: "Community Chest");

  /*
  SquareChance represents chance card for pickup
  */
  public record SquareChance(int Index) :
                Square(Index, NameUs: "Chance", NameUk: "Chance");

  /*
  SquareJail represents Jail card for pickup
  */
  public record SquareJail(int Index) :
                Square(Index, NameUs: "Jail", NameUk: "Gaol");
}
