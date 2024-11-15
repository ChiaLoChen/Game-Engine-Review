Chia Lo Chen 100829478 

David Chuong 100860614 

Alex Snedden 100823185

The two design patterns we will be implementing are Singleton and Observer.

Observer will be used to update the players score for their current game when they pick up collectibles (fruits) or achieve other goals (like reaching the end and getting the key). It will also be used to notify Mario to stop throwing objects and instead push Donkey Kong in his cage off screen when DK Jr. reaches the top and gets the key.

Singleton was used to check the whether an objective is present in the level, in this case being the key (green circle). It will send a debug log saying if one is present or not. In the case that the objective isn't present the singleton will spawn one.

The Plugin will allow the player to fly by changing their gravity. Clicking a button will turn a bool true or false allowing the player to have on demand flight.

Link to UML Diagram: https://app.diagrams.net/#G1hIUBDJC-Qf-p1Am2eGYp0Ukn1WJ5ku9X#%7B"pageId"%3A"C5RBs43oDa-KdzZeNtuy"%7D

Percentage of contributions:

Chia Lo Chen - 40% 

David Chuong - 20%

Alex Snedden - 40%

Alex Sneddens: challenges with making the design patterns. The main issue I had is that I have not worked on unity in a while as my group has moved to unreal. So I had a lot of trouble trying to remember a lot of the basic commands and relearning the work flow when it comes to unity games and their coding. I also had a little bit of trouble deciding exactly what two design patterns to do for this project so it took a lttile while to noarrow down which two I felt fit the game the best.

Chia Lo Chen: challenges with making the plugins. I have issues trying to get the plugins working because I wasn't fully understand how the plugins work so during class period I can't get any progress on plugins. I resolve the issues by first outlining what plugins I had in mind and then ask helps from my classmates and friends, which they did gave me good explanations and tips on making the plugins.

David Chuong: challenges with remembering what certain UML icons/symbols represent so needed to refresh my memory to make it as accurate as possible to what the others have coded. There was delays with the UML diagram as the others were uncertain of what they wanted to do, meaning I couldn't full finish the diagram. Also needed to refresh on applications of design patterns (namely singleton) as there isn't many objects that need to access the singleton, whereas my previous understanding was it needs many objects in order to be called a singleton.
