class Player
{
    public int ID { get; set; }              // Unique identifier
    public string Name { get; set; }         // Player name
    public int Level { get; set; }           // Player level
    public int ExpPoints { get; set; }       // Experience points

    public int HP { get; set; }              // Current health
    public int MaxHP { get; set; }           // Maximum health

    public int Mana { get; set; }            // Current mana
    public int MaxMana { get; set; }         // Maximum mana

    public int Attack { get; set; }          // Attack power
    public int Defense { get; set; }         // Defense power

    public List<Item> Inventory { get; set; } // List of items
    public List<Skill> Skills { get; set; }   // List of learned skills
}