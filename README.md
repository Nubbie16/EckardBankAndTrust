# EckardBankAndTrust

Written   1/8/2026

## Description
This program is an extension of a C++ college course programming problem that asked the programmer to create multiple structures of
"Bank Customers" and the ability to edit customer information. I took this programming problem and expanded it to be a UI-driven
application for a self-service banking app that would be used in a kiosk in a physical bank. I am using this as my Programming Capstone Project.

The program has the following main functions:
- Log In Screen with hidden password
- Ability to create a new account
- Able to deposit and withdraw money
- Edit customer information
- Export customer information to .txt file

## Technologies Used
- VB.NET
- Microsoft Visual Studio 2022
- Framework net8.0-windows

## How to Run
If you do not have Microsoft Visual Studio 2022 installed on your computer:
- Go to a search engine and look up Microsoft Visual Studio 2022, go to
	the Microsoft site result and download the free version of Visual Studio 2022

Once Microsoft Visual Studio 2022 is installed:
- Select the green "<> Code" in the top right and then "Download ZIP"
- Extract compressed folder and files
- Open Powershell on your computer and enter the command cd "[PATH TO THE EXTRACTED FOLDER AND FILES]"
	ex) cd "C:\Users\eckar\OneDrive\Downloads"
- end the next command "Get-ChildItem -Recurse | Unblock-File"
      *This will remove the "mark of the web" protection that prevents the program to run.
- Open the file "EckardBankTrust.sln"
- When Visual Studio opens, allow VS to trust the project
- Once the IDE is loaded, you should see the program name at the very top of the window "EckardBankTrust"
- Directly under the name, click the filled in green arrow with "EBaT_UI" to run the program.

### Additional Notes
- When the program executes, a "RawData.txt" text file will be created on the computer's 
	C: Drive inside a folder called "EckardBankTrustData", as well as an "AuditLog.txt" text file.
- These files are meant to hold customer data(entered test data if a file isn't already present) and a general
  audit log, respectfully, and can be 	deleted afterward.

## *NOTE*
I am very new to Github and am learning as I go, so please be patient with me.
