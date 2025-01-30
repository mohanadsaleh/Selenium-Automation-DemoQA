# Selenium Automation DemoQA

This project demonstrates automated testing of the "DemoQA Practice Form" using Selenium WebDriver in C#. It performs actions such as filling out the form fields, selecting options, uploading files, and submitting the form.

## Features
- Automated form filling (name, email, phone, etc.).
- Selecting radio buttons and checkboxes.
- Uploading a file.
- Selecting a state and city from dropdowns.
- Submitting the form and verifying the success message.

## Prerequisites
- .NET SDK installed on your system.
- Visual Studio or any preferred IDE.
- Google Chrome browser.
- ChromeDriver matching the browser version.
- NuGet packages:
  - Selenium.WebDriver
  - Selenium.WebDriver.ChromeDriver
  - WebDriverManager

## How to Run
1. Clone the project to your local machine.
2. Open the project in Visual Studio.
3. Install required NuGet packages if not already installed.
4. Update the file path for the image in the `uploadPicture` section to a valid path on your system.
5. Run the `Test1` method in the `Tests` class.

## Acknowledgments
- DemoQA for providing the form used in testing.
- Selenium for making browser automation easy.
- WebDriverManager for simplifying driver setup.

## License
This project is licensed under the MIT License - see the LICENSE file for details.
