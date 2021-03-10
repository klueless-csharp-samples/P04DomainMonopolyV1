namespace P04DomainMonopolyV1.Actions
{
  // Actions and Queries and Services (aka SubSystem, Workflow)
  // 
  // Action: Is an action that is taken by some [Noun] and is recorded into the ActionStore.
  // Query: Is a subsystem that controls specific workflows.
  // Service: Is a subsystem that controls specific workflows.

  // ----------------------------------------------------------------------
  // Monopoly
  // ----------------------------------------------------------------------

  // Players are returned in the order they registered.
  // 
  // Players sit in a circle around the board and each player in turn throws the dice. The player with the highest total starts the play.
  public class Monopoly_OrderedPlayerListAction {}

  // Starting player is chosen (highest die roll goes first).
  // 
  // Players sit in a circle around the board and each player in turn throws the dice. The player with the highest total starts the play.
  public class Monopoly_HighRollGoesFirstAction {}

  // ----------------------------------------------------------------------
  // Game
  // ----------------------------------------------------------------------

  // Generate a TitleDeed for each square can hold title
  // Bank holds the Title Deed cards and houses and hotels prior to purchase and use by the players.
  public class Game_GenerateTitleDeedsAction {}

  // Piece Landed Service
  // 
  // According to the space your token reaches, you may be entitled to buy real estate or other properties — or obliged to pay rent, pay taxes, draw a Chance or Community Chest card, "Go to Jail," etc.
  public class Game_PieceLandedService {}

  // ----------------------------------------------------------------------
  // Bank
  // ----------------------------------------------------------------------

  // Pay Salary
  //
  // The Bank pays salary to a player
  public class Bank_PaySalaryAction {}

  // Hold an Auction Service
  // 
  // The bank sells and auctions properties
  public class Bank_HoldAuctionService {}

  // Auction Service
  // 
  // The bank hands out their proper Title Deed cards
  public class Bank_AssignTitleDeedAction {}

  // Sell house to player
  // constraint (32 houses)
  // 
  // The bank sells houses and hotels to the players
  public class Bank_SellsHouseAction {}
  
  // Sell hotel to player
  // constraint (12 hotels)
  // 
  // The bank loans money when required on mortgages.
  public class Bank_SellsHotelAction {}

  
  // Loans money for mortgaged property
  // 
  // The bank loans money to players in exchange for mortgage.
  public class Bank_LoansMoneyAction {}

  // Collect tax from player
  // 
  // The Bank collects all taxes, fines, loans and interest, and the price of all properties which it sells and auctions.
  public class Bank_CollectTaxAction {}

  // Collect fine from player
  // 
  // The Bank collects all taxes, fines, loans and interest, and the price of all properties which it sells and auctions.
  public class Bank_CollectFineAction {}

  // Collect interest from player
  // 
  // The Bank collects all taxes, fines, loans and interest, and the price of all properties which it sells and auctions.
  public class Bank_CollectInterestAction {}

  // GetsBailout
  // 
  // The Bank never "goes broke." If the Bank runs out of money,
  // the Banker may issue as much more as needed by writing on any ordinary paper.
  public class Bank_GetsBailoutAction {}

  // ----------------------------------------------------------------------
  // Player
  // ----------------------------------------------------------------------

  /*
  Get Piece randomly selects a unique piece

  Each player chooses one token to represent him/her while traveling around the board.
  */
  public class Player_GetPiece {}

  // Roll the dice
  // 
  // When a player rolls the dice, it is stored for the user
  // throw the dice and move your token in the direction of the arrow the number of spaces indicated by the dice. For the very first move of the game, you can can read the current_die value as the throw already happened before start.
  public class Player_RollDiceAction {}

  // Move player piece
  // 
  // throw the dice and move your token in the direction of the arrow the number of spaces indicated by the dice.
  public class Player_MovePieceAction {}

  // How many doubles has the player rolled
  // 
  // Read the last 3 dice roll Actions and tally the number of doubles that have been thrown in a row.
  // If you throw doubles three times in succession, move your token immediately to the space marked "In Jail"
  public class Player_DoublesThrownQuery {}

  // Has the player just thrown a double
  public class Play_IsDoubleThrown {}

  // You land in Jail when you throw doubles three times in succession.
  // 
  // May need a service here
  public class Player_GoToJail {}

  // The player is in Jail
  // 
  // Read Player.JailState
  public class Player_InJail {}
  
  // Player passes Go (NOTE: Look at the Service/PassingGo, it may be a better option then Action)
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
  public class Player_PassGoAction {}

  // Player (Owner) collects rent from player (Landed)
  public class Player_CollectRent { }

  // Player (Owner) collects extra (double) rent from player (Landed)
  // 
  // It is advantage to hold all the Title Deed cards in a color group (eg. Boardwalk and Park Place; or Connecticut, Vermont and Oriental Avenues) because the owner may then charge double rent for unimproved properties in that color-group.
  public class Player_CollectExtraRent { }

  // Does the player own a complete group
  // 
  // It is advantage to hold all the Title Deed cards in a group as you can collect extra rent
  public class Player_OwnsGroup { }

  // Whe you buy something, you have to have enough cash.
  public class Player_HasEnoughCash { }

  // The player is currently in Jail (Read from JailState)
  public class Player_IsInJail { }

  // Does a player have a get out of Jail Card
  public class Player_HasOutOfJail {}

  // What players have Get out of Jail free cards
  // 
  // Useful if you want to buy a card from another player
  public class Player_OutOfJailCardQuery {}

  // Buy a Get out of Jail card from another player
  // 
  // Probably need some sort of haggle service to determine the price with randomized amounts and limits
  public class Player_BuyOutOfJailCard {}

  // Get out of jail by paying a fine of $50
  public class Player_OutOfJailPayFine {}

  // If you do not throw doubles by your third turn, you must pay the $50 fine. You then get out of Jail and immediately move forward the number of spaces shown by your throw.
  public class Player_JailSentenceEnded {}

  // ----------------------------------------------------------------------
  // Property (This is a tradable Square)
  // ----------------------------------------------------------------------

  // Is the property owned
  // 
  // Whenever you land on an unowned property you may buy that property from the Bank
  public class Property_IsOwned {}

  // Is the property unowned
  // 
  // Whenever you land on an [qry] unowned property you may buy that property from the Bank
  public class Property_Unowned {}

  // Buy an unowned property
  // 
  // You buy a property from the Bank at its printed price. You receive the Title Deed card showing ownership
  public class Property_BuyUnowned {}

  // Get the deed title information for a property
  public class Property_GetDeedTitle {}

  // Is the property mortgaged
  public class Property_IsMortgaged {}

  // IsCompleteGroup
  // 
  // Is the property (Land, Railroad, Utility) in a complete group for a Player
  // When you own all the properties in a color-group you may buy houses from the Bank and erect them on those properties.
  public class Property_IsCompleteGroup {}

  // Can I buy a house for a property
  // 
  // You buy a property from the Bank at its printed price. You receive the Title Deed card showing ownership
  // You need to have enough.
  // 
  // If you buy one house, you may put it on any one of those properties.
  // The next house you buy must be erected on one of the unimproved properties
  // of this or any other complete color-group you may own.
  // 
  // Following the above rules, you may buy and erect at any time
  // as many houses as your judgement and financial standing will allow.
  // But you must build evenly, ie., you cannot erect more than one house
  // on any one property of any color-group until you have built one house
  // on every property of that group.
  // 
  // You may then begin on the second row of houses, and so on, up to a limit of four houses to a property.
  // 
  // For example, you cannot build three houses on one property if you have only one house on another property of that group.


  public class Property_CanConstructHouse {}

  // Can I sell a house on a property?
  // 
  // As you build evenly, you must also break down evenly if you sell houses back to the Bank.
  public class Property_CanSellHouse {}

  // ----------------------------------------------------------------------
  // Square
  // ----------------------------------------------------------------------

  // Is chance square
  public class Square_IsChance {}

  // Is community chest square
  public class Square_IsCommunityChest {}

  // Is income tax
  public class Square_IsIncomeTax {}

  // Is super/luxury tax
  public class Square_IsLuxuryTax {}

  // Is go to jail
  // 
  // You land in Jail when your token lands on the space marked "Go to Jail";
  public class Square_IsGoToJail {}

  // ----------------------------------------------------------------------
  // Card
  // ----------------------------------------------------------------------

  // Get next chance card
  public class Card_GetNextChance {}

  // Get next community chest card
  public class Card_GetNextCommunityChest {}

  // Return chance card to the bottom of deck
  public class Card_ReturnChance {}

  // Return community chest to the bottom of deck
  public class Card_ReturnCommunityChest {}

  // Certain cards (namely Get out of Jail) can be held or traded,
  // they are an asset and don't go back to the CardDeck
  // 
  // Card must be ITradable
  public class Card_KeepCard {}
  
  // Card marked "Go to Jail"
  // 
  // You land in Jail when you draw a card marked "Go to Jail"
  public class Card_IsGoToJail {}

  // Follow the instructions on a card
  // 
  // Use the process instructions service
  public class Card_FollowInstructions {}

  // ----------------------------------------------------------------------
  // Tax
  // ----------------------------------------------------------------------

  // Pay income tax
  // 
  // You may estimate your tax at $200 and pay the Bank,
  // or you may pay 10% of your total worth to the Bank.
  // Your total worth is all your cash on hand,
  // printed prices of mortgaged and unmortgaged properties
  // and cost price of all buildings you own.
  // 
  // You must decide which option you will take before you add up your total worth.
  //
  // options:
  //   - fixed
  //   - percentage
  public class Tax_PayIncomeTax {}

  // Super/Luxury Tax
  // 
  // You must pay $100 to the Bank.
  public class Tax_PayLuxuryTax {}


  // ----------------------------------------------------------------------
  // InJail
  // ----------------------------------------------------------------------


}
