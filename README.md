Selenium NUnit Tests Demo Framework
===================================

This project is a **Selenium-based test automation framework** built using **C#** and **NUnit**. It demonstrates how to set up and run automated browser tests using **ChromeDriver** and the **WebDriverManager** for dependency management.

Table of Contents
-----------------

*   [Prerequisites](#prerequisites)
    
*   [Installation](#installation)
    
*   [Usage](#usage)
    
*   [Running Tests](#running-tests)
    
*   [License](#license)
    

Prerequisites
-------------

Before you can run this project, ensure you have the following installed:

*   [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
    
*   Google Chrome (ensure the Chrome version matches with ChromeDriver)
    
*   ChromeDriver
    
*   IDE like [Visual Studio](https://visualstudio.microsoft.com/) or [Rider](https://www.jetbrains.com/rider/)
    

Installation
------------

1. Clone the repository:
```bash
git clone https://github.com/iuriimoroz/SeleniumNUnitTestsDemoFramework.git
cd SeleniumNUnitTestsDemoFramework
  ```
    
2. Restore the required NuGet packages by running:
```bash
dotnet restore
```
    
3.  Install them using the NuGet Package Manager
```bash
dotnet add package Selenium.WebDriver
dotnet add package WebDriverManager
dotnet add package NUnit
```

Usage
-----

This project automates browser-based tests using Chrome. To run the tests:

1.  Ensure **Google Chrome** is installed and that the **ChromeDriver** is properly set up.
    
2.  The tests use **WebDriverManager** to automatically manage the ChromeDriver version, but if needed, you can manually specify versions or update them in the test code.
    
3. The sample code in this test automation framework:

    *   Navigates to **GitHub**
        
    *   Performs a search for the term **"Selenium"**
        
    *   Verifies that the search results contain relevant content (i.e., search results related to Selenium)

Running Tests
-------------

You can run the tests using the **NUnit** framework. To execute the tests:

1.  Open a terminal or command prompt in the project directory.
    
2. Run the following command:
```bash
dotnet test
```
This will trigger the **NUnit** test runner to execute the browser tests and verify the results.

License
-------

This project is licensed under the MIT License - see the LICENSE file for details.
