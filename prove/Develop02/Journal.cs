    class Journal
    {
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt)
        {
            Console.Write($"{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")} - {prompt}\n> ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string time = DateTime.Now.ToString("HH:mm:ss");
            entries.Add(new Entry(prompt, response, date, time));
        }

        public void DisplayAll()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        public void SaveToFile()
        {
            Console.Write("Enter a Filename (including extension): ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Time,Prompt,Response");

                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetTime()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}");
                }
            }

            Console.WriteLine("Saved");
        }

        public void LoadFromFile()
        {
            Console.Write("Enter a filename: ");
            string filename = Console.ReadLine();
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string headerLine = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');

                    string date = fields[0];
                    string time = fields[1];
                    string prompt = fields[2].Replace(",,", ",");
                    string response = fields[3].Replace(",,", ",");

                    entries.Add(new Entry(prompt, response, date, time));
                }
            }
        }
    }