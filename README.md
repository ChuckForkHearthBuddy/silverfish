## Sepefeets's update to botmaker's Silverfish AI
This AI is a Custom Class for Hearthranger and Hearthbuddy which intends to simulate all possible turn actions and select the best.

Official Threads:
- http://www.hearthranger.com/forum/yaf_postst7352_Sepefeets-Silverfish-update--WotOG.aspx
- https://www.thebuddyforum.com/hearthbuddy-forum/community-developer-forum/249423-sepefeets-silverfish-update-wotog.html

build instructions:
- If you plan to do any significant work I recommend using linkshellextension to create junctions instead of actual copies of the "ai" + "cards" + "Penalties"

Hearthranger:
- copy the "ai" + "cards" + "Penalties" folders to the "HR" folder, then create a project out of everything in the "HR" folder
- add a reference to HSRangerLib.dll from HR
- go to Project -> Properties -> Application and set target framework to .NET Framework 4.5
- go to Project -> Properties -> Build -> Advanced and set language version to C# 5.0 for HB compatibility
- build it as Release x86, and copy the _cardDB.txt file to the bin\Release folder
- build Silver.exe too

Hearthbuddy:
- copy the "ai" + "cards" + "Penalties" folders to the "HrtBddy" folder, then create a project out of everything in the "HrtBddy" folder
- add references for Hearthbuddy.exe and all the DLL's that come with it
- go to Project -> Properties -> Application and set target framework to .NET Framework 4.5
- go to Project -> Properties -> Build -> Advanced and set language version to C# 5.0 for HB compatibility
- build it however you want just to test that it does build but HB uses the source files not a binary
- there might be some errors I can't fix (I don't own HB), if you know how to fix it then let me know or submit a PR
- build Silver.exe too

Silver.exe:
- copy the "ai" + "cards" + "Penalties" folders to the "external process" folder, then create a project out of everything in the "external process"
- go to Project -> Properties -> Application and set target framework to .NET Framework 4.5
- go to Project -> Properties -> Build -> Advanced and set language version to C# 5.0 for HB compatibility
- build it as Release x86 for performance or Debug x86 for debugging, and copy the _cardDB.txt file to the bin\Release and bin\Debug folders


How to simulate boards with silver.exe:
- create a "test.txt" file in the same folder as silver.exe
- copy your current board, like
```
#######################################################################
start calculations, current time: 00:00:00:0000 V116.27 control 5000 face 15 twoturnsim 1000 ntss 6 16 160 playaround 50 80 ets 16 ets2 160 ents 16 secret
#######################################################################
mana 3/10
emana 10
own secretsCount: 0
enemy secretsCount: 0 ;
player:
1 2 0 1 0 0 0 0 0
0 0 0 0 0 0 0 0 0 0 0
ownhero:
priest 27 30 0 False False 4 True 0 False 0 0
weapon: 0 0 unknown
ability: True CS1h_001 3
osecrets:
enemyhero:
warrior 15 30 35 False False 36
weapon: 0 0 unknown
ability: True AT_132_WARRIOR 0
fatigue: 9 0 7 0
OwnMinions:
twilightguardian AT_017 zp:1 e:212 A:4 H:10 mH:10 rdy:False natt:0 ex ptt spllpwr(1)
EnemyMinions:
boombot GVG_110t zp:1 e:184 A:1 H:1 mH:1 rdy:True natt:0 ex
Own Handcards:
pos 1 arcaneintellect 3 entity 9 CS2_023 0 0
Enemy cards: 4
ownDiedMinions:
enemyDiedMinions:
og: 169,2;1152,1;248,2;246,2;251,1;557,2;1150,2;209,2;430,2;642,1;372,1;1010,2;371,1;701,2;
eg: 995,1;708,1;429,2;740,2;495,1;514,1;648,2;333,1;241,2;516,2;1218,1;188,2;749,2;
```
it will then calculate this board and print the first 100 best boards (sorted from best to worst) and simulate
the whole turn of the best one.

if you add "test" to the first line:
```
#######################################################################test
start calculations, current time: 00:00:00:0000 V116.27 control 5000 face 15 twoturnsim 1000 ntss 6 16 160 playaround 50 80 ets 16 ets2 160 ents 16 secret
#######################################################################
...
```
you can input the index of the displayed boards to simulate the whole turn of this board (indexes are be displayed 
in the list of the first 100 best boards)