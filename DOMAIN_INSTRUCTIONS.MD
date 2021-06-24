---
format_artifacts      : ['repeats:1','command:9','noun:8','verb:30', 'options:10' ,'artifact:35','xfull_command:50','description:50']
show_artifacts        : 1
show_config           : 0
show_all_stats        : 0
show_filtered_stats   : 1
generate_rc           : 1
generate_filtered_rc  : 1 # TODO
use_filter            : 1
pagination            : [0, 1, 20]
word_wrap             : 80
# order_by              : ['noun:asc', 'verb', 'command:asc'] # natural, command, noun, verb, artifact
filter:
  exclude_actions     : 0
  exclude_queries     : 0
  exclude_predicates  : 0
  exclude_interfaces  : 0
  exclude_services    : 0
  domain_nouns        : 'all' # all || [player, game, bank, property, card, square]
  # search              : 'xxx'
  # search              : 'hotel|house|building'
  # search              : 'pay-mortgage'
  # search              : '(?=.*sell)(?=.*property)'
  find_duplicate_verbs: 0
generate_builders:      # TODO - generate builders
  generate            : 1
  action_folder       : 'actions'
  query_folder        : 'queries'
  predicate_folder    : 'predicates'
  interface_folder    : 'interfaces'
  service_folder      : 'services'
generate_rc:            # TODO - generate a .dddrc file
  generate            : 1
  file                : '.dddrc.json'
generate_filtered_rc: # TODO - generate a filtered .dddrc file
  generate            : 0
  file                : '.dddrc-filtered.json'
generate_clean_md:    # TODO
  generate            : 1
  file                : 'DOMAIN.MD'
---


# Monopoly

## Refactor

- Square -> Space

![Monopoly](Monopoly.jpg "")

### Constraints:

- 3 dice
- Pieces
  - car, iron, lantern, thimble, shoe, top-hat, rocking horse, battleship and cannon
- 32 houses
- 12 hotels
- Chance and Community Chest Cards
- Title Deed Cards
- Play money and a Banker's tray

## Classic Monopoly Rules

### Objective

{service:player:select-new-piece}
Each player chooses one token to represent him/her while traveling around the board.
{/service}

The object of the game is to become the wealthiest player through buying, renting and selling property.

{action:player:select-new-piece:-md-remove}
Player chooses one available token to represent him/her while traveling around the board.
{/action}

### Banker

The bank / auctioneer is controlled by the computer.

Besides the Bank’s money, the {action:game:generate-title-deed}Bank holds the Title Deed cards and houses and hotels prior to purchase and use by the players.{/action}

{action:bank:pay-salary}
The Bank pays salaries and bonuses to players
{/action}

{service:bank:hold-an-auction}The bank sells and auctions properties{/service} and {service:bank:assign-title-deed}hands out their proper Title Deed cards{/service}

{action:bank:sell-house|sell-hotel}The bank sells houses and hotels to the players{/action} and {action:bank:mortgage-property}The bank loans money when required on mortgages{/action}.

{service:bank:bank}The Bank collects all taxes, fines, loans and interest, and the price of all properties which it sells and auctions.{/service}

- {action:bank:collect-tax}The Bank collects taxes from player.{/action}
- {action:bank:collect-fine}The Bank collects fines from player{/action}

{action:bank:government_bailout}The Bank never "goes broke." If the Bank runs out of money, the Banker may issue as much more as needed by writing on any ordinary paper.{/action}

### Play

#### Before start

{action:game:add-players-to-board}Place player token on the square marked "GO"{/action}

{action:game:sort-players}Players sit in a circle around the board and each player in turn throws the dice{/action}. {action:game:roll-to-see-who-starts}The player with the highest total starts the play.{/action}

#### Start

1. {action:player:roll-dice}throw the dice{/action} and {action:player:move-piece}move your token in the direction of the arrow the number of spaces indicated by the dice{/action}. {predicate:game:is-first-move}For the very first move of the game, you can can read the current_die value as the throw already happened before start.{/predicate}
2. {action:player:complete-my-turn}After you have completed your play{/action}, {action:game:next-player-starts}the turn passes to the player on your the left (clockwise).{/action} The tokens remain on the spaces occupied and proceed from that point on.
3. Two or more tokens may rest on the same space at the same time.

