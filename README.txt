C# Text Based Game

Developed in Visual Studio 2019 16.11.8 

The solution has two projects: 
SuperAdventure (Windows Forms App .NET framework) – one for the UI
					          - uses Labels, RichTextVBox, DataGridViews, Buttons, ComboButtons

Engine (Class Library .NET framwork) - the other for the code to do all the calculations and logic for the game.
       				     - includes all the classes (check player class for some info)

Useful info:
- Game is populated in the World.cs class, here quests, locations, items etc are all entered. Go here to add more.
- Look at GameMap.png in main directory for map layout to help you understand the map directions.

Checklist for adding Locations for new quests (in World.cs):
- Create IDs for any items, monsters, quests and locations
- Populate the new items, monsters etc. Following the structure (read comments)
- And add them at the bottom of each Populate function
- For monsters,  don't forget to add the loot dropped item underneath
- For quests, don't forget to add QuestCompletionItems and RewardItem(s)
- For locations, don't forget to add that a quest is available there, and that monsters may be there