namespace PartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var initialGuests = Console.ReadLine().Split().ToList();
            var filters = new Dictionary<string, HashSet<string>>();
            var endCommand = "Print";
            var command = Console.ReadLine();
            while (command != endCommand)
            {
                var commandArguments = command.Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                AddFilters(filters, commandArguments);

                command = Console.ReadLine();
            }

            initialGuests = ApplyFiltrations(initialGuests, filters);

            Console.WriteLine(String.Join(" ", initialGuests));

        }

        private static void AddFilters(Dictionary<string, HashSet<string>> filters, string[] inputArgs)
        {
            var command = inputArgs[0];
            var filterType = inputArgs[2];
            var criteria = filterType == "Contains" || filterType == "Length" ? inputArgs[3] : inputArgs[4];

            switch (command)
            {
                case "Add":

                    if (!filters.ContainsKey(filterType))
                    {
                        filters[filterType] = new HashSet<string>();
                    }

                    filters[filterType].Add(criteria);
                    break;
                case "Remove":
                    filters[filterType].Remove(criteria);
                    break;
            }
        }

        private static List<string> ApplyFiltrations(List<string> initialGuests, Dictionary<string, HashSet<string>> filters)
        {
            foreach (var filter in filters)
            {
                foreach (var criteria in filter.Value)
                {
                    switch (filter.Key)
                    {
                        case "Starts":
                            initialGuests = initialGuests.Where(x => !x.StartsWith(criteria)).ToList();
                            break;
                        case "Ends":
                            initialGuests = initialGuests.Where(x => !x.EndsWith(criteria)).ToList();
                            break;
                        case "Length":
                            initialGuests = initialGuests.Where(x => x.Length != int.Parse(criteria)).ToList();
                            break;
                        case "Contains":
                            initialGuests = initialGuests.Where(x => !x.Contains(criteria)).ToList();
                            break;
                    }
                }
            }

            return initialGuests;
        }
    }
}