{service:player:player-landed}According to the space your token reaches, you may be entitled to buy real estate or other properties — or obliged to pay rent, pay taxes, draw a Chance or Community Chest card, "Go to Jail," etc.{/service}

#### Doubles
If you throw doubles, you move your token as usual, the sum of the two dice, and are subject to any privileges or penalties pertaining to the space on which you land.

{predicate:player:double-thrown}Retaining the dice, throw again and move your token as before.{/predicate}

{predicate:player:three-doubles-in-succession}If you throw doubles three times in succession{/predicate},
{service:player:go-to-jail}move your token immediately to the space marked "In Jail"{/service}

#### GO
  
{action:bank:pay-salary}Each time a player's token lands on or passes over GO, whether by throwing the dice or drawing a card, the Banker pays him/her a $200 salary.{/action}

The $200 is paid only once each time around the board. However, if a {predicate:player:passed-go}player passing GO on the throw of the dice{/predicate} lands 2 spaces beyond it on Community Chest, or 7 spaces beyond it on Chance, and {predicate:card:advance-to-go-drawn}draws the "Advance to GO" card{/predicate}, he/she collects $200 for passing GO the first time and another $200 for {action:player:advance-to-go}"Advance to GO"{/action} reaching it the second time by instructions on the card.

#### {service:player:buy-property-from-bank}Buying Property{/service}

Whenever you land on an {predicate:bank:property-unowned}unowned property{/predicate} you may {action:player:buy-unowned-property}buy that property from the Bank at its printed price.{/action} You receive the {action:bank:transfer-title-deed}Title Deed card showing ownership{/action}; place it faceup in front of you.

If you do not {predicate:player:wish-to-buy-property}wish to buy the property{/predicate}, the {service:bank:hold-auction}Banker sells property at auction to the highest bidder.{/service}

{action:player:buy-property}The buyer pays the Bank the amount of the bid in cash and receives the Title Deed card for that property.{/action}

{service:bank:hold-auction}
Any player, including the one who declined the option to buy it at the printed price, may bid. Bidding may start at any price.
{/service}

#### {service:player:pay-rent}Paying Rent{/service}

When you land on {predicate:property:owned-by}property owned by another player{/predicate}, the {action:player:collect-rent}owner collects rent from you{/action} in accordance with the list printed on its {query:property:get-title-deed}Title Deed card{/query}.

{predicate:property:is-mortgaged}If the property is mortgaged{/predicate}, no rent can be collected. When a property is mortgaged, its Title Deed card is placed facedown in front of the owner.

{predicate:player:owns-group}It is advantage to hold all the Title Deed cards in a color group{/predicate} (eg. Boardwalk and Park Place; or Connecticut, Vermont and Oriental Avenues) because the {query:property:get-rent-amount}owner may then charge double rent for unimproved properties in that color-group{/query}.

This rule applies to unmortgaged properties even if another property in that color-group is mortgaged.

{query:property:get-rent-amount}It is even more advantageous to have houses or hotels on properties because rents are much higher than for unimproved properties.{/query}

The {query:player:asks-for-rent}owner may not collect the rent if he/she fails to ask for it before the second player following throws the dice{/query}.

#### {service:card:card}Chance and Community Chest{/service}

{predicate:square:land-on-card}When you land on either of these spaces{/predicate}, {action:card:take-card}take the top card from the deck indicated{/action}, {action:card:follow-instructions}follow the instructions{/action} and {action:card:return-card}return the card face down to the bottom of the deck{/action}.

The {interface:card:get-out-of-jail}"Get Out of Jail Free" card{/interface} is held until used and then returned to the bottom of the deck. If the player who draws it does not wish to use it, {interface:card:tradeable}he/she may sell it{/interface}, {query:player:trade-card-decision}at any time{/query}, {query:player:wants-to-buy-card}to another player{/query} {action:player:card-agreeable-price}at an agreed price agreeable to both{/action}.

#### Income Tax

