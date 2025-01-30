## Blazor
- https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-9.0
- https://blazor-university.com/forms/

## Blazor Base Components
- https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/components
- https://medium.com/@eric.bjorkvall_79393/blazor-base-components-part-1-loop-a60d56816eaa
- https://www.ripteq.com.au/blog/blazor-code-behinds-and-base-classes

## TODO

- Create image viewer templates
  - https://medium.com/@eric.bjorkvall_79393/blazor-base-components-part-1-loop-a60d56816eaa
  - https://www.ripteq.com.au/blog/blazor-code-behinds-and-base-classes
  - V0
    - https://v0.dev/chat/blazor-photo-gallery-nE7iWU2zkeV - good looking thumbnails
    - https://v0.dev/chat/blazor-photo-gallery-YfyftwlehvY - nice thumbs, average modal, lazy loading
    - https://v0.dev/chat/blazor-photo-gallery-IFRNzs1G7Ez - square thumbs, ugly modal but with nice arrows and X, lazy loading
    - https://v0.dev/chat/blazor-photo-gallery-8krlDrLUUwu - masonry, thumbnails need are large, they need padding and rounded corners, average modal with good looking arrows

  - ChatGPT
    - https://chatgpt.com/c/6798edf7-4e74-8001-8ff5-7c4a27b34992 - perfect thumbs & modal with good arrows
    - https://chatgpt.com/c/6798eed8-9518-8001-adda-0f7afdebed66 - masonry, thumbs don't span the full page, modal images are stretched and not centered
  
  - DeepSeek
    - https://chat.deepseek.com/a/chat/s/5825c267-40f0-47bd-99f7-8327d4302427 - perfect thumbs & modal with good arrows, keyboard modal navigation
    - https://chat.deepseek.com/a/chat/s/0536b9ce-d9b5-4571-8eef-55ab319305bf

- Combine image viewer with into final template

- Create MudBlazor NavMenu

- Create Data project (backup project or new branch)
  - https://efdocs.readthedocs.io/en/latest/entity-framework/core/managing-schemas/migrations/projects.html

- New DbContext (backup project or new branch)
  - Perform migrations on both DbContexts

- Repository Pattern / Generic Repository
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
- Create workflow
- Create Azure database
  - Create DB if not exists
  - Add migrations to workflow
  

## Markdown Cheatsheets
https://www.markdownguide.org/basic-syntax/#ordered-lists  
https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet  
https://github.com/tchapi/markdown-cheatsheet/blob/master/README.md

## Purpose of this app
Upload and display drone photos