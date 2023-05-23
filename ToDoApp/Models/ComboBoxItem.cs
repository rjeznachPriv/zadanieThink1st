using System;

namespace ToDoApp.Models
{
    class ComboBoxItem
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string FullName { get { return $"{Name} - [${ID}]"; } }
    }
}