{predicate:square:land-on-income-tax}If you land on income tax{/predicate} you have two options: {action:player:pay-income-tax-estimate}You may estimate your tax at $200 and pay the Bank{/action}, or {action:player:pay-income-tax-calculated}you may pay 10% of your total worth to the Bank{/action}. {query:player:calculate-total-worth}Your total worth is all your cash on hand, printed prices of mortgaged and unmortgaged properties and cost price of all buildings you own.{/query}

{query:player:income-tax-decision}You must decide which option you will take before you add up your total worth.{/query}

#### Super/Luxury Tax

{predicate:square:land-on-super-tax}If you land on super tax{/predicate} you then {action:player:pay-super-tax}you have to pay $100 super tax to the Bank.{/action}

#### Jail

{service:game:go-to-jail}You land in Jail when{/service}...
- (1) {predicate:square:land-on-go-to-jail}your token lands on the space marked "Go to Jail"{/predicate}; 
- (2) {predicate:card:go-to-jail-drawn}you draw a card marked "Go to Jail"{/predicate}; or
- (3) {predicate:player:three-doubles-go-to-jail}you throw doubles three times in succession{/predicate}.

When you are sent to Jail you cannot collect your $200 salary in that move since, regardless of where your token is on the board, you must move it a directly into Jail. {action:player:complete-my-turn}Your turn ends when you are sent to Jail.{/action}

If you are not "sent" to Jail but in the ordinary course of play land on that space, {predicate:square:land-on-just-visiting}you are "Just Visiting," you incur no penalty{/predicate}, and you move ahead in the usual manner on your next turn.

{predicate:player:currently-in-jail}Am I currently in jail{/predicate}

{service:player:get-out-of-jail}You get out of Jail by...{/service}

- (1) {action:player:in-jail-roll-dice-decision}throwing doubles on any of your next three turns{/action}; {predicate:player:double-thrown}if you succeed in doing this you immediately move forward the number of spaces shown by your doubles throw{/predicate}: {predicate:player:double-thrown-while-in-jail}even though you had thrown doubles, you do not take another turn{/predicate};
- (2) {action:player:use-get-out-of-jail}using the "Get Out of Jail Free"{/action} {predicate:player:has-get-out-of-jail}card if you have it{/predicate}; 
- (3) {action:player:buy-get-out-of-jail}purchasing the "Get Out of Jail Free"{/action} {query:player:players-with-get-out-of-jail}card from another player{/query} and playing it; 
- (4) {action:player:pay-get-out-of-jail-fine}paying a fine of $50 before you roll the dice on either of your next two turns.{/action}

If you do not throw doubles by your third turn, you must pay the $50 fine. You then get out of Jail and immediately move forward the number of spaces shown by your throw.

Even though you are in Jail, you may buy and sell property, buy and sell houses and hotels and collect rents.

#### {service:game:free-Parking}Free Parking{/service}

A player landing on this place does not receive any money, property or reward of any kind. This is just a "free" resting place.

Alternative Rules: Fines go here and are picked up by who ever lands here

#### {service:player:buy-house}Houses{/service}

{predicate:player:can-buy-house}{/predicate}
{predicate:player:owns-group}When you own all the properties in a color-group{/predicate} {action:player:buy-house-decision}you may buy houses from the Bank and erect them on those properties{/action}.

If you {action:player:buy-house}buy one house{/action}, {action:player:place-house-decision}you may put it on any one of those properties. The next house you buy must be erected on one of the unimproved properties of this or any other complete color-group you may own.{/action}

The price you must pay the Bank for each house is shown on your Title Deed card for the property on which you erect the house.

{query:player:get-rent-amount}The owner still collects double rent from an opponent who lands on the unimproved properties of his/her complete color-group.{/query}

Following the above rules, {service:player:buy-house}you may buy and erect at any time as many houses as your judgement and financial standing will allow. But you must build evenly, ie., you cannot erect more than one house on any one property of any color-group until you have built one house on every property of that group.

You may then begin on the second row of houses, and so on, up to a limit of four houses to a property.

For example, you cannot build three houses on one property if you have only one house on another property of that group.
{/service}

As you build evenly, you must also break down evenly if you sell houses back to the Bank (see SELLING PROPERTY).

#### {service:player:buy-hotel}Hotels{/service}

