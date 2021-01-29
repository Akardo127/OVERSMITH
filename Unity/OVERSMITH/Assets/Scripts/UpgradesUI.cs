using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesUI : MonoBehaviour
{
    public string tier1Text;
    public string tier2Text;
    public string tier3Text;
    public string tier4Text;
    public string tier5Text;

    public Text upgradeDescription;
    public Text woodText;
    public Text nailsText;
    public Text ironText;
    public Text mithrilText;
    public Text meteoriteText;

    public Upgrades upgrades;

    // Update is called once per frame
    void Update()
    {
        woodText.text = upgrades.Wood.ToString();
        nailsText.text = upgrades.Nails.ToString();
        ironText.text = upgrades.Iron.ToString();
        mithrilText.text = upgrades.Mithril.ToString();
        meteoriteText.text = upgrades.Meteorite.ToString();


        if (upgrades.Tier == 1)
        {
            upgradeDescription.text = tier1Text;
        }
        if (upgrades.Tier == 2)
        {
            upgradeDescription.text = tier2Text;
        }
        if (upgrades.Tier == 3)
        {
            upgradeDescription.text = tier3Text;
        }
        if (upgrades.Tier == 4)
        {
            upgradeDescription.text = tier4Text;
        }
        if (upgrades.Tier == 5)
        {
            upgradeDescription.text = tier5Text;
        }
    }
}
