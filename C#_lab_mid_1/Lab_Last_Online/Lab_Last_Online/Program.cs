using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Last_Online
{
    abstract class LibraryResource
    {
        private string title;
        private int publicationYear;

        public int ResourceID { get; private set; }

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty.");
                title = value;
            }
        }

        public int PublicationYear
        {
            get => publicationYear;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Publication year cannot be negative.");
                publicationYear = value;
            }
        }

        protected LibraryResource(int resourceID, string title, int publicationYear)
        {
            ResourceID = resourceID;
            Title = title;
            PublicationYear = publicationYear;
        }

        public abstract void DisplayDetails();
        public abstract void AccessContent();

        protected void PrintCommonInfo()
        {
            Console.WriteLine($"  Resource ID      : {ResourceID}");
            Console.WriteLine($"  Title            : {Title}");
            Console.WriteLine($"  Publication Year : {PublicationYear}");
        }
    }

    class Book : LibraryResource
    {
        public string Author { get; set; }

        public Book(int resourceID, string title, int publicationYear, string author)
            : base(resourceID, title, publicationYear)
        {
            Author = author;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n[BOOK]");
            PrintCommonInfo();
            Console.WriteLine($"  Author           : {Author}");
        }

        public override void AccessContent()
        {
            Console.WriteLine($"  -> Opening book \"{Title}\" by {Author} for reading...");
        }
    }

    class Journal : LibraryResource
    {
        public int VolumeNumber { get; set; }

        public Journal(int resourceID, string title, int publicationYear, int volumeNumber)
            : base(resourceID, title, publicationYear)
        {
            VolumeNumber = volumeNumber;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n[JOURNAL]");
            PrintCommonInfo();
            Console.WriteLine($"  Volume Number    : {VolumeNumber}");
        }

        public override void AccessContent()
        {
            Console.WriteLine($"  -> Loading journal \"{Title}\", Volume {VolumeNumber}...");
        }
    }

    class Video : LibraryResource
    {
        public double DurationMinutes { get; set; }

        public Video(int resourceID, string title, int publicationYear, double durationMinutes)
            : base(resourceID, title, publicationYear)
        {
            DurationMinutes = durationMinutes;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n[VIDEO]");
            PrintCommonInfo();
            Console.WriteLine($"  Duration         : {DurationMinutes} minutes");
        }

        public override void AccessContent()
        {
            Console.WriteLine($"  -> Playing video \"{Title}\" ({DurationMinutes} min)...");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("   DIGITAL LIBRARY SYSTEM");
            Console.WriteLine("========================================");

            LibraryResource[] library = new LibraryResource[]
            {
                new Book   (101, "Book 1",                    2008, "Robert"),
                new Book   (102, "Programming book",          1999, "Andrew Hunt"),
                new Journal(201, "Nature",                    2023, 45),
                new Journal(202, "IEEE",                      2022, 12),
                new Video  (301, "Introduction to C#",        2021, 75.5),
                new Video  (302, "Data Structures and Algo",  2020, 120.0)
            };

            Console.WriteLine("\n--- ALL RESOURCES IN LIBRARY ---");
            foreach (LibraryResource resource in library)
            {
                resource.DisplayDetails();
            }

            Console.WriteLine("\n--- ACCESSING ALL RESOURCES ---");
            foreach (LibraryResource resource in library)
            {
                resource.AccessContent();
            }

            Console.WriteLine("\n--- VALIDATION DEMO ---");

            try
            {
                Book badBook = new Book(999, "", 2020, "Unknown");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"  Error: {ex.Message}");
            }

            try
            {
                Journal badJournal = new Journal(998, "Bad Journal", -5, 1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"  Error: {ex.Message}");
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("   END OF PROGRAM");
            Console.WriteLine("========================================");

            Console.ReadKey();
        }
    }
}
