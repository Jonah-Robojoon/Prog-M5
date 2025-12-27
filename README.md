# Opdracht 1
hier heb ik eerst veel ballen spawned met een list die iedere bal heeft en dan iedere seconden ook en bal spawned met initiate
![Animation](Gifs/1.1.gif)

![Scripts](Assets/Scripts/Opdr1)

# --------------------------
# Opdracht 2
hier heb ik een object die iedere keer waneer je je muis ik clicked dat hij op een random positie en scale met Instantiate spawned
![Animation](Gifs/2.gif)

![Scripts](Assets/Scripts/Opdr2)

# --------------------------
# Opdracht 3
hier heb ik als je op Q click dan delete het alle boxes in de list en W dan spawned het 100 boxen en doen ze in een list. en er spawned altijd 1 per seconde
![Animation](Gifs/3.gif)

![Scripts](Assets/Scripts/Opdr3)

# --------------------------
# Opdracht 4
hier heb ik met action events er voor gezorgd dat je coins kan oppakken en dat je dan die punten krijg die bij die munt hoort
![Animation](Gifs/4.gif)

![Scripts](Assets/Scripts/Opdr4)

# --------------------------
# Opdracht 5
A : shoot range is 0    ||    target tag has one extra r

B : TowerDefence Opdr

D : ![Scripts](Gifs/Breakpoint.png)

# --------------------------
# Opdracht 6
hier heb ik de scripts uit elkaar gemaakt zodat het berter beveiligd is als 1 van die scripts breekt
![Repo](https://github.com/Jonah-Robojoon/Space48Fork)

# --------------------------
# Opdracht 7
 X

# --------------------------
# Opdracht 8
hier heb ik met parent classes gewerkt om meerdere scripts met elkaar te linken om 3 enemys te maken
![Animation](Gifs/8.gif)

![Scripts](Assets/Scripts/Opdr8)
 
 ```mermaid
 classDiagram

 class Enemy {
		+int health
		+float speed
		+void Move()
		+void TakeDamage(int damage)
	}

class Goblin {
		+void SpecialGoblinAbility()
	}

Enemy <|-- Goblin

```