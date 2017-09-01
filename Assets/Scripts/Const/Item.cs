
using System.Collections.Generic;
using System;

public static partial class Const {
    public enum Item {
        Item1,
        Item2,
        Item3,
        Item4
    }
    public static string GetString(this Item item) {
        return Enum.GetName(typeof(Item), item);
    }
}