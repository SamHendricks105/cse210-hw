DateTime.Now.ToString("M/d/yyyy");
//.......................................................
string path =null;

        path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        string filepath = Path.Combine(path, "name.txt");
        using (StreamWriter sw = new StreamWriter(filepath))
        {
            sw.Write("yo yo yo");
        }

//..............................................
        foreach (string line in e._entry)
        {
            Console.WriteLine(line);
        }

// asks the user for their entry.
            
            
            j.AllEntries.Add(e._date);
            j.AllEntries.Add(e._prompt);
           
            Console.WriteLine("");
            Console.WriteLine("");
            string storage ="";
            return j;

//...................................
