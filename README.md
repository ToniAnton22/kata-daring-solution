# Cristian's Solution

## GildedRose.cs

Biggest change I've made is on the layout on how the if statements are structures. Instead of nexting them based on what they aren't, I just creates a few checks that highlight the existence of an substring, like for 
"Conjured cheese" for example the current will check if the "Conjured" string is within the name. This way the program will be easier to check for, as you only need the keyword "Conjured", which scales much better as
adding a "Conjured cheesburger" would require another hardcoded string in the checks.

### Conjured Items
Conjured items behave as the exercise instigated. These items drop in quality twice as much as normal items, that includes when the sellIn price drops to zero. So the items drop by -2 when still due, and when overdue they will drop by -4.

### Additional checks

Added a few additional checks to make sure that Quality doesn't go neither above nor below 50, I also added another safety mechanism for Sulfuras items, to check and make sure that their quality is always 80 (in case of improper input into the database).

## GildedRoseTest.cs

Fixed the name so it contain the name of the conjured object. This test passes flawlessly after name change. Another thing I've done was change the name of the test to better tell us what it does.

## ApprovalTest

Modified the test sheet so it can match how conjured items will behave based on the requirments of the exercise. Conjured items now drop by 2 in the test as their sellIn value is still above 0.

## What's next?

A keyword type system is probably an upgrade that I can think of. Instead of having to check the names for keywords or full item names, if the goblin allows it, we can add a "Type" string to the Item class, which will tell us if it's "Conjured" or "Aged Brie". This way, we can use a switch case to search for these items, which will make it more resource friendly and faster.