{predicate:player:can-buy-hotel}When a player has four houses on each property of a complete color-group{/predicate}, {service:player:buy-hotel}he/she may buy a hotel from the Bank and erect it on any property of the color-group.{/service} {action:player:remove-all-houses}He/she returns the four houses from that property to the Bank{/action} and {action:player:buy-hotel}pays the price for the hotel as shown
on the Title Deed card.{/action} {predicate:player:can-buy-hotel}Only one hotel may be erected on any one property.{/predicate}

#### Building Shortages

{query:bank:building-shortage}When the Bank has no houses to sell{/query}, {predicate:player:can-buy-house|can-buy-hotel}players wishing to build must wait for some player to return or sell his/her houses to the Bank before building{/predicate}. {service:bank:auction-building}If there are a limited number of houses and hotels available and two or more players wish to buy more than the Bank has, the houses or hotels must be sold at auction to the highest bidder{/service}.

 
#### {service:player:sell-property-other-player}Sell Property{/service}

{predicate:property:unimproved}Unimproved properties{/predicate}, railroads and utilities (out not buildings) {action:property:private-sale-price-decision}may be sold to any player as a private transaction for any amount the owner can get{/action}; however, no property can be sold to another player {predicate:property:improved}if buildings are standing on any properties of that color-group{/predicate}. Any buildings so located must be {action:player:sell-building-to-bank}sold back to the Bank{/action} {predicate:player:can-sell-property}before the owner can sell any property of that color-group{/predicate}.

{action:player:sell-building-decision}Houses and hotels may be sold back to the Bank{/action} at any time for {query:property:sell-price}one-half the price paid for them{/query}.

{action:player:sell-house}All houses on one color-group must be sold one by one, evenly{/action}, {query:property:next-house-to-sell}in reverse of the manner in which they were erected{/query},

{action:player:sell-hotel}All hotels on one color group may be sold at once, or they may be sold one hotel at a time{/action} ({action:player:downgrade-hotel-to-houses}one hotel equals five houses{/action}), evenly, {query:property:next-hotel-to-sell}in reverse of the manner in which they were erected{/query}.

#### Mortgages

{predicate:property:can-be-mortgaged}Unimproved properties can be mortgaged through the Bank at any time. Before an improved property can be mortgaged, all the buildings on all the properties of its color-group must be sold back to the Bank at half price{/predicate}. {query:property:mortgage-value}The mortgage value is printed on each Title Deed card.{/query}

{action:property:collect-rent}No rent can be collected on mortgaged properties or utilities{/action}, but {predicate:player:can-collect-rent}rent can be collected on unmortgaged properties in the same group{/predicate}.

{action:player:pay-mortgage}In order to lift the mortgage, the owner must pay the Bank the amount of the mortgage plus 10% interest.{/action} {predicate:player:can-buy-house}When all the properties of a color-group are no longer mortgaged, the owner may begin to buy back houses at full price{/predicate}.

The player who mortgages property retains possession of it and no other player may secure it by lifting the mortgage from the Bank.
However, {service:player:sell-property-other-player}the owner may sell this mortgaged property to another player at any agreed price{/service}. {action:player:pay-mortgage}If you are the new owner, you may lift the mortgage at once if you wish by paying off the mortgage plus 10% interest to the Bank.{/action} {action:player:pay-mortgage-surcharge}If the mortgage is not lifted at once, you must pay the Bank 10% interest when you buy the property{/action} and if you lift the mortgage later you must pay the Bank an additional 10% interest as well as the amount of the mortgage.

 
#### Bankruptcy

You are declared bankrupt if you owe more than you can pay either to another player or to the Bank. If your debt is to another player, you must turn over to that player all that you have of value and retire from the game. In making this settlement, if you own houses or hotels, you must return these to the Bank in exchange for money to the extent of one-half the amount paid for them; this cash is given to the creditor. If you have mortgaged property you also tum this property over to your creditor but the new owner must at once pay the Bank the amount of interest on the loan, which is 10% of the value of the property. The new owner who does this may then, at his/her option, pay the principal or hold the property until some later turn, then lift the mortgage. If he/she holds property in this way until a later turn, he/she must pay the interest again upon lifting the mortgage.

