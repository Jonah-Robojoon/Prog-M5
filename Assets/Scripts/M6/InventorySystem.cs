using UnityEngine;

public class InventorySystem : InventoryItem
{
    Inventory playerInventory = new Inventory();
    Inventory worldInventory = new Inventory();

    float Timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        worldInventory.Medipacks.Add("Medipack");
        worldInventory.Guns.Add("Gun");
        worldInventory.Keycards.Add("Keycard");
        worldInventory.Medipacks.Add("Medipack");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            Timer = Timer + Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            if (Timer >= 1)
            {
                ItemPickup("Medipack");
            }
            else
            {
                ItemDrop("Medipack");
            }
            Debug.Log("Player Medipacks: " + playerInventory.Medipacks.Count + " | Player Guns: " + playerInventory.Guns.Count + " | Player Keycards: " + playerInventory.Keycards.Count);
            Debug.Log("World Medipacks: " + worldInventory.Medipacks.Count + " | World Guns: " + worldInventory.Guns.Count + " | World Keycards: " + worldInventory.Keycards.Count);
            Timer = 0;
        }

        if (Input.GetKey(KeyCode.G))
        {
            Timer = Timer + Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            if (Timer >= 1)
            {
                ItemPickupGun("Gun");
            }
            else
            {
                ItemDropGun("Gun");
            }
            Debug.Log("Player Medipacks: " + playerInventory.Medipacks.Count + " | Player Guns: " + playerInventory.Guns.Count + " | Player Keycards: " + playerInventory.Keycards.Count);
            Debug.Log("World Medipacks: " + worldInventory.Medipacks.Count + " | World Guns: " + worldInventory.Guns.Count + " | World Keycards: " + worldInventory.Keycards.Count);
            Timer = 0;
        }


        if (Input.GetKey(KeyCode.K))
        {
            Timer = Timer + Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            if (Timer >= 1)
            {
                ItemPickupKeycard("Keycard");
            }
            else
            {
                ItemDropKeycard("Keycard");
            }
            Debug.Log("Player Medipacks: " + playerInventory.Medipacks.Count + " | Player Guns: " + playerInventory.Guns.Count + " | Player Keycards: " + playerInventory.Keycards.Count);
            Debug.Log("World Medipacks: " + worldInventory.Medipacks.Count + " | World Guns: " + worldInventory.Guns.Count + " | World Keycards: " + worldInventory.Keycards.Count);
            Timer = 0;
        }

    }

    private void ItemPickup(string item)
    {
        worldInventory.Medipacks.Remove(item);
        playerInventory.Medipacks.Add(item);
    }

    private void ItemPickupGun(string item)
    {
        worldInventory.Guns.Remove(item);
        playerInventory.Guns.Add(item);
    }

    private void ItemPickupKeycard(string item)
    {
        worldInventory.Keycards.Remove(item);
        playerInventory.Keycards.Add(item);
    }

    private void ItemDrop(string item)
    {
        playerInventory.Medipacks.Remove(item);
        worldInventory.Medipacks.Add(item);
    }

    private void ItemDropGun(string item)
    {
        worldInventory.Guns.Add(item);
        playerInventory.Guns.Remove(item);
    }

    private void ItemDropKeycard(string item)
    {
        worldInventory.Keycards.Add(item);
        playerInventory.Keycards.Remove(item);
    }
}
