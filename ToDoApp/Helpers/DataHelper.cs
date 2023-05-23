using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp
{
    public class DataHelper
    {
        const int YEARS_DISTANCE = 5;

        // W poleceniu do zadania napisano:
        // "Parametrem funkcji jest aktualna data"
        // Przyjalem wiec, ze bedzie to domyslna wartosc parametru.
        public static List<ComboBoxItem> GetYears(DateTime? startDate)
        {
            if (!startDate.HasValue) {
                startDate = DateTime.Now;
            }

            return CalculateYears(startDate.Value).ToList();
        }

        private static IEnumerable<ComboBoxItem> CalculateYears(DateTime date)
        {
            for (var i = 0; i <= 2 * YEARS_DISTANCE + 1; i++) {
                yield return new ComboBoxItem {
                    ID = i.ToString(),
                    Name = (date.Year - YEARS_DISTANCE + i).ToString()
                };
            }
        }
    }
}