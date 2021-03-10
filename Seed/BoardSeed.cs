namespace P04DomainMonopolyV1.Seed
{
  using System.Collections.Generic;
  using P04DomainMonopolyV1.Values;

  public class BoardSeed
  {
    public static Board GetBoard()
    {
      return new Board(
        GetSquares(),
        new List<string>(Constants.Pieces),
        GetChances(),
        GetCommunityChests(),
        Houses: 32,
        Hotels: 12,
        Rules: GetRules()
      )
    }

    private static List<Rule> GetRules()
    {
      var result = new List<Rule>();

      
      return result;
    }

    public static List<Square> GetSquares()
    {
      var result = new List<Square>();

      var i = 1;

      result.Add(new SquareGo(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Maroon", NameUs: "Mediterranean Avenue", NameUk: "Old Kent Road"));
      result.Add(new SquareCommunityChest(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Maroon", NameUs: "Baltic Avenue", NameUk: "Whitechapel Road"));
      result.Add(new SquareIncomeTax(Index: i++));
      result.Add(new SquareRail(Index: i++, Group: "Rail", NameUs: "Reading Railroad", NameUk: "Kings Cross Station"));
      result.Add(new SquareLand(Index: i++, Group: "LightBlue", NameUs: "Oriental Avenue", NameUk: "The Angel Islington"));
      result.Add(new SquareChance(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "LightBlue", NameUs: "Vermont Avenue", NameUk: "Euston Road"));
      result.Add(new SquareLand(Index: i++, Group: "LightBlue", NameUs: "Connecticut Avenue", NameUk: "Pentonville Road"));
      result.Add(new SquareJail(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Pink", NameUs: "St Charles Place", NameUk: "Pall Mall"));
      result.Add(new SquareUtility(Index: i++, Group: "Utility", NameUs: "Electric Company", NameUk: "Electric Company"));
      result.Add(new SquareLand(Index: i++, Group: "Pink", NameUs: "States Avenue", NameUk: "Whitehall"));
      result.Add(new SquareLand(Index: i++, Group: "Pink", NameUs: "Virginia Avenue", NameUk: "Northumberland Avenue"));
      result.Add(new SquareRail(Index: i++, Group: "Rail", NameUs: "Pennsylvania Railroad", NameUk: "Marylebone Station"));
      result.Add(new SquareLand(Index: i++, Group: "Orange", NameUs: "St James Place", NameUk: "Bow Street"));
      result.Add(new SquareCommunityChest(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Orange", NameUs: "Tennessee Avenue", NameUk: "Marlborough Street"));
      result.Add(new SquareLand(Index: i++, Group: "Orange", NameUs: "New York Avenue", NameUk: "Vine Street"));
      result.Add(new SquareFreeParking(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Red", NameUs: "Kentucky Avenue", NameUk: "The Strand"));
      result.Add(new SquareChance(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Red", NameUs: "Indiana Avenue", NameUk: "Fleet Street"));
      result.Add(new SquareLand(Index: i++, Group: "Red", NameUs: "Illinois Avenue", NameUk: "Trafalgar Square"));
      result.Add(new SquareRail(Index: i++, Group: "Rail", NameUs: "B & O Railroad", NameUk: "Fenchurch Street Station"));
      result.Add(new SquareLand(Index: i++, Group: "Yellow", NameUs: "Atlantic Avenue", NameUk: "Leicester Square"));
      result.Add(new SquareLand(Index: i++, Group: "Yellow", NameUs: "Ventnor Avenue", NameUk: "Coventry Street"));
      result.Add(new SquareUtility(Index: i++, Group: "Utility", NameUs: "Water Works", NameUk: "Water Works"));
      result.Add(new SquareLand(Index: i++, Group: "Yellow", NameUs: "Marvin Gardens", NameUk: "Piccadilly"));
      result.Add(new SquareGoToJail(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Green", NameUs: "Pacific Avenue", NameUk: "Regent Street"));
      result.Add(new SquareLand(Index: i++, Group: "Green", NameUs: "North Carolina Avenue", NameUk: "Oxford Street"));
      result.Add(new SquareCommunityChest(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "Green", NameUs: "Pennsylvania Avenue", NameUk: "Bond Street"));
      result.Add(new SquareRail(Index: i++, Group: "Rail", NameUs: "Short Line Railroad", NameUk: "Liverpool Street Station"));
      result.Add(new SquareChance(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "NavyBlue", NameUs: "Park Place", NameUk: "Park Lane"));
      result.Add(new SquareSuperTax(Index: i++));
      result.Add(new SquareLand(Index: i++, Group: "NavyBlue", NameUs: "Boardwalk", NameUk: "Mayfair"));

      return result;
    }

    public static List<CommunityChestCard> GetCommunityChests()
    {
      var result = new List<CommunityChestCard>();

      result.Add(new CommunityChestCard("Advance to \"Go\". Collect $200."));
      result.Add(new CommunityChestCard("Bank error in your favor. Collect $200."));
      result.Add(new CommunityChestCard("Doctor's fees. Pay $50."));
      result.Add(new CommunityChestCard("From sale of stock you get $50."));
      result.Add(new CommunityChestCard("Get Out of Jail Free. This card may be kept until needed or sold/traded."));
      result.Add(new CommunityChestCard("Go to Jail. Go directly to jail. Do not pass Go, Do not collect $200."));
      result.Add(new CommunityChestCard("Grand Opera Night. Collect $50 from every player for opening night seats."));
      result.Add(new CommunityChestCard("Holiday Fund matures. Collect $100."));
      result.Add(new CommunityChestCard("Income tax refund. Collect $20."));
      result.Add(new CommunityChestCard("It's your birthday. Collect $10 from every player."));
      result.Add(new CommunityChestCard("Life insurance matures – Collect $100."));
      result.Add(new CommunityChestCard("Hospital Fees. Pay $50."));
      result.Add(new CommunityChestCard("School fees. Pay $50."));
      result.Add(new CommunityChestCard("Receive $25 consultancy fee."));
      result.Add(new CommunityChestCard("You are assessed for street repairs: Pay $40 per house and $115 per hotel you own."));
      result.Add(new CommunityChestCard("You have won second prize in a beauty contest. Collect $10."));
      result.Add(new CommunityChestCard("You inherit $100."));

      return result;
    }

    public static List<ChanceCard> GetChances()
    {
      var result = new List<ChanceCard>();

      result.Add(new ChanceCard("Advance to \"Go\". Collect $200."));
      result.Add(new ChanceCard("Bank error in your favor. Collect $200."));
      result.Add(new ChanceCard("Doctor's fees. Pay $50."));
      result.Add(new ChanceCard("From sale of stock you get $50."));
      result.Add(new ChanceCard("Get Out of Jail Free. This card may be kept until needed or sold/traded."));
      result.Add(new ChanceCard("Go to Jail. Go directly to jail. Do not pass Go, Do not collect $200."));
      result.Add(new ChanceCard("Grand Opera Night. Collect $50 from every player for opening night seats."));
      result.Add(new ChanceCard("Holiday Fund matures. Collect $100."));
      result.Add(new ChanceCard("Income tax refund. Collect $20."));
      result.Add(new ChanceCard("It's your birthday. Collect $10 from every player."));
      result.Add(new ChanceCard("Life insurance matures – Collect $100."));
      result.Add(new ChanceCard("Hospital Fees. Pay $50."));
      result.Add(new ChanceCard("School fees. Pay $50."));
      result.Add(new ChanceCard("Receive $25 consultancy fee."));
      result.Add(new ChanceCard("You are assessed for street repairs: Pay $40 per house and $115 per hotel you own."));
      result.Add(new ChanceCard("You have won second prize in a beauty contest. Collect $10."));
      result.Add(new ChanceCard("You inherit $100."));

      return result;
    }
  }
}
