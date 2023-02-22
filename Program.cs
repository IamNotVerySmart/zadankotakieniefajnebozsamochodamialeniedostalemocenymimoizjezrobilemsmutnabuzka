using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using bartekjestazjatom;


string[] lines = File.ReadAllLines("C:\\Users\\admin\\source\\repos\\wsumietonwmcoalejakieszadankochybanaocenealeniejestempewien\\wsumietonwmcoalejakieszadankochybanaocenealeniejestempewien\\samochody.txt");
Samochod[] Samochody = new Samochod[lines.Length];
int i = 0;
    foreach(string line in lines)
    {
        string[] entries = line.Split(' ');
        Samochody[i] = new Samochod(entries[0], entries[1], double.Parse(entries[2], System.Globalization.CultureInfo.InvariantCulture), int.Parse(entries[3]));
        i++;
    }
    foreach(Samochod samochod in Samochody)
    {
        Console.WriteLine(samochod.ToString());
    }
    

    