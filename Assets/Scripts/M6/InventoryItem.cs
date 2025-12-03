using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class InventoryItem : MonoBehaviour
{
    public class Inventory
    {
        // Initialize lists so they're not null when used.
        public List<string> Medipacks = new List<string>();
        public List<string> Guns = new List<string>();
        public List<string> Keycards = new List<string>();
    }
}