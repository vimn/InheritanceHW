using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Treasure : CollectibleBase
{
    [SerializeField] float _treasureCount = 1;

    public TextMeshProUGUI txt;
    private float treasureCount;
    // Start is called before the first frame update
    protected override void Collect(Player player)
    {
        TankController controller = player.GetComponent<TankController>();
        
        if (controller != null)
        {
            treasureCount += 1;
            txt.text = "Treasures: " + treasureCount.ToString();
        }
    }
}
