
## TODO
- Create DB if not exists - DbContext.Database.EnsureCreated()
  - https://stackoverflow.com/questions/39083372/how-to-read-connection-string-in-net-core
  - https://medium.com/@Usurer/ef-core-check-if-db-exists-feafe6e36f4e
  - https://jasonwatmore.com/dapper-sql-server-create-database-if-it-doesn-t-exist-on-startup-in-aspnet-core
  - https://www.binaryintellect.net/articles/87446533-54b3-41ad-bea9-994091686a55.aspx
  - https://stackoverflow.com/questions/38238043/how-and-where-to-call-database-ensurecreated-and-database-migrate
- Create Azure SQL Database
  - https://learn.microsoft.com/en-us/visualstudio/azure/end-to-end-deployment-entity-framework-core-github-actions?view=vs-2022
  - https://learn.microsoft.com/en-us/azure/azure-sql/database/single-database-create-quickstart?view=azuresql&tabs=azure-portal
- Create a workflow
  - https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel%2Caspnetcore
- Get Entity Framework Migrations working with workflow
  - https://learn.microsoft.com/en-us/azure/azure-sql/database/connect-github-actions-sql-db?view=azuresql&tabs=userlevel
  - https://learn.microsoft.com/en-us/azure/devops/pipelines/targets/azure-sqldb?view=azure-devops&tabs=yaml
  - https://stackoverflow.com/questions/59234655/apply-ef-migrations-in-github-workflow
  - Entity Framework CLI (dotnet ef)
    - dotnet ef database update
- Create Data project
  - Backup project
  - New Branch - Test before merging with main
  - https://efdocs.readthedocs.io/en/latest/entity-framework/core/managing-schemas/migrations/projects.html
- Repository Pattern?
  - https://www.codeproject.com/Articles/561584/Repository-Pattern-with-Entity-Framework-using
- Dependabot
  - https://medium.com/@nickfane/integrating-dependabot-into-your-net-core-project-on-github-3e3024bd3394
- Play with JsInterop
  - https://www.yogihosting.com/blazor-js-interop-javascript/
  - https://github.com/google/j2cl/blob/master/docs/jsinterop-by-example.md
  - https://dev.to/rasheedmozaffar/intro-to-js-interop-in-blazor-46mo
  - https://blazor-university.com/javascript-interop/
- Create image upload locally
  - Create a thumbnail on upload
    - Function App? Maybe using queues or event grid
- Create a blob container and a blob (page blobs I think)
  - https://learn.microsoft.com/en-us/azure/event-grid/storage-upload-process-images?tabs=azure-cli 
  - https://learn.microsoft.com/en-us/azure/storage/blobs/blob-upload-function-trigger?tabs=azure-portal
  - https://stackoverflow.com/questions/31531026/saving-images-in-azure-storage
  - https://blazor.syncfusion.com/documentation/file-upload/getting-started
- Enable images to be moved
- Implement Masonry.js
  - https://masonry.desandro.com/
- Display images
- Unit tests (include in workflow)
  - NUnit
  - Moq
  - FluentValidation
  - AutoFixture
  - Fakeiteasy
  - NSubstitute
  - Dapper
- Deployment slots (or Frontdoor - but I don't think it works with the Kainos Azure)
  - Update workflow to switch between deployment slots
- Redis Cache
- MediatR

## Optional Things
- Add Azure App Configuration
  - https://learn.microsoft.com/en-us/azure/azure-app-configuration/quickstart-aspnet-core-app
- Add Feature Management
  - https://learn.microsoft.com/en-us/azure/azure-app-configuration/concept-feature-management

## Useful Links
- JS Component Library
  - https://ui.shadcn.com/docs/installation/
- EF Migrations
  - https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
- Razor Pages
  - https://learn.microsoft.com/en-us/aspnet/core/razor-pages/razor-pages-conventions?view=aspnetcore-9.0

## Completed
- Authentication
- Use SendGrid to send email confirmation and forgot password emails
  - https://learn.microsoft.com/en-gb/aspnet/core/security/authentication/accconfirm?view=aspnetcore-9.0&tabs=visual-studio#debug
- Add user roles & role manager
  - https://blazorhelpwebsite.com/ViewBlogPost/21


## Markdown Cheatsheets
https://www.markdownguide.org/basic-syntax/#ordered-lists  
https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet  
https://github.com/tchapi/markdown-cheatsheet/blob/master/README.md

## Purpose of this app
Upload and display drone photos