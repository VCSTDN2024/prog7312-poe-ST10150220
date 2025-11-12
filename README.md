## Author
ST10150220 (Shainal Lala)

## Technology Stack
- C# (.NET)
- Windows Forms
- SQL Server (SSMS)
- Entity Framework Core

## What this app does
- Connects to an SSMS database where serivce delivery data is stored
- Events can be searched for using the simplistic UI
- Reports can be submitted via the reports page
- Report Status can be views in app too

## Report Status Page
- the latest edition to the app
- lets users view the status of their submission
- scalability has been accounted for in the form of "StatusDescription" and a status of "Declined"
- Municipality employees will be able to provide description of the status (perhaps updates on where repairs are)
- The reason for the "decline" status is to prevent non municipality issues being submitted

## How to
1. Use the Terminal or Git tab in MS Visual Studio to pull from the repository
2. Open the code in MS Visual Studio
3. Adjustments may need to be made to the connection string in App.config to match your local machine
4. Migrate to database if my one is unavailable 
5. Run App