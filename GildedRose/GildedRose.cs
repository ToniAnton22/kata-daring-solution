using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            if (Items[i].SellIn > 0)
            {
                if (Items[i].Quality < 50)
                {
                    if (Items[i].Name.Contains("Aged Brie"))
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                    if (Items[i].Name.Contains("Conjured"))
                    {
                        Items[i].Quality -= 2;
                    }
                    if (Items[i].Name.Contains("Backstage passes"))
                    {
                        Items[i].Quality += 1;

                        if (Items[i].SellIn < 11)
                        {
                            Items[i].Quality += 1;
                        }
                        if (Items[i].SellIn < 6)
                        {
                            Items[i].Quality += 1;
                        }
                    }
                    if (!Items[i].Name.Contains("Aged Brie") && !Items[i].Name.Contains("Conjured") && !Items[i].Name.Contains("Backstage passes"))
                    {
                        Items[i].Quality -= 1;
                    }
                }

            }
            else
            {
                if (Items[i].Name.Contains("Backstage passes"))
                {
                    Items[i].Quality = 0;       
                }
                if (!Items[i].Name.Contains("Aged Brie") && !Items[i].Name.Contains("Conjured") && !Items[i].Name.Contains("Backstage passes"))
                {
                    Items[i].Quality -= 2;
                }
                if (Items[i].Name.Contains("Conjured"))
                {
                    Items[i].Quality -= 4;
                }
                if (Items[i].Name.Contains("Aged Brie"))
                {
                    Items[i].Quality = Items[i].Quality + 2;
                }
            }
            if (!Items[i].Name.Contains("Sulfuras"))
            {
                Items[i].SellIn -= 1;
            }
            if (Items[i].Name.Contains("Sulfuras") && (Items[i].Quality < 80 || Items[i].Quality > 80))
            {
                Items[i].Quality = 80;
            }
            if (Items[i].Quality < 0)
            {
                Items[i].Quality = 0;
            }
            if (Items[i].Quality > 50 && !Items[i].Name.Contains("Sulfuras"))
            {
                Items[i].Quality = 50;
            }
        }
    }
}