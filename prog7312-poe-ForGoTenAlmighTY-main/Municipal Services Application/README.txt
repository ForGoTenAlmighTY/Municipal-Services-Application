#Municipal Services Application

Adding Events:

Navigate to the "Local Events and Announcements" page.
Add an event by filling in the event details and clicking "Add Event."
The event will be stored in the event list, dictionary (by date), and hash table (by name).
Searching Events:

Use the search bar to search for events by name.
If the event is found, its details will be displayed.
The search will also be recorded in the search history.
Viewing Event Notifications:

View notifications for upcoming events, which are processed in the order they were added (FIFO).
Processing Priority Events:

Priority events are listed and processed first using the priority queue.
Viewing Search History:

Search history is accessible, showing the user's previous searches for quick access.


## Prerequisites
To run this application, you need to have the following installed:
- **Visual Studio** (or any C# IDE that supports WinForms development)
- **.NET Framework** (compatible with the version used in your project)

## How to run the application

1. **Clone or Download the Repository**:
   - Download the ZIP file from the repository and extract it.

2. **Open the Project**:
   - Open the solution (`.sln` file) in **Visual Studio**.

3. **Run the Application**:
   - Press `F5` or click on the **Run** button in Visual Studio to build and run the application.


## Code Overview

### Main Components:

1. **Main Form (`Main Menu`)**:
   - Displays 3 buttons that the user can click on
   - The last 2 buttons are disabled and will be implemented later in the project

2. **Report Form (`Report issues`)**:
   - Users can report issues by inputting the location, category, description of the issue and upload files to support your report .
   - It stores the reported issues in a 2D list.

2. **Events Form (`Local Event and Announcements`)**:
   - Users can report issues by inputting the location, category, description of the issue and upload files to support your report .
   - It stores the reported issues in a 2D list.
