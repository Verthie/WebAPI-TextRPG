using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITextRPG.Dtos.Item
{
    public class GetItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Longsword";
        public int Damage { get; set; } = 1;
        public ItemType Type { get; set; } = ItemType.Sword;
    }
}