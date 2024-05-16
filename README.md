![](https://github.com/KarmaScripter/BudgetExecution/blob/main/Resources/Assets/GitHubImages/BudgetExecution.png)

## Budget Execution is an open source data analysis application for Analysts in the US EPA developed in C# and released under the MIT license.

## Features

- Mutliple data providers including SQLite, MS Access, SQL CE, and SQL Servers Express Edition.
- Charting and reporting.
- Its own internal web browser [Baby Browser](https://github.com/KarmaScripter/Baby/blob/main/README.md#baby-is-an-open-source-c-web-browser-released-under-the-mit-license)
- Pre-defined schema for 100 actively used data tables.
- SQL Editors for SQLite DB Browswer and SQL Compact Edition
- Excel User Interface over real databases.
- Map functionality
- Easy access to environmental program project descriptions of statutory authority.
- Quick calculations via Budget Calculator
- Easily add vendor-specific branding, buttons or hotkeys
- View online & offline webpages with Baby Browser

## Providers

- SQLite is a C-language library that implements a small, fast, self-contained, high-reliability, full-featured, SQL database engine. [Get here](https://sqlite.org/index.html) 
- SQL CE is a discontinued but still useful relational database produced by Microsoft for applications that run on mobile devices and desktops. [Get here](https://www.microsoft.com/en-us/download/details.aspx?id=30709)
- SQL Server Express Edition is a scaled down, free edition of SQL Server, which includes the core database engine. [Get here](https://www.microsoft.com/en-us/download/details.aspx?id=101064)
- MS Access is a database management system (DBMS) from Microsoft that combines the relational Access Database Engine (ACE) with a graphical user interface and software-development tools. 


## System requirements

- You need [VC++ 2019 Runtime](https://aka.ms/vs/17/release/vc_redist.x64.exe) 32-bit and 64-bit versions

- You will need .NET 6.

- You need to install the version of VC++ Runtime that CEFSharp needs. Since we are using CefSharp 106, according to [this](https://github.com/cefsharp/CefSharp/#release-branches) we need the above versions


## Getting started

- See the [Compilation Guide](Resources/Github/Compilation.md) for steps to get started.


## Documentation

- [User Guide](Resources/Github/Users.md)
- [Compilation Guide](Resources/Github/Compilation.md)
- [Configuration Guide](Resources/Github/Configuration.md)
- [Distribution Guide](Resources/Github/Distribution.md)


## Code

- Baby uses CefSharp 106 and is built on NET 6
- Baby supports AnyCPU as well as x86/x64 specific builds
- `WebBrowser.cs` - main web browser UI and related functionality
- `Callbacks` - various handlers that we have registered with CefSharp that enable deeper integration between us and CefSharp
- `Serializers` - fast JSON serializer/deserializer
- `bin` - Binaries are included in the `bin` folder due to the complex CefSharp setup required. Don't empty this folder.
- `bin/storage` - HTML and JS required for downloads manager and custom error pages

## Credits

## Screenshots

### Datagrids

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/1.png)

### Excel UI over SQLite database

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/5.png)

### Maps

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/6.png)

### Baby Browser

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/2.png)

### Budget Calculator

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/search.png)

### Fiscal Year Utility

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/3.png)

### Developer Tools

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/4.png)

### Custom Error Pages

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/error1.png)

![](https://github.com/KarmaScripter/Baby/blob/main/Properties/Images/error2.png)


