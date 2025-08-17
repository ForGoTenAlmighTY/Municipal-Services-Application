<h1>Municipal Services Application</h1>
<h2>Overview</h2>
<p>The Municipal Services Application is a Windows Forms-based system designed to streamline municipal services. It provides users with tools to:</p> 

<li>Report issues and track their status.</li>
<li>View and manage local events and announcements.</li>
<li>Submit and monitor service requests using advanced data structures.</li>
<p>This project leverages efficient algorithms and robust data structures such as Binary Search Trees, Min-Heaps, and Graphs for seamless performance. </p>

<h2>Features</h2>
<h3>1. Main Menu</h3>
<li>Unified interface for navigation between key functionalities.
<li>Access to: Issue Reporting, Local Events and Announcements, Service Request Status</li></li>

<h3>2. Issue Reporting</h3>
<li>Submit issues such as broken infrastructure or noise complaints.</li>
<li>Issues are stored in a List, with options for future database integration.</li>

<h3>3. Local Events and Announcements</h3>
<li>View a well-organized list of events and announcements.</li>
<li>Search and filter events by:</li>
  <li>Category: e.g., Music, Sports, Conferences.</li>
  <li>Date: View events within a specific date range.</li>
<li>Efficient event storage using a SortedDictionary<DateTime, List<Event>>.</li>
  
<h3>4. Service Request Status</h3>
<li>Submit service requests with details like Request ID, Description, Priority, and Status.</li>
<li>Track requests using:</li>
<li>Binary Search Trees (BST) for efficient search by Request ID.</li>
<li>Min-Heaps for priority-based processing.</li>
<li>Graphs for visualizing dependencies between requests.</li>
<li>Process high-priority requests dynamically.</li>


<h2>Technologies Used</h2>
<h3>Programming Language: </h3>
<li>C# (.NET Framework)</li>

<h3>Data Structures:</h3>
Binary Search Tree (BST):
<li>Organizes requests for efficient search and retrieval.</li>
  
<h3>Min-Heap:</h3>
<li>Handles priority-based processing.</li>

<h3>UI Framework:</h3>
<li>Windows Forms</li>
  
<h2>How to Compile and Run</h2>
<h3>Prerequisites: </h3>
<li>Visual Studio (2019 or later) installed.</li>
<li>.NET Framework or .NET Core.</li>
<h3>Steps: </h3>
<li>Clone or download the project repository: git clone <repository-url></li>
<li>Open the solution file (MunicipalServicesApp.sln) in Visual Studio.</li>
<li>Build the project: Go to Build > Build Solution or press Ctrl+Shift+B.</li>
<li>Run the application: Press F5 or go to Debug > Start Debugging.</li>
  
<h2>How to Use the Application</h2>
<h3>1. Main Menu </h3>
<li>Navigate to different sections:</li>
<li>Report an issue.</li>
<li>View events and announcements.</li>
<li>Submit and track service requests.</li>

<h3>2. Issue Reporting</h3>
<li>Enter issue details (e.g., type, location, description).</li>
<li>Submit the issue using the Submit Issue button.</li>
  
<h3>3. Local Events and Announcements</h3>
<li>View upcoming events in a table format.</li>
<li>Use search and filter options:</li>
<li>Filter by event category or date.</li>
<li>Add or remove events as needed.</li>
  
<h3>4. Service Request Status</h3>
<li>Add a service request: Enter Request ID, Description, Priority, and select Status.</li>
<li>View all requests in a sorted table.</li>
<li>Search for a specific request by Request ID.</li>
<li>Process high-priority requests: Use the Process Priority button to handle the most critical request.</li>

  
<h2>Data Structures Explanation</h2>
<h3>1. Binary Search Tree (BST)</h3>
<li>Purpose: Stores service requests by Request ID.</li>
<li>Efficiency: Quick search and retrieval using logarithmic time complexity.</li>
<li>Usage:Locate a specific request by Request ID. Display all requests in sorted order.</li>
  
<h3>2. Min-Heap</h3>
<li>Purpose: Dynamically prioritizes service requests.</li>
<li>Efficiency: Processes the highest-priority request in constant time.</li>
<li>Usage: Handle critical service requests efficiently.</li>
