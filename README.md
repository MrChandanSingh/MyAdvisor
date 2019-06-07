
# MyAdvisor
Initial setup has been done for caching and to understand how it is working. what are the thing we can do.
Unity Container has been used for resolving dependency.
##[My Learning path]
This project has been created for learning & practice of good concept and it's implementation.
Writting a good and understandable example code from day to day learning a new concept. 
Table Contents:
1. How to create your custom & generic session management.
2. Unit testing using Moq framework.
3. Data-Structure & Algorithm learning practice.
4. Clean code writting practice.

##Technologies:
1. Net Core, .Net Framework 4.5, MVC5, C#

##Setup:
Need visual studio with latest version of .Net work framework install for selected project. Few project has been developed using .NetCore and few has been developed using .Net Framework 4.5, MVC5.
To #Run Web-Application you need to have IIS server install on your operating system.
For #Console Application, You can simply select that that project as start up project and run it.

#Session Management
I have created one project ##"cache management". where the requiremtn is like , Once the user fetch data from database and did some logical analysis to get final expected data. Now the user wants to keep it somewhere in cache(application) as output data. so next time when they need this data then they do not need to do same logical analysis to get expected data instead get it from session ***data will be present till current user logged in. Once he logged out, the data will be vanished from session**. 
So to resolve above problem, I created "Cache Management" project. A part from above requirement implementation, I have also added few nice concept as well like Generic implementation to avoid writting duplicate code for different module of the application.
##In-Progress: Working on Unit-Testing for above implementation.

#Future Implementation:
Requirement: Create a utility to be used through out the application like ##Export-To-Excel. I have plan to implement a very generic with a very minimum about of logic repetition. 
Technologies: C#, Net4.5.
Infrastructure : IIS Server.

