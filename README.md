##  Sherpa
## ﻿![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Sherpa.png)

#### An open source data analysis and budget execution application for EPA analysts and released under the MIT license.

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/features.png)  Features

- Mutliple data providers.
- Visualizations and reporting.
- Conduct analysis with a unique web-browser providing searches optimized for researching .gov domains with [Baby](https://github.com/KarmaScripter/Baby/blob/main/README.md)
- Pre-defined schema for budgetary data tables for environmental data analysis.
- Multiple SQL Editors including SQLite, SQL Compact, MS Access, and SQL Server
- Excel-like user interface over real databases.
- GIS mapping for reporting and monitoring.
- Easy access to environmental program descriptions with their statutory authority.
- Ad-hoc calculations on bound data.
- Add agency/region/division-specific branding.
- The WPF-based version of Sherpa is [Badger](https://github.com/KarmaScripter/Badger)

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Providers.png)Providers

- SQLite is a C-language library that implements a small, fast, self-contained, high-reliability, full-featured, SQL database engine. [more here](https://sqlite.org/index.html) 
- SQL CE is a discontinued but still super-useful relational database produced by Microsoft for applications that run on mobile devices and desktops. [more here](https://www.microsoft.com/en-us/download/details.aspx?id=30709)
- SQL Server Express Edition is a scaled down, free edition of SQL Server, which includes the core database engine. [more here](https://www.microsoft.com/en-us/download/details.aspx?id=101064)
- MS Access is the OG of enterprise database management systems (DBMS) from Microsoft that combines the relational Access Database Engine (ACE) with a graphical user interface and software-development tools. [more here](https://www.microsoft.com/en-us/microsoft-365/access)
- Schema and test data are available [here](https://drive.google.com/drive/folders/16jRZA_5sgN4kGSfVYl-13wzszoVTwVFO?usp=sharing).


## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/system_requirements.png)  System requirements

- You need [VC++ 2019 Runtime](https://aka.ms/vs/17/release/vc_redist.x64.exe) 32-bit and 64-bit versions

- You will need .NET 6.

- You need to install the version of VC++ Runtime that Baby Browser needs. Since we are using CefSharp 106, according to [this](https://github.com/cefsharp/CefSharp/#release-branches) we need the above versions


## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/documentation.png) Documentation

- [User Guide](Resources/Github/Users.md)
- [Compilation Guide](Resources/Github/Compilation.md)
- [Configuration Guide](Resources/Github/Configuration.md)
- [Distribution Guide](Resources/Github/Distribution.md)


## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/csharp.png) Code

- Uses CefSharp 106 for Baby and is built on NET 6/7/8
- Supports AnyCPU as well as x86/x64 specific builds
- [Controls](https://github.com/KarmaScripter/Sherpa/tree/main/Controls) - main UI layer and associated controls and related functionality.
- [Enumerations](https://github.com/KarmaScripter/Sherpa/tree/main/Enumerations) - various enumerations used for budgetary accounting.
- [Extensions](https://github.com/KarmaScripter/Sherpa/tree/main/Extensions)- useful extension methods for budget analysis by type.
- [Clients](https://github.com/KarmaScripter/Sherpa/tree/main/Clients) - other tools used and available.
- [Ninja](https://github.com/KarmaScripter/Sherpa/tree/main/Ninja) - models used in EPA budget data analysis.
- [IO](https://github.com/KarmaScripter/Sherpa/tree/main/IO) - input output classes used for networking and the file systemm.
- [Static](https://github.com/KarmaScripter/Sherpa/tree/main/Static) - static types used in the analysis of environmental budget data.
- [Interfaces](https://github.com/KarmaScripter/Sherpa/tree/main/Interfaces) - abstractions used in the analysis of environmental budget data.
- `bin` - Binaries are included in the `bin` folder due to the complex Baby setup 

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/tools.png) Data Tools
- ##### Datagrids & Filters
- ##### Pivot Charts & Tables
- ##### Plotting & Graphs
![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Datagrid.gif)

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/excel.png) The Interface
- ##### Excel-like UI over a relational database
- ##### Import and export spreadsheet data
![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/ExcelUserInterface.gif)

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Maps.png) Maps.
- ##### Congressional earmark reporting
- ##### Monitor pollution site remediation costs
![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Map.gif)

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/baby.png) Baby
- ##### Stand-alone web browser built with the [Chromium Embedded Framework](https://en.wikipedia.org/wiki/Chromium_Embedded_Framework)
- ##### Ad-hoc searches with customized pop-up input.
- ##### Search across multiple .gov domains
![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/Overview.gif)

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Calculation.png) Budget Calculations
- ##### Quick & dirty accounting and budget calculations directly on bound data.
- ##### Easy access to the full functionality of the widows calculator

![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Calculator.gif)

## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/calendar.png) FY Calendar
- ##### Calculations using the federal fiscal year. 
- ##### Compatible with full-time equivalency metrics.
- ##### Ad-hoc analysis of variable periods of availability.
![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/FiscalYear.gif)

## [Orca](https://github.com/KarmaScripter/Orca)
- ##### Ad-hoc web development
- ##### Network communications
- ##### HTML5, CSS, and Javascript
  
![](https://github.com/KarmaScripter/Orca/blob/main/etc/github/Overview.gif)
   
## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/epa.png) Environmental Program Anaylsis
- ##### Definitions and statutory authorities
- ##### Information bound directly to financial data

![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/EnvironmentalPrograms.gif)

##  ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/tools.png) Visualization Tools
- ##### 3D Charting
- ##### Pivot Charts
- ##### Plotting & Graphs
  
![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Charts.gif)


## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/document.png) Document Viewer
- ##### Access to legal documentation used in evnironmental data analysis.
- ##### Interact with external PDFs.
![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Guidance.gif)



## ![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/sql.png)  Editors

- SQLite

![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/SQLite.gif)

- MS Access

![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/Access.gif)

- SQL Compact Edition

![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/SqlCe.gif)

- SQL Server Express

![](https://github.com/KarmaScripter/Sherpa/blob/main/Resources/Assets/GitHubImages/SqlServer.gif)





