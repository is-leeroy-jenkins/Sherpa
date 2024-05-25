## ﻿![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/BudgetExecution.png)

#### An open source data analysis and financial management application for EPA analysts developed in C# and released under the MIT license.

## Features

- Mutliple data providers.
- Charting and reporting.
- Conduct analysis with a unique web-browser providing searches optimized for researching .gov domains with [Baby](https://github.com/KarmaScripter/Baby/blob/main/README.md)
- Pre-defined schema for budgetary data tables for environmental data analysis.
- Multiple SQL Editors including SQLite, SQL Compact, MS Access, and SQL Server
- Excel-like user interface over real databases.
- GIS data and mapping for congressional earmark reporting and montioring of pollution sites.
- Easy access to environmental program project descriptions with their statutory authority.
- Quick budget and accouting calculations directly on bound data.
- Easily add agency/region/division-specific branding.

## Providers

- SQLite is a C-language library that implements a small, fast, self-contained, high-reliability, full-featured, SQL database engine. [more here](https://sqlite.org/index.html) 
- SQL CE is a discontinued but still useful relational database produced by Microsoft for applications that run on mobile devices and desktops. [more here](https://www.microsoft.com/en-us/download/details.aspx?id=30709)
- SQL Server Express Edition is a scaled down, free edition of SQL Server, which includes the core database engine. [more here](https://www.microsoft.com/en-us/download/details.aspx?id=101064)
- MS Access is a database management system (DBMS) from Microsoft that combines the relational Access Database Engine (ACE) with a graphical user interface and software-development tools. [more here](https://www.microsoft.com/en-us/microsoft-365/access)


## System requirements

- You need [VC++ 2019 Runtime](https://aka.ms/vs/17/release/vc_redist.x64.exe) 32-bit and 64-bit versions

- You will need .NET 6.

- You need to install the version of VC++ Runtime that Baby Browser needs. Since we are using CefSharp 106, according to [this](https://github.com/cefsharp/CefSharp/#release-branches) we need the above versions


## Getting started

- See the [Compilation Guide](Resources/Github/Compilation.md) for steps to get started.


## Documentation

- [User Guide](Resources/Github/Users.md)
- [Compilation Guide](Resources/Github/Compilation.md)
- [Configuration Guide](Resources/Github/Configuration.md)
- [Distribution Guide](Resources/Github/Distribution.md)


## Code

- Uses CefSharp 106 for Baby and is built on NET 6/7/8
- Supports AnyCPU as well as x86/x64 specific builds
- [Controls](https://github.com/KarmaScripter/BudgetExecution/tree/main/Controls) - main UI layer and associated controls and related functionality.
- [Enumerations](https://github.com/KarmaScripter/BudgetExecution/tree/main/Enumerations) - various enumerations used for budgetary accounting.
- [Extensions](https://github.com/KarmaScripter/BudgetExecution/tree/main/Extensions)- useful extension methods for budget analysis by type.
- [Clients](https://github.com/KarmaScripter/BudgetExecution/tree/main/Clients) - other tools used and available.
- [Ninja](https://github.com/KarmaScripter/BudgetExecution/tree/main/Ninja) - models used in EPA budget data analysis.
- [IO](https://github.com/KarmaScripter/BudgetExecution/tree/main/IO) - input output classes used for networking and the file systemm.
- [Static](https://github.com/KarmaScripter/BudgetExecution/tree/main/Static) - static types used in the analysis of environmental budget data.
- [Interfaces](https://github.com/KarmaScripter/BudgetExecution/tree/main/Interfaces) - abstractions used in the analysis of environmental budget data.
- `bin` - Binaries are included in the `bin` folder due to the complex Baby setup required. Don't empty this folder.
- `bin/storage` - HTML and JS required for downloads manager and custom error pages


## Easily analyze financial data.
- #### Datagrids
- #### Pivot Tables
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Datagrid.gif)

## User Interface with a familiar look & feel.
- #### Excel-like interface over a relational database
- #### Import and export spreadsheet data
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/ExcelUserInterface.gif)

## Geospatial Information (GIS) Mapping.
- #### Congressional earmark reporting
- #### Monitor pollution site remediation costs
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Map.gif)

## Baby Browser 
- #### Using the [Chromium Embedded Framework](https://en.wikipedia.org/wiki/Chromium_Embedded_Framework)
![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/2.png)

## Budget Calculator 
- #### For quick & dirty accounting and budget calculations on bound data.
- #### Easy access to the full functionality of CALC.EXE

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Calculator.gif)

## Federal Fiscal Year Calendar
- #### Calculations using full-time equivalency metrics.
- #### Ad-hoc analysis of variable periods of availability.
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/FiscalYear.gif)

## Web development on the fly with [Orca](https://github.com/KarmaScripter/Orca)
- #### Create ad-hoc web information
- #### HTML5, CSS, and Javascript
   
## Environmental Program Anaylsis
- #### Definitions and statutory authorities
- #### Information bound directly to financial data

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/EnvironmentalPrograms.gif)

## Data Visualization
- #### 3D Charting
- #### Pivot Charts
- #### Plotting from ScottPlot
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Charts.gif)


## DocViewer
- #### Library of legal documentation used in evnironmental data analysis.
- #### Interact with, view and access PDFs outside the application
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Guidance.gif)



## SQL Editors for multiple providers

- SQLite

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/SQLite.gif)

- MS Access

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Access.gif)

- SQL Compact Edition

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/SqlCe.gif)

- SQL Server Express

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/SqlServer.gif)



## Credits


