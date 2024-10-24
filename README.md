# CrickInfo - Tournament Max Flow Predictor

## Overview
**CrickInfo** is a web application built with ASP.NET Core MVC and Entity Framework Core that helps cricket teams assess their chances of securing the top position in a tournament's points table. The application predicts whether a team can reach the top by using the **Max-Flow Algorithm** applied to a constructed bipartite graph representing matches and teams. The system analyzes remaining matches, current points, and possible future outcomes to provide a dynamic prediction of whether a team can still top the table.

## Features

- **Team & Match Management**  
  Manage teams and matches easily through a user-friendly interface. Users can add new teams and matches, update existing ones, and record match results.

- **Max-Flow Algorithm**  
  CrickInfo utilizes the **max-flow algorithm** to predict whether a selected team can still reach the top of the points table, based on remaining matches and potential outcomes.

- **Dynamic Points Table**  
  The points table updates automatically as results are entered, showing the real-time standings and highlighting the current top team.

- **Residual Graph Construction**  
  The system constructs a **bipartite residual graph** between teams and matches for analysis, helping simulate various match outcomes and future tournament possibilities.

- **Interactive Prediction**  
  Visual representation of whether the selected team can mathematically reach the top of the table based on the remaining fixtures and current standings.

## Key Concepts

### 1. Max-Flow Algorithm
The Max-Flow algorithm is used to determine whether a selected team can still finish at the top of the table. The algorithm constructs a flow network with the teams and matches as nodes, representing the matches as edges, and uses the max-flow strategy to find the optimal number of points a team can still earn.

### 2. Bipartite Graph Construction
The bipartite graph represents the relationship between teams and remaining matches. One set of nodes represents the teams, and the other represents the remaining matches. The algorithm calculates whether, through match outcomes, enough points can "flow" to the selected team to ensure it can reach or surpass the current top team.

### 3. Residual Graph
After applying the max-flow, a residual graph is created to visualize the flow of potential points from the matches to the teams, helping users understand the dynamic nature of the prediction process.

## Technologies Used

- **ASP.NET Core MVC**  
  Used for building the web application, handling routing, and delivering a smooth user interface for team and match management.

- **Entity Framework Core**  
  Handles the data layer, enabling CRUD operations for teams and matches and managing the dynamic points table.

- **Max-Flow Algorithm**  
  Applied to a constructed bipartite graph to perform the tournament analysis and predict the possibility of topping the table.

- **Bootstrap**  
  Used for styling and responsive design, making the interface user-friendly on all devices.

## Installation and Setup

### Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other EF Core-compatible database)
- Visual Studio or VS Code

### Steps to Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/CrickInfo.git
   cd CrickInfo
