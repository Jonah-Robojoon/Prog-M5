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


# M6
# --------------------------
# Les 1
hier heb ik een list gemaakt van items en dingen uit die list gehaalt en gestopt. dit heb ik gemaakt met heele harde focus op code convensies. zoals private altijd beginnen met: _
![Animation](Gifs/m6.gif)

![Scripts](Assets/Scripts/M6)

# --------------------------
# Les 2
Mermaid
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

# --------------------------
# Les 3
hier heb ik met heaps en stacks gewerkt om een inventory te maken (ScriptableObjects, Classes, structs)
![Animation](Gifs/6.3.gif)

![Scripts](Assets/Scripts/M6/Opdracht%203)

# --------------------------
# Les 4
hier heb ik met delegates en action events gewerkt om een function te activeren via een andere script.
![Animation](Gifs/6.4.gif)

![Scripts](Assets/Scripts/M6/Les4)

# --------------------------
# Les 5
Hier heb ik geleerd over Abstraction. Dit heb ik gedaan door een class te verplichten om bepaalde functies te gebruiken. dit zorgt ervoor dat mensen niet functions vergeten die wel belangerijk zijn om te werken
![Animation](Gifs/6.5.gif)

![Scripts](Assets/Scripts/M6/Les5)

# --------------------------
# Les 6
hier heb ik gewerkt met Polymophism. Dit is gebruikt met het overriden van functions die all in classes bestaan. hierdoor is er altijd een bestaandde function, maar laat het toe als mensen wat extra dingen willen toe voegen.
![Animation](Gifs/6.6.gif)

![Scripts](Assets/Scripts/M7/Les5)

# --------------------------
# Les 7
hier heb ik met early returns gewerkt om scripts meer leesbaar te maken. dit heb ik gedaan door return en continue te gebruiken

```csharp
public bool IsPlayerReadyToAttack(Player player)
    {
        if (player == null) return false;

        if (!player.IsAlive) return false;

        if (player.AttackCooldown !<= 0) return false;
  
        if (player.Target == null) return false;

        if (!player.Target.IsAlive) return false;


        if (Vector3.Distance(player.transform.position, player.Target.transform.position) !< 5f) return false;

        if (!(player.Mana >= 20 && player.WeaponEquipped) || (player.Health > 30 && player.HasBuff("Strength"))) return false;
        
        if (player.IsStunned || player.IsSlowed) return false;

        return true;
    }

```
