# ReadFromJSONFile Project

## Overview

The **ReadFromJSONFile** project is a C# console application that processes and analyzes data from a JSON file containing information about various destinations. The application provides multiple functionalities such as filtering destinations, finding the destination with the longest duration, sorting destinations by name, and displaying the top 3 destinations based on duration.

## Project Structure

The project is organized into several namespaces and classes, each responsible for specific tasks. Here’s a brief overview:

### Namespaces and Classes

1. **ReadFromJSONFile**
   - **Program**: The main entry point of the application. It contains methods to invoke different tasks based on user input.
   - **Destination**: A class representing a destination with properties like name, type, location, duration, and description.
   - **Category**: A class representing a category of destinations.

2. **ReadFromJSONFile.Tasks**
   - **SortByName**: Contains the method to sort destinations by their names.
   - **Top3Duration**: Contains the method to display the top 3 destinations based on duration.
   - **LongestDuration**: Contains the method to find and display the destination with the longest duration.
   - **FilterDestinations**: Contains the method to filter destinations with a duration of less than 100 minutes.

## How to Use

### Prerequisites

- .NET Framework
- Newtonsoft.Json library for JSON deserialization

### Running the Application

1. **Compile the Application**: Build the solution in your preferred C# IDE (e.g., Visual Studio).
2. **Prepare the JSON File**: Ensure that the JSON file (`MagicLandData.json`) containing the destination data is located in the `data` directory within the project’s root directory.

### User Interaction

1. **Start the Application**: Run the compiled application.
2. **Choose an Option**: The application will prompt you with a menu of options:
   - `1 - Show Filtered Destinations`
   - `2 - Show Longest Duration`
   - `3 - Sort destinations by Name`
   - `4 - Show Top 3 Duration`
3. **Input Your Choice**: Enter the number corresponding to the task you want to perform and press Enter.
4. **View Results**: The application will execute the selected task and display the results in the console.
5. **Continue or Exit**: After displaying the results, the application will ask if you want to exit. Enter `Y` to exit or `N` to perform another task.

## Code Details

### Program Class

- **TaskAction Property**: An Action delegate that holds the method to be executed.
- **Constructor**: Initializes the TaskAction with the provided method.
- **ExecuteTask Method**: Invokes the assigned task.
- **Main Method**: Starts the DelegateInvoker method.
- **DelegateInvoker Method**: Handles user input and invokes the corresponding task based on the selected option.

### Task Classes

Each task class contains a static method that reads the JSON data, processes it, and prints the results to the console.

- **SortByName.sortByName**: Sorts destinations by name and displays them.
- **Top3Duration.top3Duration**: Displays the top 3 destinations based on duration.
- **LongestDuration.longestDeuration**: Finds and displays the destination with the longest duration.
- **FilterDestinations.filterDestinations**: Filters and displays destinations with a duration of less than 100 minutes.
