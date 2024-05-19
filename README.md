## ﻿![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/BudgetExecution.png)

## Budget Execution is an open source data analysis application for Analysts in the US EPA developed in C# and released under the MIT license.

## Features

- Mutliple data providers including SQLite, MS Access, SQL CE, and SQL Servers Express Edition.
- Charting and reporting.
- Its own internal web browser with searches optimized for researching data in the government domain with [Baby Browser](https://github.com/KarmaScripter/Baby/blob/main/README.md)
- Pre-defined schema for 100 actively used environmental budget data tables.
- Editors for SQLite, SQL Compact Edition, MS Access, SQL Server Express.
- Excel-like user interface over real databases.
- Mapping for congressional earmark reporting and montioring of polluction sites.
- Easy access to environmental program project descriptions and statutory authority.
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

- BudgetExecution uses CefSharp 106 for Baby Browser and is built on NET 6
- BudgetExecution supports AnyCPU as well as x86/x64 specific builds
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

## Easily query financial data.
- #### Datagrids
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Datagrid.PNG)

## UI with a familiar look & feel.
- #### Excel-like interface over a relational database
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/ExcelUserInterface.PNG)

## Congressional earmark reporting and pollution site monitoring.
- ### Maps
![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Map.PNG)

## Baby Browser using the [Chromium Embedded Framework](https://en.wikipedia.org/wiki/Chromium_Embedded_Framework)

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/2.png)

## Budget Calculator for quick accounting transactions and budget calculations on the data.

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Calculator.PNG)

## Federal fiscal year utilities compatable with full-time equivalency metrics.

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/FiscalYear.PNG)

## Environmental program definitions and statutory authorities bound directly to financial data

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/EnvironmentalPrograms.PNG)

## Data Visualization

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Charts.PNG)


## View environmental laws & guidance via DocViewer

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Guidance.PNG)



## SQL Editors for multiple providers

- SQLite

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/SQLite.PNG)

- MS Access

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/Access.PNG)

- SQL Compact Edition

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/SqlCe.PNG)

- SQL Server Express

![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/SqlServer.PNG)



## Credits