Should you owe the Bank, instead of another player, more than you can pay (because of taxes or penalties) even by selling off buildings
and mortgaging property, you must tum over all assets to the Bank. In this case, the Bank immediately sells oy auction all property so taken, except buildings. A bankrupt player must immediately retire from the game. The last player left in the game wins.

#### Miscellaneous

Money can be loaned to a player only by the Bank and then only by mortgaging property. No player may borrow from or lend money to another player.

## Chance Cards   

Traditionally, the question marks placed on the Chance spaces around the board are pink, blue, and red, in that order.

### Simple collection of chance cards

- 1 x Advance to "Go", collect $200.
- 1 x Advance to Trafalgar Square If you pass Go, collect $200.
- 1 x Advance to Pall Mall If you pass Go, collect $200.
- 1 x Advance token to the nearest Utility. If unowned, you may buy it from the Bank. If owned, throw dice and pay owner a total 10 (ten) times the amount thrown.
- 2 x Advance to the nearest Railroad. If unowned, you may buy it from the Bank. If owned, pay owner twice the retail to which they are otherwise entitled. If Railroad is unowned, you may buy it from the Bank.
- 1 x Bank pays you dividend of $50.
- 1 x Get out of Jail Free. This card may be kept until needed, or traded/sold.
- 1 x Go Back Three Spaces.
- 1 x Go to Jail. Go directly to Jail. Do not pass GO, do not collect $200.
- 1 x Make general repairs on all your property: For each house pay $25, For each hotel pay $100.
- 1 x Pay poor ta x  of $15
- 1 x Take a ride to King’s Cross Station If you pass Go, collect $200.
- 1 x Take a walk on the board walk. Advance token to Mayfair.
- 1 x You have been elected Chairman of the Board. Pay each player $50.
- 1 x Your building and loan matures. Collect $150.
- 1 x You have won a crossword competition. Collect $100.

### Simple collection of community chest cards

- 1 x Advance to "Go". Collect $200.
- 1 x Bank error in your favor. Collect $200.
- 1 x Doctor's fees. Pay $50.
- 1 x From sale of stock you get $50.
- 1 x Get Out of Jail Free. This card may be kept until needed or sold/traded.
- 1 x Go to Jail. Go directly to jail. Do not pass Go, Do not collect $200.
- 1 x Grand Opera Night. Collect $50 from every player for opening night seats.
- 1 x Holiday Fund matures. Collect $100.
- 1 x Income tax refund. Collect $20.
- 1 x It's your birthday. Collect $10 from every player.
- 1 x Life insurance matures – Collect $100.
- 1 x Hospital Fees. Pay $50.
- 1 x School fees. Pay $50.
- 1 x Receive $25 consultancy fee.
- 1 x You are assessed for street repairs: Pay $40 per house and $115 per hotel you own.
- 1 x You have won second prize in a beauty contest. Collect $10.
- 1 x You inherit $100.

### Monopoly Chance And Community Chest Cards, Ranked

You have won second prize in a beauty contest collect $10
Grand opera opening collect $50 from every player
GO TO JAIL GO DIRECTLY TO JAIL DO NOT PASS GO DO NOT COLLECT $200
Advance to Illinois Ave.
Bank error in your favor collect $200
Advance to GO (Collect $200)
Xmas fund matures collect $100
Your building and loan matures collect $150
Take a ride on the Reading. If you pass GO collect $200
You inherit $100
Life insurance matures collect $100
Go back three spaces
Advance token to Boardwalk
Bank pays you dividend of $50
Income tax refund collect $20
From sale of stock you get $45
Pay poor tax of $15
Get out of jail free
Receive for services $25
Doctor’s fee pay $50
Advance token to the nearest railroad and pay the owner twice the rental to which he/she is otherwise entitled. If railroad is UNOWNED you may buy it from the bank
Advance to St. Charles Place. If you pass GO, collect $200
Advance token to the nearest utility. If unowned you may buy it from the bank. If owned, throw dice and pay the owner a total ten times the amount shown
Pay school tax of $150
Pay hospital $100
You have been elected chairman of the board. Pay each player $50
Death by dismemberment
Make general repairs on your property. For each house pay $25 for each hotel $100
You are assessed for street repairs $40 per house $115 per hotel


