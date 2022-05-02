# __In the Name of ALLAH__
---
## Test Your Environment Lab - First ASP.NET Core Web Application
---
> __Lab Overview__

- In this lab, you will follow the guidelines and create your first ASP.NET Core web application.
-  This will allow you test your development environment configuration and also allows you to check some important files and folders for the remainder of this course.
---

- Please note, the prerequisite for this lab is the development environment has been built according to the Lab Preconfiguration Steps.
---
## Create an ASP.NET Core Web Application
- Create a working folder called Projects. This is where we put all our practice projects in this course.

- Create a subfolder called __HelloMVC__, under the Projects. This is the root folder for our current project.
- Right click the __HelloMVC folder__, then click Open with Code. (You may need to open the folder directly from within VS Code) if the right-click menu is not an option.

- In __Visual Studio Code__, use __View|Integrated__ Terminal or __Ctrl+\`__ to open the integrated command line panel.

- Input and run command __dotnet new mvc__.
- This will create an ASP.NET Core web application .

-  Since the project root folder's name is HelloMVC, the name of the project and the root namespace are all set to HelloMVC.

- We also call this step scaffolding.
- Please note, the equivalent operations of doing step 2 to step 5 outside of VS Code is: launch cmd.exe or PowerShell, enter C:\Projects, execute dotnet new mvc --name HelloMVC.

-  The HelloMVC project root folder will be created and you can open it in Visual Studio Code.

- Next, input and run the command __dotnet restore__. This will restore all dependencies for the project by leveraging NuGet.

- Input and run command __dotnet run__. This will start the web application.
Start your web browser, Microsoft Edge or Google Chrome is recommended. Access http://localhost:5000. You should see a simple website.

- In the command line, press Ctrl+C will stop the web application.

- Launch and Debug The Web Application in Visual Studio Code

- Use View|Explorer or Ctrl+Shift+E to open the Explorer panel. You should see all the source code of the project.

- Open Program.cs or Startup.cs. Wait for about ten seconds, you should see a warning message “Required assets to build and debug are missing from ‘HelloMVC’. Add them?". Click "Yes” button, Visual Studio Code will create a project root level folder called .vscode.
-  There are two critical configuration files in the folder - __launch.json__ and __tasks.json__.
- Use __View|Debug or Ctrl+Shift+D__ to open the Debug panel.
-  Look at the toolbar on the top, you should see the Start Debug (green triangle) button, the dropdown list for picking proper configuration, and the Open launch.json (gear) button. The selected configuration should be ".NET Core Launch (web)".

-  This configuration is generated by operations in step 2.
-  Please note, if you see a red dot on the gear button, just restart Visual Studio Code, then the red dot will disappear.
-  It is a bug in current version Visual Studio Code (1.16.1), as of the writing of this content.

- Click the Start Debug button. Visual Studio Code will start the web application and launch the web browser to access http://localhost:5000.

- To stop the debugging, you have to click the Stop (red rectangle) button. Closing the web browser won't stop the debugging.

- Switch to the Explorer panel.
-  Open the file Controllers\HomeController.cs.
- Find the About method and change the code ViewData["Message"] = "Your application description page."; to ViewData["Message"] = "This is my first ASP.NET Core web application!";.

- Set a break point on this line and run the application again.

- In the web browser, click the “About” hyperlink on the navigation bar, you should see the execution hit the break point.
- Continue the execution, you should see "This is my first ASP.NET Core web application!" shows on the About page.
Remove Generated Assets
- There are three project root level folders that are very critical to us - the __Models folder, the Controllers folder, and the Views folder__.
-  For our practices in the course, we always start from scratch. So, let's clear those auto-generated assets from these three folders.

- The best way to do that is delete and recreate the folders.
 If the integrated terminal of your Visual Studio Code is PowerShell, please comfirm the working directory is C:\Projects\HelloMVC then run the command below:

~~~
- Remove-Item .\Models -Force -Recurse
- Remove-Item .\Views -Force -Recurse
- Remove-Item .\Controllers -Force -Recurse
- New-Item .\Models -Type directory
- New-Item .\Views -Type directory
- New-Item .\Controllers -Type directory
- If the terminal is cmd.exe, please confirm the working directory is C:\Projects\HelloMVC then run the commands below:

rd Models /s /q
rd Views /s /q
rd Controllers /s /q
md Models
md Views
md Controllers
You can also do the delete-recreate operation with Visual Studio Code manually in the explorer view.
~~~