using System;

namespace ToDoApp.Models
{
    public class ComboBoxItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string FullName { get { return $"{Name} - [${ID}]"; } }
    }
}
