﻿namespace Haystac.Domain.Events;

public class ItemAddedEvent : BaseEvent
{
    public Item Item { get; }

    public ItemAddedEvent(Item item)
    {
        Item = item;
    }

    //< TODO: Expand corresponding Collection's geometry to include added geometry
}