using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services_Application
{


    public partial class Events : Form
    {
        // Sorted dictionary to store events based on their date.
        SortedDictionary<DateTime, List<LocalEvents>> eventsDictionary = new SortedDictionary<DateTime, List<LocalEvents>>();

        // Stack to keep track of the user's search history.
        Stack<string> searchHistory = new Stack<string>();

        // Queue for event notifications, ensuring that events are notified in the order they were added (FIFO - First In, First Out).
        Queue<LocalEvents> eventNotifications = new Queue<LocalEvents>();

        // Sorted list to store events based on their priority level.
        SortedList<int, List<LocalEvents>> priorityQueue = new SortedList<int, List<LocalEvents>>();

        // Hashtable to store events based on their name for quick search access.
        Hashtable eventTable = new Hashtable();

        public Events()
        {
            InitializeComponent();

            // Set the background image from the Resources folder
            string imagePath = @"D:\SCHOOL\Varsity College Work\Year 3\Semester 2\PROG7312\Municipal Services Application\mix.jpg";
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image
        }

        //// Load event data when the form loads.
        private void Events_Load(object sender, EventArgs e)
        {
            LoadEvents(); // Load sample events into the system
            DisplayAllEvents(); // Show all events in the DataGridView
        }

        // Function to add an event to the hash table
        private void AddEventToHashTable(LocalEvents newEvent)
        {
            if (!eventTable.ContainsKey(newEvent.Name))
            {
                eventTable.Add(newEvent.Name, newEvent);
            }
        }

        //Adds a new event to a queue to notify users about upcoming events in a first-in, first-out (FIFO) order
        private void AddToNotificationQueue(LocalEvents newEvent)
        {
            eventNotifications.Enqueue(newEvent);
        }

        // Adds an event to the priority queue, where each event is assigned a priority value for importance.
        private void AddToPriorityQueue(LocalEvents newEvent, int priority)
        {
            // Check if the priority already exists in the sorted list
            if (!priorityQueue.ContainsKey(priority))
            {
                // If not, create a new list for this priority
                priorityQueue[priority] = new List<LocalEvents>();
            }

            // Add the event to the list associated with this priority
            priorityQueue[priority].Add(newEvent);
        }

        //Returns the priority value for an event based on its category.
        private int GetPriority(string category)
        {
            // Different categories have different priorities.
            switch (category)
            {
                case "Conferences": return 3;
                case "Education": return 1;
                case "Health": return 2;
                default: return 4;
            }
        }

        //Processes and displays high-priority events in the order of their importance
        private void ProcessPriorityEvents()
        {
            // Access the key and value (the list of events) by index
            int priority = priorityQueue.Keys[0];         // Get the key at index 0
            List<LocalEvents> eventList = priorityQueue.Values[0]; // Get the list of events for this priority

            // Now use a for loop to iterate over the list of events
            for (int j = 0; j < eventList.Count; j++)
            {
                LocalEvents currentEvent = eventList[j];
                MessageBox.Show($"High-Priority Event: {currentEvent.Name} (Priority: {priority})");
            }

        }

        // Adds an event to multiple data structures (SortedDictionary, HashTable, Notification Queue, Priority Queue).
        private void AddEvent(string name, string category, DateTime date, string description)
        {
            LocalEvents newEvent = new LocalEvents { Name = name, Category = category, Date = date, Description = description };

            // Add event to the SortedDictionary based on its date.
            if (!eventsDictionary.ContainsKey(date))
            {
                eventsDictionary[date] = new List<LocalEvents>();
            }
            eventsDictionary[date].Add(newEvent);

            AddEventToHashTable(newEvent); // Add event to hash table
            AddToNotificationQueue(newEvent); // Add event to notification queue
            AddToPriorityQueue(newEvent, GetPriority(category)); // Add event to priority queue
        }

        // Load sample events into the system for demonstration purposes.
        private void LoadEvents()
        {
            AddEvent("Music Festival", "Music", new DateTime(2024, 10, 25), "Enjoy a full day of live music.");
            AddEvent("Tech Conference", "Conferences", new DateTime(2024, 11, 10), "Discuss the latest in tech.");
            AddEvent("Football Match", "Sports", new DateTime(2024, 10, 15), "Watch an exciting football game.");
            AddEvent("Art Exhibition", "Art", new DateTime(2024, 11, 20), "Explore modern art at the local gallery.");
            AddEvent("Food Truck Festival", "Food", new DateTime(2024, 10, 30), "Taste delicious food from local vendors.");
            AddEvent("Coding Bootcamp", "Education", new DateTime(2024, 12, 01), "Learn to code with hands-on experience.");
            AddEvent("Community Cleanup", "Volunteer", new DateTime(2024, 11, 25), "Help clean up the local park.");
            AddEvent("Jazz Night", "Music", new DateTime(2024, 11, 15), "A relaxing night of live jazz music.");
            AddEvent("Book Fair", "Education", new DateTime(2024, 10, 18), "Browse and purchase books from various genres.");
            AddEvent("Winter Carnival", "Festivals", new DateTime(2024, 12, 20), "Enjoy games, rides, and entertainment at the annual carnival.");
            AddEvent("Yoga Workshop", "Health", new DateTime(2024, 11, 05), "Join a wellness workshop to practice yoga.");
            AddEvent("Halloween Party", "Festivals", new DateTime(2024, 10, 31), "Celebrate Halloween with costumes and music.");
            AddEvent("Startup Pitch Night", "Business", new DateTime(2024, 12, 15), "Pitch your business ideas to investors.");
            AddEvent("Film Screening: Indie Films", "Movies", new DateTime(2024, 11, 18), "Watch independent films at the local cinema.");
            AddEvent("Cooking Class: Italian Cuisine", "Food", new DateTime(2024, 12, 10), "Learn to cook delicious Italian dishes.");
            AddEvent("Photography Workshop", "Education", new DateTime(2024, 10, 20), "Improve your photography skills with expert advice.");
            AddEvent("Outdoor Adventure Trip", "Adventure", new DateTime(2024, 11, 28), "Join us for hiking and outdoor activities.");
            AddEvent("Basketball Tournament", "Sports", new DateTime(2024, 12, 12), "Participate in a local basketball competition.");
            AddEvent("Entrepreneurship Seminar", "Business", new DateTime(2024, 10, 27), "Learn from successful entrepreneurs.");
        }

        // Display all events in the DataGridView by pulling from the SortedDictionary.
        private void DisplayAllEvents()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");

            foreach (var dateEntry in eventsDictionary)
            {
                foreach (var eventItem in dateEntry.Value)
                {
                    dt.Rows.Add(eventItem.Name, eventItem.Category, eventItem.Date.ToShortDateString(), eventItem.Description);
                }
            }

            dataGridView1.DataSource = dt;
        }

        // Searches for events based on keyword, category, and date. Displays the results in the DataGridView.
        private void SearchEvents(string category, string date)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");

            // Loop through the events and filter them based on the search criteria.
            foreach (var dateEntry in eventsDictionary)
            {

                if (!string.IsNullOrEmpty(date) && dateEntry.Key.ToShortDateString()!=date)
                    continue;

                foreach (var eventItem in dateEntry.Value)
                {
                    if (!string.IsNullOrEmpty(category) && eventItem.Category != category)
                        continue;

                    dt.Rows.Add(eventItem.Name, eventItem.Category, eventItem.Date.ToShortDateString(), eventItem.Description);
                }
            }

            dataGridView1.DataSource = dt; // Display the filtered results.
        }

        // Save the user's search query into the stack to track the search history.
        private void SaveSearchHistory(string category, string date)
        {
            string searchQuery = $"Category: {category}, Date: {date?? "Any"}";
            searchHistory.Push(searchQuery);
        }

        // Search for an event by its name using the hash table.
        private void SearchEventByName(string eventName)
        {
            if (eventTable.Contains(eventName))
            {
                LocalEvents foundEvent = (LocalEvents)eventTable[eventName]; // Retrieve the event from the hash table.
                MessageBox.Show($"Event Found: {foundEvent.Name} on {foundEvent.Date.ToShortDateString()}"); // Display the found event.
            }
            else
            {
                MessageBox.Show("Event not found."); // Display message if the event is not found in the hash table.
            }
        }

        // Triggered when the user clicks the search button, searches based on keyword, category, and date.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = comboBoxCategory.SelectedItem?.ToString(); // Get the selected category.
            string date = dateTimePicker1.Value.ToShortDateString() ; // Check if a date is selected.

            SaveSearchHistory(category, date); // Save the search query in the stack (search history).
            SearchEvents(category, date); // Perform the actual event search.

        }

        // Show the last search query (from the stack) when the user clicks the "Show Search History" button.
        private void btnShowSearchHistory_Click(object sender, EventArgs e)
        {
            if (searchHistory.Count > 0)
            {
                string lastSearch = searchHistory.Peek(); // Peek the last search query without removing it from the stack.
                MessageBox.Show($"Last Search: {lastSearch}"); // Display the last search query in a message box.
            }
            else
            {
                MessageBox.Show("No search history available."); // Display message if no searches have been made.
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            if (priorityQueue.Count > 0)
            {
                ProcessPriorityEvents();  // Call the function to show high-priority events
            }
            else
            {
                MessageBox.Show("No high-priority events available.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayAllEvents();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string eventName = txtSearch.Text;
            if (!string.IsNullOrEmpty(eventName))
            {
                SearchEventByName(eventName); // Call the search function
            }
            else
            {
                MessageBox.Show("Please enter an event name to search.");
            }
        }
    }
}
