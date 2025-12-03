using UnityEngine;

public class InventorySystem : InventoryItem
{
    private Inventory _playerInventory = new Inventory();
    private Inventory _worldInventory = new Inventory();

    private float _timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _worldInventory.Medipacks.Add("Medipack");
        _worldInventory.Guns.Add("Gun");
        _worldInventory.Keycards.Add("Keycard");
        _worldInventory.Medipacks.Add("Medipack");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            _timer = _timer + Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            if (_timer >= 1)
            {
                ItemPickup("Medipack");
            }
            else
            {
                ItemDrop("Medipack");
            }
            Debug.Log("Player Medipacks: " + _playerInventory.Medipacks.Count + " | Player Guns: " + _playerInventory.Guns.Count + " | Player Keycards: " + _playerInventory.Keycards.Count);
            Debug.Log("World Medipacks: " + _worldInventory.Medipacks.Count + " | World Guns: " + _worldInventory.Guns.Count + " | World Keycards: " + _worldInventory.Keycards.Count);
            _timer = 0;
        }

        if (Input.GetKey(KeyCode.G))
        {
            _timer = _timer + Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            if (_timer >= 1)
            {
                ItemPickupGun("Gun");
            }
            else
            {
                ItemDropGun("Gun");
            }
            Debug.Log("Player Medipacks: " + _playerInventory.Medipacks.Count + " | Player Guns: " + _playerInventory.Guns.Count + " | Player Keycards: " + _playerInventory.Keycards.Count);
            Debug.Log("World Medipacks: " + _worldInventory.Medipacks.Count + " | World Guns: " + _worldInventory.Guns.Count + " | World Keycards: " + _worldInventory.Keycards.Count);
            _timer = 0;
        }


        if (Input.GetKey(KeyCode.K))
        {
            _timer = _timer + Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            if (_timer >= 1)
            {
                ItemPickupKeycard("Keycard");
            }
            else
            {
                ItemDropKeycard("Keycard");
            }
            Debug.Log("Player Medipacks: " + _playerInventory.Medipacks.Count + " | Player Guns: " + _playerInventory.Guns.Count + " | Player Keycards: " + _playerInventory.Keycards.Count);
            Debug.Log("World Medipacks: " + _worldInventory.Medipacks.Count + " | World Guns: " + _worldInventory.Guns.Count + " | World Keycards: " + _worldInventory.Keycards.Count);
            _timer = 0;
        }

    }

    private void ItemPickup(string item)
    {
        _worldInventory.Medipacks.Remove(item);
        _playerInventory.Medipacks.Add(item);
    }

    private void ItemPickupGun(string item)
    {
        _worldInventory.Guns.Remove(item);
        _playerInventory.Guns.Add(item);
    }

    private void ItemPickupKeycard(string item)
    {
        _worldInventory.Keycards.Remove(item);
        _playerInventory.Keycards.Add(item);
    }

    private void ItemDrop(string item)
    {
        _playerInventory.Medipacks.Remove(item);
        _worldInventory.Medipacks.Add(item);
    }

    private void ItemDropGun(string item)
    {
        _worldInventory.Guns.Add(item);
        _playerInventory.Guns.Remove(item);
    }

    private void ItemDropKeycard(string item)
    {
        _worldInventory.Keycards.Add(item);
        _playerInventory.Keycards.Remove(item);
    }
}
