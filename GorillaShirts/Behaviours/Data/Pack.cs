﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GorillaShirts.Behaviors.Data
{
    public class Pack
    {
        public List<Shirt> PackagedShirts = new();
        public Dictionary<string, Shirt> ShirtNameDictionary = new();

        public string Name, DisplayName;
        public int CurrentItem;

        public void Randomize()
        {
            Random _random = new();
            CurrentItem = _random.Next() % PackagedShirts.Count;
            PackagedShirts = PackagedShirts.OrderBy(a => _random.Next()).ToList();
        }
    }
}
